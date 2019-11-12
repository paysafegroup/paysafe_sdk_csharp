using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;
namespace Paysafe.ThreeDsecureV2
{
    public class UserAccountDetails : JSONObject
    {
        /// <summary>
        /// Initialize the UserAccountDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public UserAccountDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.addCardAttemptsForLastDay, INT_TYPE},
            {ThreeDSecureV2Constants.changedDate, STRING_TYPE},
            {ThreeDSecureV2Constants.changedRange, ThreeDSecureV2Constants.enumChangedRange },
            {ThreeDSecureV2Constants.createdDate, STRING_TYPE},  
            {ThreeDSecureV2Constants.createdRange, ThreeDSecureV2Constants.enumCreatedRange },
            {ThreeDSecureV2Constants.passwordChangedDate, STRING_TYPE},
            {ThreeDSecureV2Constants.passwordChangedRange, ThreeDSecureV2Constants.enumPasswordChangedRange },
            {ThreeDSecureV2Constants.paymentAccountDetails, typeof(PaymentAccountDetails)},
            {ThreeDSecureV2Constants.priorThreeDSAuthentication, typeof(PriorThreeDSAuthentication)},
            {ThreeDSecureV2Constants.shippingDetailsUsage, typeof(ShippingDetailsUsage)},
            {ThreeDSecureV2Constants.suspiciousAccountActivity, BOOL_TYPE},  
            {ThreeDSecureV2Constants.totalPurchasesSixMonthCount, INT_TYPE}, 
            {ThreeDSecureV2Constants.transactionCountForPreviousDay, INT_TYPE}, 
            {ThreeDSecureV2Constants.transactionCountForPreviousYear, INT_TYPE}, 
            {ThreeDSecureV2Constants.travelDetails, typeof(TravelDetails)},
            {ThreeDSecureV2Constants.userLogin, typeof(UserLogin)}                  
          };

        /// <summary>
        /// Get the addCardAttemptsForLastDay
        /// </summary>
        /// <returns>int</returns>
        public int addCardAttemptsForLastDay()
        {
            return this.getProperty(ThreeDSecureV2Constants.addCardAttemptsForLastDay);
        }

