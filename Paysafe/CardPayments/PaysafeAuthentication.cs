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
    public class PaysafeAuthentication : JSONObject
    {

        /// <summary>
        /// Initialize the BillingDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public PaysafeAuthentication(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CardPaymentsConstants.eci, INT_TYPE},
            {CardPaymentsConstants.cavv, STRING_TYPE},
            {CardPaymentsConstants.xid, STRING_TYPE},
            {CardPaymentsConstants.threeDEnrollment, STRING_TYPE},
            {CardPaymentsConstants.threeDResult, STRING_TYPE},
            {CardPaymentsConstants.signatureStatus, STRING_TYPE}
        };

        /// <summary>
        /// Get the eci
        /// </summary>
        /// <returns>int</returns>
        public int eci()
        {
            return this.getProperty(CardPaymentsConstants.eci);
        }

        /// <summary>
        /// Set the eci
        /// </summary>
        /// <returns>void</returns>
        public void eci(int data)
        {
            this.setProperty(CardPaymentsConstants.eci, data);
        }

        /// <summary>
        /// Get the cavv
        /// </summary>
        /// <returns>string</returns>
        public string cavv()
        {
            return this.getProperty(CardPaymentsConstants.cavv);
        }

        /// <summary>
        /// Set the cavv
        /// </summary>
        /// <returns>void</returns>
        public void cavv(string data)
        {
            this.setProperty(CardPaymentsConstants.cavv, data);
        }

        /// <summary>
        /// Get the xid
        /// </summary>
        /// <returns>string</returns>
        public string xid()
        {
            return this.getProperty(CardPaymentsConstants.xid);
        }

        /// <summary>
        /// Set the xid
        /// </summary>
        /// <returns>void</returns>
        public void xid(string data)
        {
            this.setProperty(CardPaymentsConstants.xid, data);
        }

        /// <summary>
        /// Get the threeDEnrollment
        /// </summary>
        /// <returns>string</returns>
        public string threeDEnrollment()
        {
            return this.getProperty(CardPaymentsConstants.threeDEnrollment);
        }

        /// <summary>
        /// Set the threeDEnrollment
        /// </summary>
        /// <returns>void</returns>
        public void threeDEnrollment(string data)
        {
            this.setProperty(CardPaymentsConstants.threeDEnrollment, data);
        }

        /// <summary>
        /// Get the threeDResult
        /// </summary>
        /// <returns>string</returns>
        public string threeDResult()
        {
            return this.getProperty(CardPaymentsConstants.threeDResult);
        }

        /// <summary>
        /// Set the threeDResult
        /// </summary>
        /// <returns>void</returns>
        public void threeDResult(string data)
        {
            this.setProperty(CardPaymentsConstants.threeDResult, data);
        }

        /// <summary>
        /// Get the signatureStatus
        /// </summary>
        /// <returns>string</returns>
        public string signatureStatus()
        {
            return this.getProperty(CardPaymentsConstants.signatureStatus);
        }

        /// <summary>
        /// Set the signatureStatus
        /// </summary>
        /// <returns>void</returns>
        public void signatureStatus(string data)
        {
            this.setProperty(CardPaymentsConstants.signatureStatus, data);
        }


        /// <summary>
        /// AuthenticationBuilder<typeparam name="TBLDR"></typeparam> will allow a Authentication to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class AuthenticationBuilder<TBLDR> : NestedJSONBuilder<PaysafeAuthentication, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Authentication builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public AuthenticationBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }


            /// <summary>
            /// Set the eci
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>AuthenticationBuilder<TBLDR></returns>
            public AuthenticationBuilder<TBLDR> eci(int data)
            {
                this.properties[CardPaymentsConstants.eci] = data;
                return this;
            }

            /// <summary>
            /// Set the cavv
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationBuilder<TBLDR></returns>
            public AuthenticationBuilder<TBLDR> cavv(string data)
            {
                this.properties[CardPaymentsConstants.cavv] = data;
                return this;
            }

            /// <summary>
            /// Set the xid
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationBuilder<TBLDR></returns>
            public AuthenticationBuilder<TBLDR> xid(string data)
            {
                this.properties[CardPaymentsConstants.xid] = data;
                return this;
            }

            /// <summary>
            /// Set the threeDEnrollment
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationBuilder<TBLDR></returns>
            public AuthenticationBuilder<TBLDR> threeDEnrollment(string data)
            {
                this.properties[CardPaymentsConstants.threeDEnrollment] = data;
                return this;
            }

            /// <summary>
            /// Set the threeDResult
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationBuilder<TBLDR></returns>
            public AuthenticationBuilder<TBLDR> threeDResult(string data)
            {
                this.properties[CardPaymentsConstants.threeDResult] = data;
                return this;
            }

            /// <summary>
            /// Set the signatureStatus
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationBuilder<TBLDR></returns>
            public AuthenticationBuilder<TBLDR> signatureStatus(string data)
            {
                this.properties[CardPaymentsConstants.signatureStatus] = data;
                return this;
            }

        }
    }
}
