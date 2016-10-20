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

namespace Paysafe.ThreeDSecure
{
    //Created by Tushar.Sukhiya on 03.05.2016. This is EnrollmentChecks class.
    public class EnrollmentChecks: JSONObject
    {
        /// <summary>
        /// Initialize the EnrollmentLookups object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public EnrollmentChecks(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureConstants.id, STRING_TYPE},
            {ThreeDSecureConstants.merchantRefNum, STRING_TYPE},
            {ThreeDSecureConstants.amount, INT_TYPE},
            {ThreeDSecureConstants.currency,  STRING_TYPE},
            {ThreeDSecureConstants.card, typeof(Card)},
            {ThreeDSecureConstants.customerIp, STRING_TYPE},
            {ThreeDSecureConstants.userAgent, STRING_TYPE},
            {ThreeDSecureConstants.acceptHeader, STRING_TYPE},
            {ThreeDSecureConstants.merchantUrl, STRING_TYPE},
            {ThreeDSecureConstants.txnTime, typeof(DateTime)},
            {ThreeDSecureConstants.error, typeof(Error)},
            {ThreeDSecureConstants.status, ThreeDSecureConstants.enumStatus},
            {ThreeDSecureConstants.acsURL, STRING_TYPE},
            {ThreeDSecureConstants.paReq, STRING_TYPE},
            {ThreeDSecureConstants.eci, INT_TYPE},
            {ThreeDSecureConstants.threeDEnrollment, ThreeDSecureConstants.enumThreeDEnrollment},
            {ThreeDSecureConstants.links, typeof(List<Link>)}
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>String</returns>
        public string id()
        {
            return this.getProperty(ThreeDSecureConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(String data)
        {
            this.setProperty(ThreeDSecureConstants.id, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>String</returns>
        public string merchantRefNum()
        {
            return this.getProperty(ThreeDSecureConstants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <returns>void</returns>
        public void merchantRefNum(String data)
        {
            this.setProperty(ThreeDSecureConstants.merchantRefNum, data);
        }

        /// <summary>
        /// Get the amount
        /// </summary>
        /// <returns>Integer</returns>
        public int amount()
        {
            return this.getProperty(ThreeDSecureConstants.amount);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <returns>void</returns>
        public void amount(int data)
        {
            this.setProperty(ThreeDSecureConstants.amount, data);
        }

        /// <summary>
        /// Get the currency
        /// </summary>
        /// <returns>String</returns>
        public string currency()
        {
            return this.getProperty(ThreeDSecureConstants.currency);
        }

        /// <summary>
        /// Set the currency
        /// </summary>
        /// <returns>void</returns>
        public void currency(String data)
        {
            this.setProperty(ThreeDSecureConstants.currency, data);
        }

        /// <summary>
        /// Get the card
        /// </summary>
        /// <returns>Card</returns>
        public Card card()
        {
            return this.getProperty(ThreeDSecureConstants.card);
        }

        /// <summary>
        /// Set the card
        /// </summary>
        /// <returns>void</returns>
        public void card(Card data)
        {
            this.setProperty(ThreeDSecureConstants.card, data);
        }

        /// <summary>
        /// Get the customerIp
        /// </summary>
        /// <returns>String</returns>
        public string customerIp()
        {
            return this.getProperty(ThreeDSecureConstants.customerIp);
        }

        /// <summary>
        /// Set the customerIp
        /// </summary>
        /// <returns>void</returns>
        public void customerIp(String data)
        {
            this.setProperty(ThreeDSecureConstants.customerIp, data);
        }

        /// <summary>
        /// Get the userAgent
        /// </summary>
        /// <returns>String</returns>
        public string userAgent()
        {
            return this.getProperty(ThreeDSecureConstants.userAgent);
        }

        /// <summary>
        /// Set the userAgent
        /// </summary>
        /// <returns>void</returns>
        public void userAgent(String data)
        {
            this.setProperty(ThreeDSecureConstants.userAgent, data);
        }

        /// <summary>
        /// Get the acceptHeader
        /// </summary>
        /// <returns>String</returns>
        public string acceptHeader()
        {
            return this.getProperty(ThreeDSecureConstants.acceptHeader);
        }

        /// <summary>
        /// Set the acceptHeader
        /// </summary>
        /// <returns>void</returns>
        public void acceptHeader(String data)
        {
            this.setProperty(ThreeDSecureConstants.acceptHeader, data);
        }

        /// <summary>
        /// Get the merchantUrl
        /// </summary>
        /// <returns>String</returns>
        public string merchantUrl()
        {
            return this.getProperty(ThreeDSecureConstants.merchantUrl);
        }

        /// <summary>
        /// Set the merchantUrl
        /// </summary>
        /// <returns>void</returns>
        public void merchantUrl(String data)
        {
            this.setProperty(ThreeDSecureConstants.merchantUrl, data);
        }

        /// <summary>
        /// Get the txnTime
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime txnTime()
        {
            return this.getProperty(ThreeDSecureConstants.txnTime);
        }

        /// <summary>
        /// Set the txnTime
        /// </summary>
        /// <returns>void</returns>
        public void txnTime(DateTime data)
        {
            this.setProperty(ThreeDSecureConstants.txnTime, data);
        }

        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>Error</returns>
        public Error error()
        {
            return this.getProperty(ThreeDSecureConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(Error data)
        {
            this.setProperty(ThreeDSecureConstants.error, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>String</returns>
        public string status()
        {
            return this.getProperty(ThreeDSecureConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>String</returns>
        public void status(String data)
        {
            this.setProperty(ThreeDSecureConstants.status, data);
        }

        /// <summary>
        /// Get the acsURL
        /// </summary>
        /// <returns>String</returns>
        public string acsURL()
        {
            return this.getProperty(ThreeDSecureConstants.acsURL);
        }

        /// <summary>
        /// Set the acsURL
        /// </summary>
        /// <returns>String</returns>
        public void acsURL(String data)
        {
            this.setProperty(ThreeDSecureConstants.acsURL, data);
        }

        /// <summary>
        /// Get the paReq
        /// </summary>
        /// <returns>String</returns>
        public string paReq()
        {
            return this.getProperty(ThreeDSecureConstants.paReq);
        }

        /// <summary>
        /// Set the paReq
        /// </summary>
        /// <returns>String</returns>
        public void paReq(String data)
        {
            this.setProperty(ThreeDSecureConstants.paReq, data);
        }

        /// <summary>
        /// Get the eci
        /// </summary>
        /// <returns>Integer</returns>
        public int eci()
        {
            return this.getProperty(ThreeDSecureConstants.eci);
        }

        /// <summary>
        /// Set the eci
        /// </summary>
        /// <returns>void</returns>
        public void eci(int data)
        {
            this.setProperty(ThreeDSecureConstants.eci, data);
        }

        /// <summary>
        /// Get the threeDEnrollment
        /// </summary>
        /// <returns>String</returns>
        public string threeDEnrollment()
        {
            return this.getProperty(ThreeDSecureConstants.threeDEnrollment);
        }

        /// <summary>
        /// Set the threeDEnrollment
        /// </summary>
        /// <returns>String</returns>
        public void threeDEnrollment(String data)
        {
            this.setProperty(ThreeDSecureConstants.threeDEnrollment, data);
        }

        /// <summary>
        /// Get the Links
        /// </summary>
        /// <returns>Link</returns>
        public List<Link> links()
        {
            return this.getProperty(ThreeDSecureConstants.links);
        }

        /// <summary>
        /// Set the Links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(ThreeDSecureConstants.error, data);
        }

        public static EnrollmentChecksBuilder Builder()
        {
            return new EnrollmentChecksBuilder();
        }

        /// <summary>
        /// EnrollmentChecksBuilder  will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated EnrollmentLookups object
        /// </summary>
        public class EnrollmentChecksBuilder : BaseJSONBuilder<EnrollmentChecks>
        {
            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder id(string data)
            {
                this.properties[ThreeDSecureConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder merchantRefNum(string data)
            {
                this.properties[ThreeDSecureConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the amount parameter
            /// </summary>
            /// <param name=data>Integer<string></param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder amount(int data)
            {
                this.properties[ThreeDSecureConstants.amount] = data;
                return this;
            }

            /// <summary>
            /// Set the currency parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder currency(string data)
            {
                this.properties[ThreeDSecureConstants.currency] = data;
                return this;
            }

            /// <summary>
            /// Build a card within this EnrollmentLookups.
            /// </summary>
            /// <returns>Card.CardBuilder<EnrollmentLookupsBuilder></returns>
            public Card.CardBuilder<EnrollmentChecksBuilder> card()
            {
                if (!this.properties.ContainsKey(ThreeDSecureConstants.card))
                {
                    this.properties[ThreeDSecureConstants.card] = new Card.CardBuilder<EnrollmentChecksBuilder>(this);
                }
                return this.properties[ThreeDSecureConstants.card] as Card.CardBuilder<EnrollmentChecksBuilder>;
            }

            /// <summary>
            /// Set the customerIp parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder customerIp(string data)
            {
                this.properties[ThreeDSecureConstants.customerIp] = data;
                return this;
            }

            /// <summary>
            /// Set the userAgent parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder userAgent(string data)
            {
                this.properties[ThreeDSecureConstants.userAgent] = data;
                return this;
            }

            /// <summary>
            /// Set the acceptHeader parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder acceptHeader(string data)
            {
                this.properties[ThreeDSecureConstants.acceptHeader] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantUrl parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder merchantUrl(string data)
            {
                this.properties[ThreeDSecureConstants.merchantUrl] = data;
                return this;
            }

            /// <summary>
            /// Set the txnTime parameter
            /// </summary>
            /// <param name=data>DateTime</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder txnTime(DateTime data)
            {
                this.properties[ThreeDSecureConstants.txnTime] = data;
                return this;
            }

            /// <summary>
            /// Build a Error object within this EnrollmentChecksBuilder.
            /// </summary>
            /// <returns>Error.ErrorBuilder<EnrollmentLookupsBuilder></returns>
            public Error.ErrorBuilder<EnrollmentChecksBuilder> error()
            {
                if (!this.properties.ContainsKey(ThreeDSecureConstants.error))
                {
                    this.properties[ThreeDSecureConstants.error] = new Error.ErrorBuilder<EnrollmentChecksBuilder>(this);
                }
                return this.properties[ThreeDSecureConstants.error] as Error.ErrorBuilder<EnrollmentChecksBuilder>;
            }

            /// <summary>
            /// Set the status parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder status(string data)
            {
                this.properties[ThreeDSecureConstants.status] = data;
                return this;
            }

            /// <summary>
            /// Set the acsURL parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder acsURL(string data)
            {
                this.properties[ThreeDSecureConstants.acsURL] = data;
                return this;
            }

            /// <summary>
            /// Set the paReq parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder paReq(string data)
            {
                this.properties[ThreeDSecureConstants.paReq] = data;
                return this;
            }

            /// <summary>
            /// Set the eci parameter
            /// </summary>
            /// <param name=data>Integer</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder eci(int data)
            {
                this.properties[ThreeDSecureConstants.eci] = data;
                return this;
            }

            /// <summary>
            /// Set the threeDEnrollment parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EnrollmentChecksBuilder</returns>
            public EnrollmentChecksBuilder threeDEnrollment(string data)
            {
                this.properties[ThreeDSecureConstants.threeDEnrollment] = data;
                return this;
            }
        }
    }
}
