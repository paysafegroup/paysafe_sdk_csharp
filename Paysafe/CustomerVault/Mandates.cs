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

namespace Paysafe.CustomerVault
{
    //Created by Manjiri.Bankar on 03.05.2016. This is Mandates class.
    public class Mandates : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the Mandates object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Mandates(Dictionary<string, object> properties = null) 
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CustomerVaultConstants.id,STRING_TYPE},            
            {CustomerVaultConstants.reference, STRING_TYPE},
            {CustomerVaultConstants.bankAccountId, STRING_TYPE},
            {CustomerVaultConstants.status, CustomerVaultConstants.enumStatus},
            {CustomerVaultConstants.statusChangeDate,typeof(DateTime)},
            {CustomerVaultConstants.statusReasonCode, STRING_TYPE},
            {CustomerVaultConstants.statusReason, STRING_TYPE},            
            {CustomerVaultConstants.paymentToken,STRING_TYPE},            
            {CustomerVaultConstants.profileId, STRING_TYPE}
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(CustomerVaultConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(string data)
        {
            this.setProperty(CustomerVaultConstants.id, data);
        }

        /// <summary>
        /// Get the reference
        /// </summary>
        /// <returns>reference</returns>
        public string reference()
        {
            return this.getProperty(CustomerVaultConstants.reference);
        }

        /// <summary>
        /// Set the reference
        /// </summary>
        /// <returns>void</returns>
        public void reference(string data)
        {
            this.setProperty(CustomerVaultConstants.reference, data);
        }

        /// <summary>
        /// Get the bankAccountId
        /// </summary>
        /// <returns>string</returns>
        public string bankAccountId()
        {
            return this.getProperty(CustomerVaultConstants.bankAccountId);
        }

        /// <summary>
        /// Set the bankAccountId
        /// </summary>
        /// <returns>void</returns>
        public void bankAccountId(string data)
        {
            this.setProperty(CustomerVaultConstants.bankAccountId, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>string</returns>
        public string status()
        {
            return this.getProperty(CustomerVaultConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(string data)
        {
            this.setProperty(CustomerVaultConstants.status, data);
        }

        /// <summary>
        /// Get the statusChangeDate
        /// </summary>
        /// <returns>string</returns>
        public DateTime statusChangeDate()
        {
            return this.getProperty(CustomerVaultConstants.statusChangeDate);
        }

        /// <summary>
        /// Set the statusChangeDate
        /// </summary>
        /// <returns>void</returns>
        public void statusChangeDate(DateTime data)
        {
            this.setProperty(CustomerVaultConstants.statusChangeDate, data);
        }

        /// <summary>
        /// Get the statusReasonCode
        /// </summary>
        /// <returns>string</returns>
        public string statusReasonCode()
        {
            return this.getProperty(CustomerVaultConstants.statusReasonCode);
        }

        /// <summary>
        /// Set the statusReasonCode
        /// </summary>
        /// <returns>void</returns>
        public void statusReasonCode(string data)
        {
            this.setProperty(CustomerVaultConstants.statusReasonCode, data);
        }

        /// <summary>
        /// Get the statusReason
        /// </summary>
        /// <returns>string</returns>
        public string statusReason()
        {
            return this.getProperty(CustomerVaultConstants.statusReason);
        }

        /// <summary>
        /// Set the statusReason
        /// </summary>
        /// <returns>void</returns>
        public void statusReason(string data)
        {
            this.setProperty(CustomerVaultConstants.statusReason, data);
        }

        /// <summary>
        /// Get the paymentToken
        /// </summary>
        /// <returns>string</returns>
        public string paymentToken()
        {
            return this.getProperty(CustomerVaultConstants.paymentToken);
        }

        /// <summary>
        /// Set the paymentToken
        /// </summary>
        /// <returns>void</returns>
        public void paymentToken(string data)
        {
            this.setProperty(CustomerVaultConstants.paymentToken, data);
        }               

        /// <summary>
        /// Get the profileId
        /// </summary>
        /// <returns>String</returns>
        public String profileId()
        {
            return this.getProperty(CustomerVaultConstants.profileId);
        }

        /// <summary>
        /// Set the profileId
        /// </summary>
        /// <returns>void</returns>
        public void profileId(String data)
        {
            this.setProperty(CustomerVaultConstants.profileId, data);
        }
       
        public static MandatesBuilder Builder()
        {
            return new MandatesBuilder();
        }

        /// <summary>
        /// Mandates will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Profile object
        /// </summary>
        public class MandatesBuilder : BaseJSONBuilder<Mandates>
        {

            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder id(string data)
            {
                this.properties[CustomerVaultConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the reference parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder reference(string data)
            {
                this.properties[CustomerVaultConstants.reference] = data;
                return this;
            }

            /// <summary>
            /// Set the bankAccountId parameter
            /// </summary>
            /// <param name=data>List<string></param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder bankAccountId(string data)
            {
                this.properties[CustomerVaultConstants.bankAccountId] = data;
                return this;
            }

            /// <summary>
            /// Set the status parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder status(string data)
            {
                this.properties[CustomerVaultConstants.status] = data;
                return this;
            }

            /// <summary>
            /// Set the statusReason parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder statusReason(string data)
            {
                this.properties[CustomerVaultConstants.statusReason] = data;
                return this;
            }

            /// <summary>
            /// Set the statusChangeDate parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder statusChangeDate(DateTime data)
            {
                this.properties[CustomerVaultConstants.statusChangeDate] = data;
                return this;
            }

            /// <summary>
            /// Set the statusReasonCode parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder statusReasonCode(string data)
            {
                this.properties[CustomerVaultConstants.statusReasonCode] = data;
                return this;
            }

            /// <summary>
            /// Set the paymentToken parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder paymentToken(string data)
            {
                this.properties[CustomerVaultConstants.paymentToken] = data;
                return this;
            }


            /// <summary>
            /// Set the profileId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>MandatesBuilder</returns>
            public MandatesBuilder profileId(string data)
            {
                this.properties[CustomerVaultConstants.profileId] = data;
                return this;
            }
        }
                 
    }
}
