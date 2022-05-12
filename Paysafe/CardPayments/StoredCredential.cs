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

using System.Collections.Generic;
using Paysafe.Common;

namespace Paysafe.CardPayments
{
    public class StoredCredential : JSONObject
    {
        /// <summary>
        /// Initialize the StoredCredential object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public StoredCredential(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.type, CardPaymentsConstants.enumType},
            {GlobalConstants.occurrence, CardPaymentsConstants.enumOccurrence},
            {GlobalConstants.initialTransactionId, STRING_TYPE },
            {GlobalConstants.externalInitialTransactionId, STRING_TYPE }

        };

        /// <summary>
        /// Get the type
        /// </summary>
        /// <returns>string</returns>
        public string type()
        {
            return this.getProperty(CardPaymentsConstants.type);
        }

        /// <summary>
        /// Set the type
        /// </summary>
        /// <returns>void</returns>
        public void type(string data)
        {
            this.setProperty(CardPaymentsConstants.type, data);
        }
        
        /// <summary>
        /// Get the occurrence
        /// </summary>
        /// <returns>string</returns>
        public string occurrence()
        {
            return this.getProperty(CardPaymentsConstants.occurrence);
        }

        /// <summary>
        /// Set the type
        /// </summary>
        /// <returns>void</returns>
        public void occurrence(string data)
        {
            this.setProperty(CardPaymentsConstants.occurrence, data);
        }


        /// <summary>
        /// Get the ID of the initial Recurring Payment transaction. 
        /// The id should be stored from the auth response of the transaction indicated as initial with the following: 
        /// type=RECURRING/TOPUP/ADHOC, occurrence=INITIAL.
        /// </summary>
        /// <returns>string</returns>
        public string initialTransactionId()
        {
            return this.getProperty(GlobalConstants.initialTransactionId);
        }

        /// <summary>
        /// Set the ID of the initial Recurring Payment transaction. 
        /// The id should be stored from the auth response of the transaction indicated as initial with the following: 
        /// type=RECURRING/TOPUP/ADHOC, occurrence=INITIAL.
        /// </summary>
        /// <returns>void</returns>
        public void initialTransactionId(string data)
        {
            this.setProperty(GlobalConstants.initialTransactionId, data);
        }

        /// <summary>
        /// Get the ID of the initial Recurring Payment transaction in case this transaction was processed through external PSP.
        /// </summary>
        /// <returns>string</returns>
        public string externalInitialTransactionId()
        {
            return this.getProperty(GlobalConstants.externalInitialTransactionId);
        }

        /// <summary>
        /// Set the ID of the initial Recurring Payment transaction in case this transaction was processed through external PSP.
        /// </summary>
        /// <returns>void</returns>
        public void externalInitialTransactionId(string data)
        {
            this.setProperty(GlobalConstants.externalInitialTransactionId, data);
        }

        /// <summary>
        /// StoredCredentialBuilder<typeparam name="TBLDR"></typeparam> will allow a StoredCredential to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class StoredCredentialBuilder<TBLDR> : NestedJSONBuilder<StoredCredential, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the StoredCredential builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public StoredCredentialBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the type
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>StoredCredentialBuilder<TBLDR></returns>
            public StoredCredentialBuilder<TBLDR> type(string data)
            {
                this.properties[GlobalConstants.type] = data;
                return this;
            }

            /// <summary>
            /// Set the occurrence
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>StoredCredentialBuilder<TBLDR></returns>
            public StoredCredentialBuilder<TBLDR> occurrence(string data)
            {
                this.properties[GlobalConstants.occurrence] = data;
                return this;
            }

            /// <summary>
            /// Set the ID of the initial Recurring Payment transaction. 
            /// The id should be stored from the auth response of the transaction indicated as initial with the following: 
            /// type=RECURRING/TOPUP/ADHOC, occurrence=INITIAL.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>StoredCredentialBuilder<TBLDR></returns>
            public StoredCredentialBuilder<TBLDR> initialTransactionId(string data)
            {
                this.properties[GlobalConstants.initialTransactionId] = data;
                return this;
            }

            /// <summary>
            /// Set the ID of the initial Recurring Payment transaction in case this transaction was processed through external PSP.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>StoredCredentialBuilder<TBLDR></returns>
            public StoredCredentialBuilder<TBLDR> externalInitialTransactionId(string data)
            {
                this.properties[GlobalConstants.externalInitialTransactionId] = data;
                return this;
            }
        }
    }
}
