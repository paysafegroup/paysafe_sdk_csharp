/*
 * Copyright (c) 2014 Optimal Payments
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
 * associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
 * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.CardPayments
{
    public class Authorization : JSONObject
    {

        /// <summary>
        /// Gets the array key to access the array of authorizations
        /// </summary>
        /// <returns>The key to be checked in the returning JSON</returns>
        public static string getPageableArrayKey()
        {
            return "auths";
        }

        /// <summary>
        /// Initialize the Authorization object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Authorization(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        /// <summary>
        /// Initialize an authorization object with an id
        /// </summary>
        /// <param name="id"></param>
        public Authorization(String id)
            : base(fieldTypes)
        {
            this.id(id);
        }

        /// <summary>
        /// This object is used to validate any properties set within the object
        /// </summary>
        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CardPaymentsConstants.id, STRING_TYPE},
            {CardPaymentsConstants.merchantRefNum, STRING_TYPE},
            {CardPaymentsConstants.amount, INT_TYPE},
            {CardPaymentsConstants.settleWithAuth, BOOL_TYPE},
            {CardPaymentsConstants.availableToSettle, INT_TYPE},
            {CardPaymentsConstants.childAccountNum, STRING_TYPE},
            {CardPaymentsConstants.card, typeof(Card)},
            {CardPaymentsConstants.authentication, typeof(PaysafeAuthentication)},
            {CardPaymentsConstants.authCode, STRING_TYPE},
            {CardPaymentsConstants.profile, typeof(Profile)},
            {CardPaymentsConstants.billingDetails, typeof(BillingDetails)},
            {CardPaymentsConstants.airlineTravelDetails, typeof(AirlineTravelDetails) },
            {CardPaymentsConstants.shippingDetails, typeof(ShippingDetails)},
            {CardPaymentsConstants.recurring, CardPaymentsConstants.enumRecurring},
            {CardPaymentsConstants.customerIp, STRING_TYPE},
            {CardPaymentsConstants.dupCheck, BOOL_TYPE},
            {CardPaymentsConstants.keywords, typeof(List<string>)},
            {CardPaymentsConstants.merchantDescriptor, typeof(MerchantDescriptor)},
            {CardPaymentsConstants.accordD, typeof(AccordD)},
            {CardPaymentsConstants.description, STRING_TYPE},
            {CardPaymentsConstants.masterPass, typeof(MasterPass)},
            {CardPaymentsConstants.txnTime, typeof(System.DateTime)},
            {CardPaymentsConstants.currencyCode, STRING_TYPE},
            {CardPaymentsConstants.avsResponse, CardPaymentsConstants.enumAVSResponse},
            {CardPaymentsConstants.cvvVerification, CardPaymentsConstants.enumCVVVerification},
            {CardPaymentsConstants.status, CardPaymentsConstants.enumStatus},
            {CardPaymentsConstants.riskReasonCode, typeof(List<int>)},
            {CardPaymentsConstants.acquirerResponse, typeof(AcquirerResponse)},
            {CardPaymentsConstants.visaAdditionalAuthData, typeof(VisaAdditionalAuthData)},
            {CardPaymentsConstants.storedCredential, typeof(StoredCredential)},
            {CardPaymentsConstants.settlements, typeof(List<Settlement>)},
            {CardPaymentsConstants.error, typeof(OptError)},
            {CardPaymentsConstants.links, typeof(List<Link>)}
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(CardPaymentsConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <turns>void</returns>
        public void id(string data)
        {
            this.setProperty(CardPaymentsConstants.id, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>string</returns>
        public string merchantRefNum()
        {
            return this.getProperty(CardPaymentsConstants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <returns>void</returns>
        public void merchantRefNum(string data)
        {
            this.setProperty(CardPaymentsConstants.merchantRefNum, data);
        }

        /// <summary>
        /// Get the amount
        /// </summary>
        /// <returns>int</returns>
        public int amount()
        {
            return this.getProperty(CardPaymentsConstants.amount);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <returns>void</returns>
        public void amount(int data)
        {
            this.setProperty(CardPaymentsConstants.amount, data);
        }

        /// <summary>
        /// Get the settleWithAuth
        /// </summary>
        /// <returns>bool</returns>
        public bool settleWithAuth()
        {
            return this.getProperty(CardPaymentsConstants.settleWithAuth);
        }

        /// <summary>
        /// Set the settleWithAuth
        /// </summary>
        /// <returns>void</returns>
        public void settleWithAuth(bool data)
        {
            this.setProperty(CardPaymentsConstants.settleWithAuth, data);
        }

        /// <summary>
        /// Get the availableToSettle
        /// </summary>
        /// <returns>int</returns>
        public int availableToSettle()
        {
            return this.getProperty(CardPaymentsConstants.availableToSettle);
        }

        /// <summary>
        /// Set the availableToSettle
        /// </summary>
        /// <returns>void</returns>
        public void availableToSettle(int data)
        {
            this.setProperty(CardPaymentsConstants.availableToSettle, data);
        }

        /// <summary>
        /// Get the childAccountNum
        /// </summary>
        /// <returns>string</returns>
        public string childAccountNum()
        {
            return this.getProperty(CardPaymentsConstants.childAccountNum);
        }

        /// <summary>
        /// Set the childAccountNum
        /// </summary>
        /// <returns>void</returns>
        public void childAccountNum(string data)
        {
            this.setProperty(CardPaymentsConstants.childAccountNum, data);
        }

        /// <summary>
        /// Get the card
        /// </summary>
        /// <returns>Card</returns>
        public Card card()
        {
            return this.getProperty(CardPaymentsConstants.card);
        }

        /// <summary>
        /// Set the card
        /// </summary>
        /// <returns>void</returns>
        public void card(Card data)
        {
            this.setProperty(CardPaymentsConstants.card, data);
        }

        /// <summary>
        /// Get the authentication
        /// </summary>
        /// <returns>Authentication</returns>
        public PaysafeAuthentication authentication()
        {
            return this.getProperty(CardPaymentsConstants.authentication);
        }

        /// <summary>
        /// Set the authentication
        /// </summary>
        /// <returns>void</returns>
        public void authentication(PaysafeAuthentication data)
        {
            this.setProperty(CardPaymentsConstants.authentication, data);
        }

        /// <summary>
        /// Get the authCode
        /// </summary>
        /// <returns>string</returns>
        public string authCode()
        {
            return this.getProperty(CardPaymentsConstants.authCode);
        }

        /// <summary>
        /// Set the authCode
        /// </summary>
        /// <returns>void</returns>
        public void authCode(string data)
        {
            this.setProperty(CardPaymentsConstants.authCode, data);
        }

        /// <summary>
        /// Get the profile
        /// </summary>
        /// <returns>Profile</returns>
        public Profile profile()
        {
            return this.getProperty(CardPaymentsConstants.profile);

        }

        /// <summary>
        /// Set the profile
        /// </summary>
        /// <returns>void</returns>
        public void profile(Profile data)
        {
            this.setProperty(CardPaymentsConstants.profile, data);
        }

        /// <summary>
        /// Get the billing details
        /// </summary>
        /// <returns>BillingDetails</returns>
        public BillingDetails billingDetails()
        {
            return this.getProperty(CardPaymentsConstants.billingDetails);
        }

        /// <summary>
        /// Set the billingDetails
        /// </summary>
        /// <returns>void</returns>
        public void billingDetails(BillingDetails data)
        {
            this.setProperty(CardPaymentsConstants.billingDetails, data);
        }

        /// <summary>
        /// Get the airline travel details
        /// </summary>
        /// <returns>AirlineTravelDetails</returns>
        public AirlineTravelDetails airlineTravelDetails()
        {
            return getProperty(GlobalConstants.airlineTravelDetails);
        }

        /// <summary>
        /// Set the airline travel details
        /// </summary>
        /// <returns>void</returns>
        public void airlineTravelDetails(AirlineTravelDetails data)
        {
            setProperty(GlobalConstants.airlineTravelDetails, data);
        }

        /// <summary>
        /// Get the shipping details
        /// </summary>
        /// <returns>ShippingDetails</returns>
        public ShippingDetails shippingDetails()
        {
            return this.getProperty(CardPaymentsConstants.shippingDetails);
        }

        /// <summary>
        /// Set the shippingDetails
        /// </summary>
        /// <returns>void</returns>
        public void shippingDetails(ShippingDetails data)
        {
            this.setProperty(CardPaymentsConstants.shippingDetails, data);
        }
        
        /// <summary>
        /// Get the StoredCredential
        /// </summary>
        /// <returns>StoredCredential</returns>
        public StoredCredential storedCredential()
        {
            return this.getProperty(CardPaymentsConstants.storedCredential);

        }

        /// <summary>
        /// Set the StoredCredential
        /// </summary>
        /// <returns>void</returns>
        public void storedCredential(StoredCredential data)
        {
            this.setProperty(CardPaymentsConstants.storedCredential, data);
        }

        /// <summary>
        /// Get the recurring
        /// </summary>
        /// <returns>string</returns>
        public string recurring()
        {
            return this.getProperty(CardPaymentsConstants.recurring);
        }

        /// <summary>
        /// Set the recurring
        /// </summary>
        /// <returns>void</returns>
        public void recurring(string data)
        {
            this.setProperty(CardPaymentsConstants.recurring, data);
        }

        /// <summary>
        /// Get the customerIp
        /// </summary>
        /// <returns>string</returns>
        public string customerIp()
        {
            return this.getProperty(CardPaymentsConstants.customerIp);
        }

        /// <summary>
        /// Set the customerIp
        /// </summary>
        /// <returns>void</returns>
        public void customerIp(string data)
        {
            this.setProperty(CardPaymentsConstants.customerIp, data);
        }

        /// <summary>
        /// Get the dupCheck
        /// </summary>
        /// <returns>bool</returns>
        public bool dupCheck()
        {
            return this.getProperty(CardPaymentsConstants.dupCheck);
        }

        /// <summary>
        /// Set the dupCheck
        /// </summary>
        /// <returns>void</returns>
        public void dupCheck(bool data)
        {
            this.setProperty(CardPaymentsConstants.dupCheck, data);
        }

        /// <summary>
        /// Get the keywords
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> keywords()
        {
            return this.getProperty(CardPaymentsConstants.keywords);
        }

        /// <summary>
        /// Set the keywords
        /// </summary>
        /// <returns>void</returns>
        public void keywords(List<string> data)
        {
            this.setProperty(CardPaymentsConstants.keywords, data);
        }

        /// <summary>
        /// Get the merchantDescriptor
        /// </summary>
        /// <returns>MerchantDescriptor</returns>
        public MerchantDescriptor merchantDescriptor()
        {
            return this.getProperty(CardPaymentsConstants.merchantDescriptor);
        }

        /// <summary>
        /// Set the merchantDescriptor
        /// </summary>
        /// <returns>void</returns>
        public void merchantDescriptor(MerchantDescriptor data)
        {
            this.setProperty(CardPaymentsConstants.merchantDescriptor, data);
        }

        /// <summary>
        /// Get the accordD
        /// </summary>
        /// <returns>AccordD</returns>
        public AccordD accordD()
        {
            return this.getProperty(CardPaymentsConstants.accordD);
        }

        /// <summary>
        /// Set the accordD
        /// </summary>
        /// <returns>void</returns>
        public void accordD(AccordD data)
        {
            this.setProperty(CardPaymentsConstants.accordD, data);
        }

        /// <summary>
        /// Get the description
        /// </summary>
        /// <returns>string</returns>
        public string description()
        {
            return this.getProperty(CardPaymentsConstants.description);
        }

        /// <summary>
        /// Set the description
        /// </summary>
        /// <returns>void</returns>
        public void description(string data)
        {
            this.setProperty(CardPaymentsConstants.description, data);
        }

        /// <summary>
        /// Get the masterPass
        /// </summary>
        /// <returns>MasterPass</returns>
        public MasterPass masterPass()
        {
            return this.getProperty(CardPaymentsConstants.masterPass);
        }

        /// <summary>
        /// Set the masterPass
        /// </summary>
        /// <returns>void</returns>
        public void masterPass(MasterPass data)
        {
            this.setProperty(CardPaymentsConstants.masterPass, data);
        }

        /// <summary>
        /// Get the txnTime
        /// </summary>
        /// <returns>System.DateTime</returns>
        public System.DateTime txnTime()
        {
            return this.getProperty(CardPaymentsConstants.txnTime);
        }

        /// <summary>
        /// Set the txnTime
        /// </summary>
        /// <returns>void</returns>
        public void txnTime(System.DateTime data)
        {
            this.setProperty(CardPaymentsConstants.txnTime, data);
        }

        /// <summary>
        /// Get the currencyCode
        /// </summary>
        /// <returns>string</returns>
        public string currencyCode()
        {
            return this.getProperty(CardPaymentsConstants.currencyCode);
        }

        /// <summary>
        /// Set the currencyCode
        /// </summary>
        /// <returns>void</returns>
        public void currencyCode(string data)
        {
            this.setProperty(CardPaymentsConstants.currencyCode, data);
        }

        /// <summary>
        /// Get the avsResponse
        /// </summary>
        /// <returns>string</returns>
        public string avsResponse()
        {
            return this.getProperty(CardPaymentsConstants.avsResponse);
        }

        /// <summary>
        /// Set the avsResponse
        /// </summary>
        /// <returns>void</returns>
        public void avsResponse(string data)
        {
            this.setProperty(CardPaymentsConstants.avsResponse, data);
        }

        /// <summary>
        /// Get the cvvVerification
        /// </summary>
        /// <returns>string</returns>
        public string cvvVerification()
        {
            return this.getProperty(CardPaymentsConstants.cvvVerification);
        }

        /// <summary>
        /// Set the cvvVerification
        /// </summary>
        /// <returns>void</returns>
        public void cvvVerification(string data)
        {
            this.setProperty(CardPaymentsConstants.cvvVerification, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>string</returns>
        public string status()
        {
            return this.getProperty(CardPaymentsConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(string data)
        {
            this.setProperty(CardPaymentsConstants.status, data);
        }

        /// <summary>
        /// Get the riskReasonCode
        /// </summary>
        /// <returns>List<int></returns>
        public List<int> riskReasonCode()
        {
            return this.getProperty(CardPaymentsConstants.riskReasonCode);
        }

        /// <summary>
        /// Set the riskReasonCode
        /// </summary>
        /// <returns>void</returns>
        public void riskReasonCode(List<int> data)
        {
            this.setProperty(CardPaymentsConstants.riskReasonCode, data);
        }

        /// <summary>
        /// Get the acquireResponse
        /// </summary>
        /// <returns>AcquirerResponse</returns>
        public AcquirerResponse acquireResponse()
        {
            return this.getProperty(CardPaymentsConstants.acquirerResponse);
        }

        /// <summary>
        /// Set the acquireResponse
        /// </summary>
        /// <returns>void</returns>
        public void acquireResponse(AcquirerResponse data)
        {
            this.setProperty(CardPaymentsConstants.acquirerResponse, data);
        }

        /// <summary>
        /// Get the visaAdditionalAuthData
        /// </summary>
        /// <returns>VisaAdditionalAuthData</returns>
        public VisaAdditionalAuthData visaAdditionalAuthData()
        {
            return this.getProperty(CardPaymentsConstants.visaAdditionalAuthData);
        }

        /// <summary>
        /// Set the visaAdditionalAuthData
        /// </summary>
        /// <returns>void</returns>
        public void visaAdditionalAuthData(VisaAdditionalAuthData data)
        {
            this.setProperty(CardPaymentsConstants.visaAdditionalAuthData, data);
        }

        /// <summary>
        /// Get the settlements
        /// </summary>
        /// <returns>List<Settlement></returns>
        public List<Settlement> settlements()
        {
            return this.getProperty(CardPaymentsConstants.settlements);
        }

        /// <summary>
        /// Set the settlements
        /// </summary>
        /// <returns>void</returns>
        public void settlements(List<Settlement> data)
        {
            this.setProperty(CardPaymentsConstants.settlements, data);
        }

        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>Error</returns>
        public OptError error()
        {
            return this.getProperty(CardPaymentsConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(CardPaymentsConstants.error, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>List<Link></returns>
        public List<Link> links()
        {
            return this.getProperty(CardPaymentsConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(CardPaymentsConstants.links, data);
        }

        /// <summary>
        /// Get a new AuthorizationBuilder
        /// </summary>
        /// <returns>AuthorizationBuilder</returns>
        public static AuthorizationBuilder Builder()
        {
            return new AuthorizationBuilder();
        }

        /// <summary>
        /// AuthorizationBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Authorization object
        /// </summary>
        public class AuthorizationBuilder : BaseJSONBuilder<Authorization>
        {
            /// <summary>
            /// Set the id
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder id(string data)
            {
                this.properties[CardPaymentsConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder merchantRefNum(string data)
            {
                this.properties[CardPaymentsConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the amount parameter
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder amount(int data)
            {
                this.properties[CardPaymentsConstants.amount] = data;
                return this;
            }
            
            /// <summary>
            /// Build a card within this authorization.
            /// </summary>
            /// <returns>Card.CardBuilder<AuthorizationBuilder></returns>
            public Card.CardBuilder<AuthorizationBuilder> card()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.card))
                {
                    this.properties[CardPaymentsConstants.card] = new Card.CardBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.card] as Card.CardBuilder<AuthorizationBuilder>;
            }

            /// <summary>
            /// Set the settleWithAuth property
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder settleWithAuth(bool data)
            {
                this.properties[CardPaymentsConstants.settleWithAuth] = data;
                return this;
            }

            /// <summary>
            /// Set the customerIp parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder customerIp(string data)
            {
                this.properties[CardPaymentsConstants.customerIp] = data;
                return this;
            }

            /// <summary>
            /// Set the dupCheck parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder dupCheck(bool data)
            {
                this.properties[CardPaymentsConstants.dupCheck] = data;
                return this;
            }

            /// <summary>
            /// Set the description
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder description(string data)
            {
                this.properties[CardPaymentsConstants.description] = data;
                return this;
            }

            /// <summary>
            /// Build a authentication within this authorization.
            /// </summary>
            /// <returns>PaysafeAuthentication.AuthenticationBuilder<AuthorizationBuilder></returns>
            public PaysafeAuthentication.AuthenticationBuilder<AuthorizationBuilder> authentication()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.authentication))
                {
                    this.properties[CardPaymentsConstants.authentication] = new PaysafeAuthentication.AuthenticationBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.authentication] as PaysafeAuthentication.AuthenticationBuilder<AuthorizationBuilder>;
            }

            /// <summary>
            /// Build a billing details object within this authorization.
            /// </summary>
            /// <returns>BillingDetails.BillingDetailsBuilder<AuthorizationBuilder></returns>
            public BillingDetails.BillingDetailsBuilder<AuthorizationBuilder> billingDetails()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.billingDetails))
                {
                    this.properties[CardPaymentsConstants.billingDetails] = new BillingDetails.BillingDetailsBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.billingDetails] as BillingDetails.BillingDetailsBuilder<AuthorizationBuilder>;
            }

            /// <summary>
            /// Build a shipping details object within this authorization.
            /// </summary>
            /// <returns>ShippingDetails.ShippingDetailsBuilder<AuthorizationBuilder></returns>
            public ShippingDetails.ShippingDetailsBuilder<AuthorizationBuilder> shippingDetails()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.shippingDetails))
                {
                    this.properties[CardPaymentsConstants.shippingDetails] = new ShippingDetails.ShippingDetailsBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.shippingDetails] as ShippingDetails.ShippingDetailsBuilder<AuthorizationBuilder>;
            }
            
            /// <summary>
            /// Build a profile object within this authorization.
            /// </summary>
            /// <returns>Profile.ProfileBuilder<AuthorizationBuilder></returns>
            public Profile.ProfileBuilder<AuthorizationBuilder> profile()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.profile))
                {
                    this.properties[CardPaymentsConstants.profile] = new Profile.ProfileBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.profile] as Profile.ProfileBuilder<AuthorizationBuilder>;
            }

            /// <summary>
            /// Set the recurring parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthorizationBuilder</returns>
            public AuthorizationBuilder recurring(string data)
            {
                this.properties[CardPaymentsConstants.recurring] = data;
                return this;

            }

            /// <summary>
            /// Build a merchant descriptor object within this authorization.
            /// </summary>
            /// <returns>MerchantDescriptor.MerchantDescriptorBuilder<AuthorizationBuilder></returns>
            public MerchantDescriptor.MerchantDescriptorBuilder<AuthorizationBuilder> merchantDescriptor()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.merchantDescriptor))
                {
                    this.properties[CardPaymentsConstants.merchantDescriptor] = new MerchantDescriptor.MerchantDescriptorBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.merchantDescriptor] as MerchantDescriptor.MerchantDescriptorBuilder<AuthorizationBuilder>;
            }

            /// <summary>
            /// Build an accordD object within this authorization.
            /// </summary>
            /// <returns>AccordD.AccordDBuilder<AuthorizationBuilder></returns>
            public AccordD.AccordDBuilder<AuthorizationBuilder> accordD()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.accordD))
                {
                    this.properties[CardPaymentsConstants.accordD] = new AccordD.AccordDBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.accordD] as AccordD.AccordDBuilder<AuthorizationBuilder>;
            }
            
            /// <summary>
            /// Build an StoredCredential object within this authorization.
            /// </summary>
            /// <returns>StoredCredential.StoredCredentialBuilder<AuthorizationBuilder></returns>
            public StoredCredential.StoredCredentialBuilder<AuthorizationBuilder> storedCredential()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.storedCredential))
                {
                    this.properties[CardPaymentsConstants.storedCredential] = new StoredCredential.StoredCredentialBuilder<AuthorizationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.storedCredential] as StoredCredential.StoredCredentialBuilder<AuthorizationBuilder>;
            }

            /// <summary>
            /// Build an AirlineTravelDetails object within this authorization.
            /// </summary>
            /// <returns>AirlineTravelDetails.AirlineTravelDetailsBuilder<AuthorizationBuilder></returns>
            public AirlineTravelDetails.AirlineTravelDetailsBuilder<AuthorizationBuilder> airlineTravelDetails()
            {
                if (!properties.ContainsKey(GlobalConstants.airlineTravelDetails))
                {
                    properties[GlobalConstants.airlineTravelDetails] = new AirlineTravelDetails.AirlineTravelDetailsBuilder<AuthorizationBuilder>(this);
                }
                return properties[GlobalConstants.airlineTravelDetails] as AirlineTravelDetails.AirlineTravelDetailsBuilder<AuthorizationBuilder>;
            }
        }
    }
}