        /// <summary>
        /// Set the addCardAttemptsForLastDay
        /// </summary>
        /// <param name=data>int</param>
        public void addCardAttemptsForLastDay(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.addCardAttemptsForLastDay, data);
        }

        /// <summary>
        /// Get the changedDate
        /// </summary>
        /// <returns>string</returns>
        public string changedDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.changedDate);
        }

        /// <summary>
        /// Set the changedDate
        /// </summary>
        /// <param name=data>string</param>
        public void changedDate(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.changedDate, data);
        }


        /// <summary>
        /// Get the changedRange
        /// </summary>
        /// <returns>string</returns>
        public string changedRange()
        {
            return this.getProperty(ThreeDSecureV2Constants.changedRange);
        }

        /// <summary>
        /// Set the changedRange
        /// </summary>
        /// <param name=data>string</param>
        public void changedRange(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.changedRange, data);
        }

        /// <summary>
        /// Get the createdDate
        /// </summary>
        /// <returns>string</returns>
        public string createdDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.createdDate);
        }

        /// <summary>
        /// Set the createdDate
        /// </summary>
        /// <param name=data>string</param>
        public void createdDate(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.createdDate, data);
        }

        /// <summary>
        /// Get the createdRange
        /// </summary>
        /// <returns>string</returns>
        public string createdRange()
        {
            return this.getProperty(ThreeDSecureV2Constants.createdRange);
        }

        /// <summary>
        /// Set the createdRange
        /// </summary>
        /// <param name=data>string</param>
        public void createdRange(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.createdRange, data);
        }

        /// <summary>
        /// Get the passwordChangedDate
        /// </summary>
        /// <returns>string</returns>
        public string passwordChangedDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.passwordChangedDate);
        }

        /// <summary>
        /// Set the passwordChangedDate
        /// </summary>
        /// <param name=data>string</param>
        public void passwordChangedDate(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.passwordChangedDate, data);
        }


        /// <summary>
        /// Get the passwordChangedRange
        /// </summary>
        /// <returns>string</returns>
        public string passwordChangedRange()
        {
            return this.getProperty(ThreeDSecureV2Constants.passwordChangedRange);
        }

        /// <summary>
        /// Set the passwordChangedRange
        /// </summary>
        /// <param name=data>string</param>
        public void passwordChangedRange(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.passwordChangedRange, data);
        }

        /// <summary>
        /// Get the paymentAccountDetails
        /// </summary>
        /// <returns>PaymentAccountDetails</returns>
        public PaymentAccountDetails paymentAccountDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.paymentAccountDetails);
        }

        /// <summary>
        /// Set the paymentAccountDetails
        /// </summary>
        /// <param name=data>PaymentAccountDetails</param>
        public void paymentAccountDetails(PaymentAccountDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.paymentAccountDetails, data);
        }

        /// <summary>
        /// Get the priorThreeDSAuthentication
        /// </summary>
        /// <returns>priorThreeDSAuthentication</returns>
        public PriorThreeDSAuthentication priorThreeDSAuthentication()
        {
            return this.getProperty(ThreeDSecureV2Constants.priorThreeDSAuthentication);
        }

        /// <summary>
        /// Set the priorThreeDSAuthentication
        /// </summary>
        /// <param name=data>PaymentAccountDetails</param>
        public void priorThreeDSAuthentication(PriorThreeDSAuthentication data)
        {
            this.setProperty(ThreeDSecureV2Constants.priorThreeDSAuthentication, data);
        }

        /// <summary>
        /// Get the shippingDetailsUsage
        /// </summary>
        /// <returns>shippingDetailsUsage</returns>
        public ShippingDetailsUsage shippingDetailsUsage()
        {
            return this.getProperty(ThreeDSecureV2Constants.shippingDetailsUsage);
        }

        /// <summary>
        /// Set the ShippingDetailsUsage
        /// </summary>
        /// <param name=data>ShippingDetailsUsage</param>
        public void shippingDetailsUsage(ShippingDetailsUsage data)
        {
            this.setProperty(ThreeDSecureV2Constants.shippingDetailsUsage, data);
        }

        /// <summary>
        /// Get the suspiciousAccountActivity
        /// </summary>
        /// <returns>bool</returns>
        public bool suspiciousAccountActivity()
        {
            return this.getProperty(ThreeDSecureV2Constants.suspiciousAccountActivity);
        }

        /// <summary>
        /// Set the suspiciousAccountActivity
        /// </summary>
        /// <param name=data>bool</param>
        public void suspiciousAccountActivity(bool data)
        {
            this.setProperty(ThreeDSecureV2Constants.suspiciousAccountActivity, data);
        }

        /// <summary>
        /// Get the totalPurchasesSixMonthCount
        /// </summary>
        /// <returns>int</returns>
        public int totalPurchasesSixMonthCount()
        {
            return this.getProperty(ThreeDSecureV2Constants.totalPurchasesSixMonthCount);
        }

        /// <summary>
        /// Set the totalPurchasesSixMonthCount
        /// </summary>
        /// <param name=data>int</param>
        public void totalPurchasesSixMonthCount(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.totalPurchasesSixMonthCount, data);
        }

        /// <summary>
        /// Get the transactionCountForPreviousDay
        /// </summary>
        /// <returns>int</returns>
        public int transactionCountForPreviousDay()
        {
            return this.getProperty(ThreeDSecureV2Constants.transactionCountForPreviousDay);
        }

        /// <summary>
        /// Set the transactionCountForPreviousDay
        /// </summary>
        /// <returns>void</returns>
        public void transactionCountForPreviousDay(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.transactionCountForPreviousDay, data);
        }


        /// <summary>
        /// Get the transactionCountForPreviousYear
        /// </summary>
        /// <returns>int</returns>
        public int transactionCountForPreviousYear()
        {
            return this.getProperty(ThreeDSecureV2Constants.transactionCountForPreviousYear);
        }

        /// <summary>
        /// Set the transactionCountForPreviousYear
        /// </summary>
        /// <returns>void</returns>
        public void transactionCountForPreviousYear(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.transactionCountForPreviousYear, data);
        }


        /// <summary>
        /// Get the travelDetails
        /// </summary>
        /// <returns>travelDetails</returns>
        public TravelDetails travelDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.travelDetails);
        }

        /// <summary>
        /// Set the travelDetails
        /// </summary>
        /// <returns>void</returns>
        public void travelDetails(TravelDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.travelDetails, data);
        }


        /// <summary>
        /// Get the userLogin
        /// </summary>
        /// <returns>userLogin</returns>
        public UserLogin userLogin()
        {
            return this.getProperty(ThreeDSecureV2Constants.userLogin);
        }

        /// <summary>
        /// Set the userLogin
        /// </summary>
        /// <returns>void</returns>
        public void userLogin(UserLogin data)
        {
            this.setProperty(ThreeDSecureV2Constants.userLogin, data);
        }


        /// <summary>
        /// UserAccountDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow an UserAccountDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class UserAccountDetailsBuilder<TBLDR> : NestedJSONBuilder<UserAccountDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the UserAccountDetailsBuilder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public UserAccountDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the addCardAttemptsForLastDay
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> addCardAttemptsForLastDay(int data)
            {
                this.properties[ThreeDSecureV2Constants.addCardAttemptsForLastDay] = data;
                return this;
            }

            /// <summary>
            /// Set the changedDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> changedDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.changedDate] = data;
                return this;
            }


            /// <summary>
            /// Set the changedRange
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> changedRange(string data)
            {
                this.properties[ThreeDSecureV2Constants.changedRange] = data;
                return this;
            }

            /// <summary>
            /// Set the createdDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> createdDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.createdDate] = data;
                return this;
            }

            /// <summary>
            /// Set the createdRange
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> createdRange(string data)
            {
                this.properties[ThreeDSecureV2Constants.createdRange] = data;
                return this;
            }

            /// <summary>
            /// Set the passwordChangedDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> passwordChangedDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.passwordChangedDate] = data;
                return this;
            }

            /// <summary>
            /// Set the passwordChangedRange
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> passwordChangedRange(string data)
            {
                this.properties[ThreeDSecureV2Constants.passwordChangedRange] = data;
                return this;
            }


            /// <summary>
            /// Build a payment account details within this User account.
            /// </summary>
            /// <returns>PaymentAccountDetails.PaymentAccountDetailsBuilder<PaymentAccountDetailsBuilder<TBLDR>></returns>
            public PaymentAccountDetails.PaymentAccountDetailsBuilder<UserAccountDetailsBuilder<TBLDR>> paymentAccountDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.paymentAccountDetails))
                {
                    this.properties[ThreeDSecureV2Constants.paymentAccountDetails] = new PaymentAccountDetails.PaymentAccountDetailsBuilder<UserAccountDetailsBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureV2Constants.paymentAccountDetails] as PaymentAccountDetails.PaymentAccountDetailsBuilder<UserAccountDetailsBuilder<TBLDR>>;
            }


            /// <summary>
            /// Build a Prior ThreeDS authentication within this User account.
            /// </summary>
            /// <returns>PriorThreeDSAuthentication.PriorThreeDSAuthenticationBuilder<PriorThreeDSAuthenticationBuilder<TBLDR>></returns>
            public PriorThreeDSAuthentication.PriorThreeDSAuthenticationBuilder<UserAccountDetailsBuilder<TBLDR>> priorThreeDSAuthentication()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.priorThreeDSAuthentication))
                {
                    this.properties[ThreeDSecureV2Constants.priorThreeDSAuthentication] = new PriorThreeDSAuthentication.PriorThreeDSAuthenticationBuilder<UserAccountDetailsBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureV2Constants.priorThreeDSAuthentication] as PriorThreeDSAuthentication.PriorThreeDSAuthenticationBuilder<UserAccountDetailsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Build a Shipping Details Usage  within this User account.
            /// </summary>
            /// <returns>ShippingDetailsUsage.ShippingDetailsUsageBuilder<ShippingDetailsUsageBuilder<TBLDR>></returns>
            public ShippingDetailsUsage.ShippingDetailsUsageBuilder<UserAccountDetailsBuilder<TBLDR>> shippingDetailsUsage()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.shippingDetailsUsage))
                {
                    this.properties[ThreeDSecureV2Constants.shippingDetailsUsage] = new ShippingDetailsUsage.ShippingDetailsUsageBuilder<UserAccountDetailsBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureV2Constants.shippingDetailsUsage] as ShippingDetailsUsage.ShippingDetailsUsageBuilder<UserAccountDetailsBuilder<TBLDR>>;
            }


            /// <summary>
            /// Set the suspiciousAccountActivity
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> suspiciousAccountActivity(bool data)
            {
                this.properties[ThreeDSecureV2Constants.suspiciousAccountActivity] = data;
                return this;
            }

            /// <summary>
            /// Set the totalPurchasesSixMonthCount
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> totalPurchasesSixMonthCount(int data)
            {
                this.properties[ThreeDSecureV2Constants.totalPurchasesSixMonthCount] = data;
                return this;
            }

            /// <summary>
            /// Set the transactionCountForPreviousDay
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> transactionCountForPreviousDay(int data)
            {
                this.properties[ThreeDSecureV2Constants.transactionCountForPreviousDay] = data;
                return this;
            }

            /// <summary>
            /// Set the transactionCountForPreviousYear
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>UserAccountDetailsBuilder<TBLDR></returns>
            public UserAccountDetailsBuilder<TBLDR> transactionCountForPreviousYear(int data)
            {
                this.properties[ThreeDSecureV2Constants.transactionCountForPreviousYear] = data;
                return this;
            }


            /// <summary>
            /// Build a Travel Details within this User account.
            /// </summary>
            /// <returns>TravelDetails.PriorThreeDSAuthenticationBuilder<PriorThreeDSAuthenticationBuilder<TBLDR>></returns>
            public TravelDetails.TravelDetailsBuilder<UserAccountDetailsBuilder<TBLDR>> travelDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.travelDetails))
                {
                    this.properties[ThreeDSecureV2Constants.travelDetails] = new TravelDetails.TravelDetailsBuilder<UserAccountDetailsBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureV2Constants.travelDetails] as TravelDetails.TravelDetailsBuilder<UserAccountDetailsBuilder<TBLDR>>;
            }


            /// <summary>
            /// Build a User Login within this User account.
            /// </summary>
            /// <returns>UserLogin.UserLoginBuilder<PriorThreeDSAuthenticationBuilder<TBLDR>></returns>
            public UserLogin.UserLoginBuilder<UserAccountDetailsBuilder<TBLDR>> userLogin()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.userLogin))
                {
                    this.properties[ThreeDSecureV2Constants.userLogin] = new UserLogin.UserLoginBuilder<UserAccountDetailsBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureV2Constants.userLogin] as UserLogin.UserLoginBuilder<UserAccountDetailsBuilder<TBLDR>>;
            }

        }
    }
}

