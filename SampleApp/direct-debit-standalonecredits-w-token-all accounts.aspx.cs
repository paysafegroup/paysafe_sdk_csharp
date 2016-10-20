using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Paysafe;
using Purchases = Paysafe.DirectDebit.Purchases;
namespace SampleApp
{
    public partial class direct_debit_standalonecredits_w_token_all_accounts : System.Web.UI.Page
    {
        protected String response = null;
        protected string accountName;
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ui = System.Globalization.CultureInfo.CurrentUICulture;
            btnSubmit.Click += new System.EventHandler(this.submit);
        }
        protected void submit(object sender, System.EventArgs e)
        {
            try
            {
                string apiKey = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];
                string apiSecret = System.Configuration.ConfigurationManager.AppSettings["ApiSecret"];

                string val = radio.SelectedItem.Value.ToString();
                if (val.Equals("ACH"))
                {
                    string accountNumber = System.Configuration.ConfigurationManager.AppSettings["AccountNumber"];
                   PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);

                    Paysafe.CustomerVault.Profile profile = client.customerVaultService().create(
                        Paysafe.CustomerVault.Profile.Builder()
                               .merchantCustomerId(System.Guid.NewGuid().ToString())
                               .locale("en_US")
                               .firstName("John")
                               .lastName("Smith")
                               .email("john.smith@somedomain.com")
                               .phone("713-444-5555")
                               .Build());

                    Paysafe.CustomerVault.Address address = client.customerVaultService().create(
                        Paysafe.CustomerVault.Address.Builder()
                               .nickName("home")
                               .street("100 Queen Street West")
                               .street2("Unit 201")
                               .city("Toronto")
                               .country("CA")
                               .state("ON")
                               .zip("M5H 2N2")
                               .recipientName("Jane Doe")
                               .phone("647-788-3901")
                               .profileId(profile.id())
                               .Build());

                    Paysafe.CustomerVault.ACHBankAccounts account = client.customerVaultService().create(
                        Paysafe.CustomerVault.ACHBankAccounts.Builder()
                                .nickName("Johns RBC Business Bank Account")
                                .accountNumber(getRandomNumber())
                                .routingNumber("123456789")
                                .accountHolderName("XYZ Business")
                                .billingAddressId(address.id())
                                .accountType("CHECKING")
                                .merchantRefNum(System.Guid.NewGuid().ToString())
                                .profileId(profile.id())
                                .Build());

                    Purchases purchase = Purchases.Builder()
                               .merchantRefNum(Request.Form["merchant_customer_id"])
                               .amount(Convert.ToInt32(Double.Parse(Request.Form["amount"])))
                               .ach()
                                   .paymentToken(account.paymentToken())
                                   .payMethod("WEB")
                                    .Done()
                                .Build();
                    Purchases response = client.directDebitService().submit(purchase);
                    this.response = response.ToString();
                }
                else if (val.Equals("BACS"))
                {
                    string accountNumber = System.Configuration.ConfigurationManager.AppSettings["AccountNumber_BACS"];
                   PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);

                    Purchases purchase = Purchases.Builder()
                        .merchantRefNum(Request.Form["merchant_customer_id"])
                        .amount(Convert.ToInt32(Double.Parse(Request.Form["amount"])))
                        .bacs()
                            .paymentToken(Request.Form["payment_token"])
                             .Done()
                         .Build();
                    Purchases response = client.directDebitService().submit(purchase);
                    this.response = response.ToString();
                }
                else if (val.Equals("EFT"))
                {
                    string accountNumber = System.Configuration.ConfigurationManager.AppSettings["AccountNumber_EFT"];
                   PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);

                    Paysafe.CustomerVault.Profile profile = client.customerVaultService().create(
                   Paysafe.CustomerVault.Profile.Builder()
                   .merchantCustomerId(System.Guid.NewGuid().ToString())
                   .locale("en_US")
                   .firstName("John")
                   .lastName("Smith")
                   .email("john.smith@somedomain.com")
                   .phone("713-444-5555")
                   .Build());

                    Paysafe.CustomerVault.Address address = client.customerVaultService().create(
                        Paysafe.CustomerVault.Address.Builder()
                       .nickName("home")
                       .street("100 Queen Street West")
                       .street2("Unit 201")
                       .city("Toronto")
                       .country("CA")
                       .state("ON")
                       .zip("M5H 2N2")
                       .recipientName("Jane Doe")
                       .phone("647-788-3901")
                       .profileId(profile.id())
                       .Build());

                    Paysafe.CustomerVault.EFTBankAccounts account = client.customerVaultService().create(
                        Paysafe.CustomerVault.EFTBankAccounts.Builder()
                         .accountNumber(getRandomNumber())
                        .transitNumber("11224")
                        .institutionId("123")
                        .accountHolderName("John Smith")
                        .nickName("Johns RBC Business Bank Account")
                        .billingAddressId(address.id())
                        .profileId(profile.id())
                        .Build());

                    Purchases response = client.directDebitService().submit(Purchases.Builder()
                     .merchantRefNum(System.Guid.NewGuid().ToString())
                     .amount(10038)
                     .eft()
                          .paymentToken(Request.Form["payment_token"])
                     .Done()
                        .Build()
                        );
                    this.response = response.ToString();
                }
                else if (val.Equals("SEPA"))
                {
                    string accountNumber = System.Configuration.ConfigurationManager.AppSettings["AccountNumber_SEPA"];
                   PaysafeApiClient client = new PaysafeApiClient(apiKey, apiSecret, Paysafe.Environment.TEST, accountNumber);

                    Purchases response = client.directDebitService().submit(Purchases.Builder()
                     .merchantRefNum(System.Guid.NewGuid().ToString())
                     .amount(10038)
                      .sepa()
                        .paymentToken(Request.Form["payment_token"])
                        .Done()
                        .Build()
                        );
                    this.response = response.ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<font style=\"color: #FF0000;\">Error Message is : " + ex.Message + "</font>\n");
            }
        }
        /// <summary>
        /// Get Random number 
        /// </summary>
        /// <param name="Number">getRandomNumber</param>
        /// <returns>10 digit number</returns>
        private string getRandomNumber()
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            int ch;
            for (int i = 0; i < 8; i++)
            {
                ch = Convert.ToInt32(random.Next(0, 9));
                builder.Append(ch);
            }

            string val = builder.ToString();
            return val;
        }
    }
}