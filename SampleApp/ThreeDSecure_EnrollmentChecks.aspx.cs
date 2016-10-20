using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Paysafe;
using EnrollmentChecks = Paysafe.ThreeDSecure.EnrollmentChecks;

namespace SampleApp
{
    public partial class ThreeDSecure : System.Web.UI.Page
    {
        protected string response = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ui = System.Globalization.CultureInfo.CurrentUICulture;
            btnSubmit.Click += new System.EventHandler(this.submit);
        }
        protected void submit(object sender, System.EventArgs e)
        {
            string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];
            string apiSecret = System.Configuration.ConfigurationManager.AppSettings["ApiSecret"];
            string accountNumber = System.Configuration.ConfigurationManager.AppSettings["AccountNumber"];

            PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);
            try
            {
                EnrollmentChecks enrollmentChecks = EnrollmentChecks.Builder()
                 .merchantRefNum(Request.Form["merchant_customer_id"])
                 .amount(Convert.ToInt32(Double.Parse(Request.Form["amount"])))
                 .currency(Request.Form["currency"])
                 .customerIp(Request.Form["customerIp"])
                 .userAgent(Request.Form["userAgent"])
                 .card()
                    .cardNum(Request.Form["cardNum"])
                    .cardExpiry()
                        .month(Convert.ToInt32(Double.Parse(Request.Form["month"])))
                        .year(Convert.ToInt32(Double.Parse(Request.Form["year"])))
                        .Done()
                    .Done()
                 .acceptHeader(Request.Form["acceptHeader"])
                 .merchantUrl(Request.Form["merchantUrl"])
                 .Build();

                EnrollmentChecks response = client.threeDSecureService().submit(enrollmentChecks);
                this.response = response.ToString();
            }
            catch (Exception ex)
            {
                Response.Write("<font style=\"color: #FF0000;\">Error Message is : " + ex.Message + "</font>\n");
            }
        }
    }
}