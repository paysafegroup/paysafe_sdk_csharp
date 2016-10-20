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
    //Created by Manjiri.Bankar on 03.05.2016. This is BACSBankAccounts class.
    public class BACSBankAccounts : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the BACSBankAccounts object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public BACSBankAccounts(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CustomerVaultConstants.id,STRING_TYPE},            
            {CustomerVaultConstants.nickName, STRING_TYPE},
            {CustomerVaultConstants.merchantRefNum, STRING_TYPE},
            {CustomerVaultConstants.status, CustomerVaultConstants.enumStatus},
            {CustomerVaultConstants.statusReason, STRING_TYPE},
            {CustomerVaultConstants.accountNumber, STRING_TYPE},
            {CustomerVaultConstants.accountHolderName, STRING_TYPE},
            {CustomerVaultConstants.sortCode, STRING_TYPE},            
            {CustomerVaultConstants.lastDigits, STRING_TYPE},
            {CustomerVaultConstants.billingAddressId, STRING_TYPE},
            {CustomerVaultConstants.paymentToken,STRING_TYPE},
            {CustomerVaultConstants.mandates,typeof(List<Mandates>)},
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
        /// Get the nickName
        /// </summary>
        /// <returns>string</returns>
        public string nickName()
        {
            return this.getProperty(CustomerVaultConstants.nickName);
        }

        /// <summary>
        /// Set the nickName
        /// </summary>
        /// <returns>void</returns>
        public void nickName(string data)
        {
            this.setProperty(CustomerVaultConstants.nickName, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>string</returns>
        public string merchantRefNum()
        {
            return this.getProperty(CustomerVaultConstants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <returns>void</returns>
        public void merchantRefNum(string data)
        {
            this.setProperty(CustomerVaultConstants.merchantRefNum, data);
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
        /// Get the accountNumber
        /// </summary>
        /// <returns>string</returns>
        public string accountNumber()
        {
            return this.getProperty(CustomerVaultConstants.accountNumber);
        }

        /// <summary>
        /// Set the accountNumber
        /// </summary>
        /// <returns>void</returns>
        public void accountNumber(string data)
        {
            this.setProperty(CustomerVaultConstants.accountNumber, data);
        }

        /// <summary>
        /// Get the accountHolderName
        /// </summary>
        /// <returns>string</returns>
        public string accountHolderName()
        {
            return this.getProperty(CustomerVaultConstants.accountHolderName);
        }

        /// <summary>
        /// Set the accountHolderName
        /// </summary>
        /// <returns>void</returns>
        public void accountHolderName(string data)
        {
            this.setProperty(CustomerVaultConstants.accountHolderName, data);
        }

        /// <summary>
        /// Get the sortCode
        /// </summary>
        /// <returns>string</returns>
        public string sortCode()
        {
            return this.getProperty(CustomerVaultConstants.sortCode);
        }

        /// <summary>
        /// Set the sortCode
        /// </summary>
        /// <returns>void</returns>
        public void sortCode(string data)
        {
            this.setProperty(CustomerVaultConstants.sortCode, data);
        }
       
        /// <summary>
        /// Get the lastDigits
        /// </summary>
        /// <returns>string</returns>
        public string lastDigits()
        {
            return this.getProperty(CustomerVaultConstants.lastDigits);
        }

        /// <summary>
        /// Set the lastDigits
        /// </summary>
        /// <returns>void</returns>
        public void lastDigits(string data)
        {
            this.setProperty(CustomerVaultConstants.lastDigits, data);
        }

        /// <summary>
        /// Get the billingAddressId
        /// </summary>
        /// <returns>string</returns>
        public string billingAddressId()
        {
            return this.getProperty(CustomerVaultConstants.billingAddressId);
        }

        /// <summary>
        /// Set the billingAddressId
        /// </summary>
        /// <returns>void</returns>
        public void billingAddressId(string data)
        {
            this.setProperty(CustomerVaultConstants.billingAddressId, data);
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
        /// Get the mandates
        /// </summary>
        /// <returns>List</returns>
        public List<Mandates> mandates()
        {
            return this.getProperty(CustomerVaultConstants.mandates);
        }

        /// <summary>
        /// Set the mandates
        /// </summary>
        /// <returns>void</returns>
        public void mandates(List<Mandates> data)
        {
            this.setProperty(CustomerVaultConstants.mandates, data);
        }

        /// <summary>
        /// Get the profileId
        /// </summary>
        /// <returns>String</returns>
        public string profileId()
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

        public static BACSAccountBuilder Builder()
        {
            return new BACSAccountBuilder();
        }

        /// <summary>
        /// BACSAccountBuilder will allow an account to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated BACSAccount object
        /// </summary>
        public class BACSAccountBuilder : BaseJSONBuilder<BACSBankAccounts>
        {

            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder id(string data)
            {
                this.properties[CustomerVaultConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the nickName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder nickName(string data)
            {
                this.properties[CustomerVaultConstants.nickName] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder merchantRefNum(string data)
            {
                this.properties[CustomerVaultConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the status parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder status(string data)
            {
                this.properties[CustomerVaultConstants.status] = data;
                return this;
            }

            /// <summary>
            /// Set the statusReason parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder statusReason(string data)
            {
                this.properties[CustomerVaultConstants.statusReason] = data;
                return this;
            }

            /// <summary>
            /// Set the accountNumber parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder accountNumber(string data)
            {
                this.properties[CustomerVaultConstants.accountNumber] = data;
                return this;
            }

            /// <summary>
            /// Set the accountHolderName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder accountHolderName(string data)
            {
                this.properties[CustomerVaultConstants.accountHolderName] = data;
                return this;
            }

            /// <summary>
            /// Set the sortCode parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder sortCode(string data)
            {
                this.properties[CustomerVaultConstants.sortCode] = data;
                return this;
            }           

            /// <summary>
            /// Set the lastDigits parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder lastDigits(string data)
            {
                this.properties[CustomerVaultConstants.lastDigits] = data;
                return this;
            }

            /// <summary>
            /// Set the billingAddressId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder billingAddressId(string data)
            {
                this.properties[CustomerVaultConstants.billingAddressId] = data;
                return this;
            }

            /// <summary>
            /// Set the paymentToken parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder paymentToken(string data)
            {
                this.properties[CustomerVaultConstants.paymentToken] = data;
                return this;
            }
           

            /// <summary>
            /// Set the profileId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder profileId(string data)
            {
                this.properties[CustomerVaultConstants.profileId] = data;
                return this;
            }

            /// <summary>
            /// Set the mandates parameter
            /// </summary>
            /// <param name=data>List</param>
            /// <returns>BACSAccountBuilder</returns>
            public BACSAccountBuilder mandates(List<Mandates> data)
            {
                this.properties[CustomerVaultConstants.mandates] = data;
                return this;
            }
        }   
    
    }
}
