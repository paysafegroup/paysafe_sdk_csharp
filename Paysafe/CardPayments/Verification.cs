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
    public class Verification : JSONObject
    {
        /// <summary>
        /// Initialize the Verification object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Verification(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        /// <summary>
        /// Initialize a verification object with an id
        /// </summary>
        /// <param name="id"></param>
        public Verification(String id)
            : base(fieldTypes)
        {
            this.id(id);
        }

        /// <summary>
        /// Gets the array key to access the array of verifications
        /// </summary>
        /// <returns>The key to be checked in the returning JSON</returns>
        public static string getPageableArrayKey()
        {
            return "verifications";
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CardPaymentsConstants.id, STRING_TYPE},
            {CardPaymentsConstants.merchantRefNum, STRING_TYPE},
            {CardPaymentsConstants.childAccountNum, STRING_TYPE},
            {CardPaymentsConstants.card, typeof(Card)},
            {CardPaymentsConstants.authCode, STRING_TYPE},
            {CardPaymentsConstants.profile, typeof(Profile)},
            {CardPaymentsConstants.billingDetails, typeof(BillingDetails)},
            {CardPaymentsConstants.customerIp, STRING_TYPE},
            {CardPaymentsConstants.dupCheck, BOOL_TYPE},
            {CardPaymentsConstants.merchantDescriptor, typeof(MerchantDescriptor)},
            {CardPaymentsConstants.description, STRING_TYPE},
            {CardPaymentsConstants.txnTime, typeof(System.DateTime)},
            {CardPaymentsConstants.currencyCode, STRING_TYPE},
            {CardPaymentsConstants.avsResponse, CardPaymentsConstants.enumAVSResponse},
            {CardPaymentsConstants.cvvVerification, CardPaymentsConstants.enumCVVVerification},
            {CardPaymentsConstants.status, CardPaymentsConstants.enumStatus},
            {CardPaymentsConstants.riskReasonCode, typeof(List<int>)},
            {CardPaymentsConstants.acquirerResponse, typeof(AcquirerResponse)},
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
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
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
        /// Get a new VerificationBuilder
        /// </summary>
        /// <returns>VerificationBuilder</returns>
        public static VerificationBuilder Builder()
        {
            return new VerificationBuilder();
        }

        /// <summary>
        /// VerificationBuilder will allow an Verification to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Verification object
        /// </summary>
        public class VerificationBuilder : BaseJSONBuilder<Verification>
        {
            /// <summary>
            /// Set the id
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>VerificationBuilder</returns>
            public VerificationBuilder id(string data)
            {
                this.properties[CardPaymentsConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>VerificationBuilder</returns>
            public VerificationBuilder merchantRefNum(string data)
            {
                this.properties[CardPaymentsConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Build a card object within this Verification.
            /// </summary>
            /// <returns>Profile.profileBuilder<VerificationBuilder></returns>
            public Card.CardBuilder<VerificationBuilder> card()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.card))
                {
                    this.properties[CardPaymentsConstants.card] = new Card.CardBuilder<VerificationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.card] as Card.CardBuilder<VerificationBuilder>;
            }

            /// <summary>
            /// Set the dupCheck
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>VerificationBuilder</returns>
            public VerificationBuilder dupCheck(bool data)
            {
                this.properties[CardPaymentsConstants.dupCheck] = data;
                return this;
            }

            /// <summary>
            /// Build a profile object within this Verification.
            /// </summary>
            /// <returns>Profile.profileBuilder<VerificationBuilder></returns>
            public Profile.ProfileBuilder<VerificationBuilder> profile()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.profile))
                {
                    this.properties[CardPaymentsConstants.profile] = new Profile.ProfileBuilder<VerificationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.profile] as Profile.ProfileBuilder<VerificationBuilder>;
            }

            /// <summary>
            /// Build a billing details object within this Verification.
            /// </summary>
            /// <returns>BillingDetails.BillingDetailsBuilder<VerificationBuilder></returns>
            public BillingDetails.BillingDetailsBuilder<VerificationBuilder> billingDetails()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.billingDetails))
                {
                    this.properties[CardPaymentsConstants.billingDetails] = new BillingDetails.BillingDetailsBuilder<VerificationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.billingDetails] as BillingDetails.BillingDetailsBuilder<VerificationBuilder>;
            }

            /// <summary>
            /// Set the customerIp
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>VerificationBuilder</returns>
            public VerificationBuilder customerIp(string data)
            {
                this.properties[CardPaymentsConstants.customerIp] = data;
                return this;
            }

            /// <summary>
            /// Build a merchant descriptor object within this Verification.
            /// </summary>
            /// <returns>MerchantDescriptor.MerchantDescriptorBuilder<VerificationBuilder></returns>
            public MerchantDescriptor.MerchantDescriptorBuilder<VerificationBuilder> merchantDescriptor()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.merchantDescriptor))
                {
                    this.properties[CardPaymentsConstants.merchantDescriptor] = new MerchantDescriptor.MerchantDescriptorBuilder<VerificationBuilder>(this);
                }
                return this.properties[CardPaymentsConstants.merchantDescriptor] as MerchantDescriptor.MerchantDescriptorBuilder<VerificationBuilder>;
            }

            /// <summary>
            /// Set the description
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>VerificationBuilder</returns>
            public VerificationBuilder description(string data)
            {
                this.properties[CardPaymentsConstants.description] = data;
                return this;
            }

        }
    }
}
