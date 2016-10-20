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

using Paysafe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paysafe.ThreeDSecure
{
    //Created by Tushar.Sukhiya on 03.05.2016. This is Authentications class.
    public class Authentications : JSONObject
    {
        /// <summary>
        /// Initialize the Authentications object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Authentications(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureConstants.id, STRING_TYPE},
            {ThreeDSecureConstants.merchantRefNum, STRING_TYPE},
            {ThreeDSecureConstants.paResp, STRING_TYPE},
            {ThreeDSecureConstants.customerIp, STRING_TYPE},
            {ThreeDSecureConstants.txnTime, typeof(DateTime)},
            {ThreeDSecureConstants.error, typeof(Error)},
            {ThreeDSecureConstants.status, ThreeDSecureConstants.enumStatus},
            {ThreeDSecureConstants.threeDResult, ThreeDSecureConstants.enumThreeDResult},
            {ThreeDSecureConstants.signatureStatus, ThreeDSecureConstants.enumSignatureStatus},
            {ThreeDSecureConstants.eci, INT_TYPE},
            {ThreeDSecureConstants.cavv, STRING_TYPE},
            {ThreeDSecureConstants.xid, STRING_TYPE},
            {ThreeDSecureConstants.enrollmentId, STRING_TYPE},
            {ThreeDSecureConstants.links, typeof(List<Link>)},
            {ThreeDSecureConstants.enrollmentchecks, typeof(List<EnrollmentChecks>)}
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
        /// Get the paRes
        /// </summary>
        /// <returns>String</returns>
        public string paRes()
        {
            return this.getProperty(ThreeDSecureConstants.paResp);
        }

        /// <summary>
        /// Set the paRes
        /// </summary>
        /// <returns>void</returns>
        public void paRes(String data)
        {
            this.setProperty(ThreeDSecureConstants.paResp, data);
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
        /// Get the threeDResult
        /// </summary>
        /// <returns>String</returns>
        public string threeDResult()
        {
            return this.getProperty(ThreeDSecureConstants.threeDResult);
        }

        /// <summary>
        /// Set the threeDResult
        /// </summary>
        /// <returns>String</returns>
        public void threeDResult(String data)
        {
            this.setProperty(ThreeDSecureConstants.threeDResult, data);
        }

        /// <summary>
        /// Get the signatureStatus
        /// </summary>
        /// <returns>String</returns>
        public string signatureStatus()
        {
            return this.getProperty(ThreeDSecureConstants.signatureStatus);
        }

        /// <summary>
        /// Set the signatureStatus
        /// </summary>
        /// <returns>String</returns>
        public void signatureStatus(String data)
        {
            this.setProperty(ThreeDSecureConstants.signatureStatus, data);
        }
        
        /// <summary>
        /// Get the eci
        /// </summary>
        /// <returns>integer</returns>
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
        /// Get the cavv
        /// </summary>
        /// <returns>String</returns>
        public string cavv()
        {
            return this.getProperty(ThreeDSecureConstants.cavv);
        }

        /// <summary>
        /// Set the cavv
        /// </summary>
        /// <returns>void</returns>
        public void cavv(String data)
        {
            this.setProperty(ThreeDSecureConstants.cavv, data);
        }

        /// <summary>
        /// Get the xid
        /// </summary>
        /// <returns>String</returns>
        public string xid()
        {
            return this.getProperty(ThreeDSecureConstants.xid);
        }

        /// <summary>
        /// Set the xid
        /// </summary>
        /// <returns>void</returns>
        public void xid(String data)
        {
            this.setProperty(ThreeDSecureConstants.xid, data);
        }

        public static AuthenticationsBuilder Builder()
        {
            return new AuthenticationsBuilder();
        }

        /// <summary>
        /// Get the enrollmentId
        /// </summary>
        /// <returns>String</returns>
        public string enrollmentId()
        {
            return this.getProperty(ThreeDSecureConstants.enrollmentId);
        }

        /// <summary>
        /// Set the enrollmentId
        /// </summary>
        /// <returns>void</returns>
        public void enrollmentId(String data)
        {
            this.setProperty(ThreeDSecureConstants.enrollmentId, data);
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
            this.setProperty(ThreeDSecureConstants.links, data);
        }

        /// <summary>
        /// Get the enrollmentchecks
        /// </summary>
        /// <returns>EnrollmentChecks</returns>
        public List<EnrollmentChecks> enrollmentchecks()
        {
            return this.getProperty(ThreeDSecureConstants.enrollmentchecks);
        }

        /// <summary>
        /// Set the enrollmentchecks
        /// </summary>
        /// <returns>void</returns>
        public void enrollmentchecks(List<EnrollmentChecks> data)
        {
            this.setProperty(ThreeDSecureConstants.enrollmentchecks, data);
        }

        /// <summary>
        /// AuthenticationsBuilder  will allow an authentication to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Authentications object
        /// </summary>
        public class AuthenticationsBuilder : BaseJSONBuilder<Authentications>
        {
            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder id(string data)
            {
                this.properties[ThreeDSecureConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder merchantRefNum(string data)
            {
                this.properties[ThreeDSecureConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the paResp parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder paResp(string data)
            {
                this.properties[ThreeDSecureConstants.paResp] = data;
                return this;
            }

            /// <summary>
            /// Set the customerIp parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder customerIp(string data)
            {
                this.properties[ThreeDSecureConstants.customerIp] = data;
                return this;
            }

            /// <summary>
            /// Set the txnTime parameter
            /// </summary>
            /// <param name=data>DateTime</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder txnTime(DateTime data)
            {
                this.properties[ThreeDSecureConstants.txnTime] = data;
                return this;
            }

            /// <summary>
            /// Build a Error object within this Authentications.
            /// </summary>
            /// <returns>Error.ErrorBuilder<AuthenticationsBuilder></returns>
            public Error.ErrorBuilder<AuthenticationsBuilder> error()
            {
                if (!this.properties.ContainsKey(ThreeDSecureConstants.error))
                {
                    this.properties[ThreeDSecureConstants.error] = new Error.ErrorBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureConstants.error] as Error.ErrorBuilder<AuthenticationsBuilder>;
            }

            /// <summary>
            /// Set the status parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder status(string data)
            {
                this.properties[ThreeDSecureConstants.status] = data;
                return this;
            }

            /// <summary>
            /// Set the threeDResult parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder threeDResult(string data)
            {
                this.properties[ThreeDSecureConstants.threeDResult] = data;
                return this;
            }

            /// <summary>
            /// Set the signatureStatus parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder signatureStatus(string data)
            {
                this.properties[ThreeDSecureConstants.signatureStatus] = data;
                return this;
            }

            /// <summary>
            /// Set the eci parameter
            /// </summary>
            /// <param name=data>Integer</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder eci(int data)
            {
                this.properties[ThreeDSecureConstants.eci] = data;
                return this;
            }

            /// <summary>
            /// Set the cavv parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder cavv(string data)
            {
                this.properties[ThreeDSecureConstants.cavv] = data;
                return this;
            }

            /// <summary>
            /// Set the xid parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder xid(string data)
            {
                this.properties[ThreeDSecureConstants.xid] = data;
                return this;
            }

            /// <summary>
            /// Set the enrollmentId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder enrollmentId(string data)
            {
                this.properties[ThreeDSecureConstants.enrollmentId] = data;
                return this;
            }
        }
    }
}
