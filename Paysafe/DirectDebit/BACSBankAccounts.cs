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
    //Created by Manjiri.Bankar on 03.05.2016. This is BACSBankAccounts class.
    public class BACSBankAccounts : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the EFTBankAccounts object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public BACSBankAccounts(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {DirectDebitConstants.paymentToken,STRING_TYPE},             
            {DirectDebitConstants.accountHolderName, STRING_TYPE},  
            {DirectDebitConstants.sortCode, STRING_TYPE},
            {DirectDebitConstants.mandateReference, STRING_TYPE},           
            {DirectDebitConstants.lastDigits, STRING_TYPE},
            {DirectDebitConstants.accountNumber, STRING_TYPE}              
        };

        // <summary>
        /// Get the accountNumber
        /// </summary>
        /// <returns>string</returns>
        public string accountNumber()
        {
            return this.getProperty(DirectDebitConstants.accountNumber);
        }

        /// <summary>
        /// Set the accountNumber
        /// </summary>
        /// <returns>void</returns>
        public void accountNumber(string data)
        {
            this.setProperty(DirectDebitConstants.accountNumber, data);
        }
      
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
        /// Get the sortCode
        /// </summary>
        /// <returns>string</returns>
        public string sortCode()
        {
            return this.getProperty(DirectDebitConstants.sortCode);
        }

        /// <summary>
        /// Set the sortCode
        /// </summary>
        /// <returns>void</returns>
        public void sortCode(string data)
        {
            this.setProperty(DirectDebitConstants.sortCode, data);
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
        /// BACSBankAccountBuilder will allow an account to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated BACSBankAccount object
        /// </summary>
        public class BACSBankAccountBuilder<TBLDR> : NestedJSONBuilder<BACSBankAccounts, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the BillingDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public BACSBankAccountBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the paymentToken
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> paymentToken(string data)
            {
                this.properties[DirectDebitConstants.paymentToken] = data;
                return this;
            }

            /// <summary>
            /// Set the accountHolderName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> accountHolderName(string data)
            {
                this.properties[DirectDebitConstants.accountHolderName] = data;
                return this;
            }
            /// <summary>
            /// Set the paymentDescriptor
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> paymentDescriptor(string data)
            {
                this.properties[DirectDebitConstants.paymentDescriptor] = data;
                return this;
            }
            /// <summary>
            /// Set the sortCode
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> sortCode(string data)
            {
                this.properties[DirectDebitConstants.sortCode] = data;
                return this;
            }
            /// <summary>
            /// Set the reference
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> mandateReference(string data)
            {
                this.properties[DirectDebitConstants.mandateReference] = data;
                return this;
            }
          
            /// <summary>
            /// Set the lastDigits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> lastDigits(string data)
            {
                this.properties[DirectDebitConstants.lastDigits] = data;
                return this;
            }

            /// <summary>
            /// Set the accountNumber
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSBankAccountBuilder<TBLDR></returns>
            public BACSBankAccountBuilder<TBLDR> accountNumber(string data)
            {
                this.properties[DirectDebitConstants.accountNumber] = data;
                return this;
            }
        }
    }
}
