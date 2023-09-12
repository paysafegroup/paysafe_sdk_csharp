﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Paysafe;
using Authentication = Paysafe.ThreeDsecureV2.Authentications;


namespace SampleApp
{
    public partial class ThreeDSecureV2_Authentication : System.Web.UI.Page
    {
        protected string sdkChallengePayload = null;
        protected string accountNumber = null;
        protected string b64FingerprintGeneratingKey = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ui = System.Globalization.CultureInfo.CurrentUICulture;
            string[] monthNames = ui.DateTimeFormat.MonthNames;
            int monthsInYear = ui.Calendar.GetMonthsInYear(DateTime.Now.Year);

            int monthNumber = 0;
            var monthsDataSource = monthNames.Take(monthsInYear).Select(monthName => new
            {
                Name = monthName,   
                Value = ++monthNumber
            });

            this.card_expiry_month.DataTextField = "Name";
            this.card_expiry_month.DataValueField = "Value";
            this.card_expiry_month.DataSource = monthsDataSource;

            this.card_expiry_month.DataBind();
            if (Request.Form["card_expiry_month"] == null)
            {
                this.card_expiry_month.SelectedValue = DateTime.Now.Month.ToString();
            }

            for (int i = 0; i < 5; i++)
            {
                String year = (DateTime.Today.Year + i).ToString();
                ListItem li = new ListItem(year, year);
                this.card_expiry_year.Items.Add(li);
            }

            accountNumber = System.Configuration.ConfigurationManager.AppSettings["AccountNumber"];
            string SutKey = System.Configuration.ConfigurationManager.AppSettings["SutKey"];
            string SutPassword = System.Configuration.ConfigurationManager.AppSettings["SutPassword"];
            var SutBytes = System.Text.Encoding.UTF8.GetBytes($"{SutKey}:{SutPassword}");
            b64FingerprintGeneratingKey = Convert.ToBase64String(SutBytes);

            btnSubmit.Click += new System.EventHandler(this.submit);
        }
        protected void submit(object sender, System.EventArgs e)
        {
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];
            string apiSecret = System.Configuration.ConfigurationManager.AppSettings["ApiSecret"];
            int currencyBaseUnitsMultiplier = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["CurrencyBaseUnitsMultiplier"]);
           
            PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);

            try
            {
                var authBuilt = Authentication.Builder()
                     .merchantRefNum(Request.Form["merchant_customer_id"])
                     .amount(Convert.ToInt64(Double.Parse(Request.Form["amount"], System.Globalization.NumberStyles.AllowDecimalPoint) * currencyBaseUnitsMultiplier))
                     .currency(Request.Form["currency"])
                     .deviceFingerprintingId(Request.Form["deviceFingerprintingId"])
                     .card()
                        .holderName(Request.Form["holderName"])
                        .cardNum(Request.Form["card_number"])
                        .cardExpiry()
                        .month(Convert.ToInt32(Request.Form["card_expiry_month"]))
                        .year(Convert.ToInt32(Request.Form["card_expiry_year"]))
                        .Done()
                    .Done()
                .merchantUrl(Request.Form["merchantUrl"])
                .authenticationPurpose(Request.Form["authenticationPurpose"])
                .deviceChannel(Request.Form["deviceChannel"])
                .messageCategory(Request.Form["messageCategory"])
                .Build();

                Authentication authentication = client.threeDSecureV2Service().authentications(authBuilt);
                TextBoxauthenticationId.Text = authentication.id();
                TextBoxstatus.Text = authentication.status(); // COMPLETED, PENDING or FAILED
                TextBoxthreeDSecureVersion.Text = authentication.threeDSecureVersion();
                string threeDResult = authentication.threeDResult();
                TextBoxthreeDResult.Text = threeDResult;
                if (threeDResult == "C")
                {
                    PlaceHolderChallenge.Visible = true;
                    this.sdkChallengePayload = authentication.sdkChallengePayload();
                    TextBoxsdkChallengePayload.Text = this.sdkChallengePayload;
                }
                PlaceHolderAuthCompleted.Visible = true;
                PlaceHolderAuthRequest.Visible = false;
            }
            catch (Exception ex)
            {
                Response.Write("<font style=\"color: #FF0000;\">Error Message is : " + ex.Message + "</font>\n");
            }
        }
    }
}