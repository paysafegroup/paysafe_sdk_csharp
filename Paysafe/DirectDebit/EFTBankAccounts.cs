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
    //Created by Manjiri.Bankar on 03.05.2016. This is EFTBankAccounts class.
    public class EFTBankAccounts : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the EFTBankAccounts object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public EFTBankAccounts(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {DirectDebitConstants.paymentToken,STRING_TYPE},                      
            {DirectDebitConstants.paymentDescriptor, STRING_TYPE},
             {DirectDebitConstants.accountHolderName, STRING_TYPE},            
            {DirectDebitConstants.accountNumber, STRING_TYPE},
            {DirectDebitConstants.transitNumber, STRING_TYPE},
            {DirectDebitConstants.institutionId, STRING_TYPE},
            {DirectDebitConstants.lastDigits, STRING_TYPE} 
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
        /// Get the paymentDescriptor
        /// </summary>
        /// <returns>string</returns>
        public string paymentDescriptor()
        {
            return this.getProperty(DirectDebitConstants.paymentDescriptor);
        }

        /// <summary>
        /// Set the paymentDescriptor
        /// </summary>
        /// <returns>void</returns>
        public void paymentDescriptor(string data)
        {
            this.setProperty(DirectDebitConstants.paymentDescriptor, data);
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
        /// Get the transitNumber
        /// </summary>
        /// <returns>string</returns>
        public string transitNumber()
        {
            return this.getProperty(DirectDebitConstants.transitNumber);
        }

        /// <summary>
        /// Set the transitNumber
        /// </summary>
        /// <returns>void</returns>
        public void transitNumber(string data)
        {
            this.setProperty(DirectDebitConstants.transitNumber, data);
        }

        /// <summary>
        /// Get the institutionId
        /// </summary>
        /// <returns>string</returns>
        public string institutionId()
        {
            return this.getProperty(DirectDebitConstants.institutionId);
        }

        /// <summary>
        /// Set the institutionId
        /// </summary>
        /// <returns>void</returns>
        public void institutionId(string data)
        {
            this.setProperty(DirectDebitConstants.institutionId, data);
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
        /// EFTAccountBuilder will allow an account to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated EFTAccount object
        /// </summary>
        public class EFTAccountBuilder<TBLDR> : NestedJSONBuilder<EFTBankAccounts, TBLDR>
            where TBLDR : GenericJSONBuilder
        {

            /// <summary>
            /// Initialize the EFTAccountBuilder builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public EFTAccountBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the paymentToken
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> paymentToken(string data)
            {
                this.properties[DirectDebitConstants.paymentToken] = data;
                return this;
            }
            
            /// <summary>
            /// Set the paymentDescriptor
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> paymentDescriptor(string data)
            {
                this.properties[DirectDebitConstants.paymentDescriptor] = data;
                return this;
            }
            /// <summary>
            /// Set the accountHolderName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> accountHolderName(string data)
            {
                this.properties[DirectDebitConstants.accountHolderName] = data;
                return this;
            }
          
            /// <summary>
            /// Set the accountNumber
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> accountNumber(string data)
            {
                this.properties[DirectDebitConstants.accountNumber] = data;
                return this;
            }

            /// <summary>
            /// Set the transitNumber
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> transitNumber(string data)
            {
                this.properties[DirectDebitConstants.transitNumber] = data;
                return this;
            }

            /// <summary>
            /// Set the institutionId
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> institutionId(string data)
            {
                this.properties[DirectDebitConstants.institutionId] = data;
                return this;
            }

            /// <summary>
            /// Set the lastDigits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>EFTAccountBuilder<TBLDR></returns>
            public EFTAccountBuilder<TBLDR> lastDigits(string data)
            {
                this.properties[DirectDebitConstants.lastDigits] = data;
                return this;
            }
        }

    }
}
