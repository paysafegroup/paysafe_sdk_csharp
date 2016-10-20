using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Paysafe;
using Authorization = Paysafe.CardPayments.Authorization;

namespace SampleApp
{
    public partial class card_payment_simple : System.Web.UI.Page
    {
        protected String payment_id = null;

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

            btnSubmit.Click += new System.EventHandler(this.submit);
        }

        protected void submit(object sender, System.EventArgs e)
        {
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];
            string apiSecret = System.Configuration.ConfigurationManager.AppSettings["ApiSecret"];
            string accountNumber = System.Configuration.ConfigurationManager.AppSettings["accountNumber"];
            int currencyBaseUnitsMultiplier = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["CurrencyBaseUnitsMultiplier"]);

           PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);
            Authorization auth = client.cardPaymentService().authorize(Authorization.Builder()
                .merchantRefNum(Request.Form["merchant_ref_num"])
                .amount(Convert.ToInt32(Double.Parse(Request.Form["amount"]) * currencyBaseUnitsMultiplier))
                .settleWithAuth(true)
                .card()
                    .cardNum(Request.Form["card_number"])
                    .cvv(Request.Form["card_cvv"])
                    .cardExpiry()
                        .month(Convert.ToInt32(Request.Form["card_expiry_month"]))
                        .year(Convert.ToInt32(Request.Form["card_expiry_month"]))
                        .Done()
                    .Done()
                    .billingDetails()
                        .street(Request.Form["street"])
                        .city(Request.Form["city"])
                        .state(Request.Form["state"])
                        .country(Request.Form["country"])
                        .zip(Request.Form["zip"])
                        .Done()
                .Build());
            this.payment_id = auth.id();
        }
    }
}