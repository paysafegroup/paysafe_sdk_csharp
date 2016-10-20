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

namespace Paysafe.DirectDebit
{
    //Created by Manjiri.Bankar on 03.05.2016. This is SEPABankAccounts class.
    public class SEPABankAccounts : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the SEPABankAccounts object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public SEPABankAccounts(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {DirectDebitConstants.paymentToken,STRING_TYPE}, 
            {DirectDebitConstants.mandateReference,STRING_TYPE}, 
            {DirectDebitConstants.accountHolderName,STRING_TYPE}, 
            {DirectDebitConstants.iban,STRING_TYPE}, 
            {DirectDebitConstants.lastDigits,STRING_TYPE}, 
                                       
        };

        /// <summary>
        /// Get the paymentToken
        /// </summary>
        /// <returns>string</returns>
        public string paymentToken()
        {
            return this.getProperty(DirectDebitConstants.paymentToken);
        }

        /// <summary>
        /// Set the paymentToken
        /// </summary>
        /// <returns>void</returns>
        public void paymentToken(string data)
        {
            this.setProperty(DirectDebitConstants.paymentToken, data);
        }

        /// <summary>
        /// Get the mandateReference
        /// </summary>
        /// <returns>string</returns>
        public string mandateReference()
        {
            return this.getProperty(DirectDebitConstants.mandateReference);
        }

        /// <summary>
        /// Set the mandateReference
        /// </summary>
        /// <returns>void</returns>
        public void mandateReference(string data)
        {
            this.setProperty(DirectDebitConstants.mandateReference, data);
        }
        /// <summary>
        /// Get the accountHolderName
        /// </summary>
        /// <returns>string</returns>
        public string accountHolderName()
        {
            return this.getProperty(DirectDebitConstants.accountHolderName);
        }

        /// <summary>
        /// Set the accountHolderName
        /// </summary>
        /// <returns>void</returns>
        public void accountHolderName(string data)
        {
            this.setProperty(DirectDebitConstants.accountHolderName, data);
        }
        /// <summary>
        /// Get the iban
        /// </summary>
        /// <returns>string</returns>
        public string iban()
        {
            return this.getProperty(DirectDebitConstants.iban);
        }

        /// <summary>
        /// Set the iban
        /// </summary>
        /// <returns>void</returns>
        public void iban(string data)
        {
            this.setProperty(DirectDebitConstants.iban, data);
        }
        /// <summary>
        /// Get the lastDigits
        /// </summary>
        /// <returns>string</returns>
        public string lastDigits()
        {
            return this.getProperty(DirectDebitConstants.lastDigits);
        }

        /// <summary>
        /// Set the lastDigits
        /// </summary>
        /// <returns>void</returns>
        public void lastDigits(string data)
        {
            this.setProperty(DirectDebitConstants.lastDigits, data);
        }
       
        /// <summary>
        /// SEPAAccountBuilder will allow an account to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated SEPABankAccount object
        /// </summary>
        public class SEPAAccountBuilder<TBLDR> : NestedJSONBuilder<SEPABankAccounts, TBLDR>
            where TBLDR : GenericJSONBuilder
        {

           /// <summary>
            /// Initialize the SEPAAccountBuilder builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public SEPAAccountBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the paymentToken
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SEPAAccountBuilder<TBLDR></returns>
            public SEPAAccountBuilder<TBLDR> paymentToken(string data)
            {
                this.properties[DirectDebitConstants.paymentToken] = data;
                return this;
            }
            
            /// <summary>
            /// Set the mandateReference
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SEPAAccountBuilder<TBLDR></returns>
            public SEPAAccountBuilder<TBLDR> mandateReference(string data)
            {
                this.properties[DirectDebitConstants.mandateReference] = data;
                return this;
            }

            /// <summary>
            /// Set the accountHolderName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SEPAAccountBuilder<TBLDR></returns>
            public SEPAAccountBuilder<TBLDR> accountHolderName(string data)
            {
                this.properties[DirectDebitConstants.accountHolderName] = data;
                return this;
            }
          
            /// <summary>
            /// Set the iban
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SEPAAccountBuilder<TBLDR></returns>
            public SEPAAccountBuilder<TBLDR> iban(string data)
            {
                this.properties[DirectDebitConstants.iban] = data;
                return this;
            }          

            /// <summary>
            /// Set the lastDigits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SEPAAccountBuilder<TBLDR></returns>
            public SEPAAccountBuilder<TBLDR> lastDigits(string data)
            {
                this.properties[DirectDebitConstants.lastDigits] = data;
                return this;
            }

        }

    }
}
