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
using Paysafe.CustomerVault;
namespace Paysafe.DirectDebit
{
    //Created by Manjiri.Bankar on 03.05.2016. This is Purchases class.
    public class Purchases : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the Purchases object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Purchases(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        /// <summary>
        /// Initialize an Purchases object with an id
        /// </summary>
        /// <param name="id"></param>
        public Purchases(String id)
            : base(fieldTypes)
        {
            this.id(id);
        }

        /// <summary>
        /// Gets the array key to access the array of purchase
        /// </summary>
        /// <returns>The key to be checked in the returning JSON</returns>
        public static string getPageableArrayKey()
        {
            return "purchases";
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {DirectDebitConstants.id, STRING_TYPE},
            {DirectDebitConstants.merchantRefNum,STRING_TYPE },
            {DirectDebitConstants.amount, INT_TYPE},
            {DirectDebitConstants.ach, typeof(ACHBankAccounts)},
            {DirectDebitConstants.eft, typeof(EFTBankAccounts)},
            {DirectDebitConstants.bacs, typeof(BACSBankAccounts)},
            {DirectDebitConstants.sepa, typeof(SEPABankAccounts)},
            {DirectDebitConstants.profile,typeof(Profile)},
            {DirectDebitConstants.billingDetails, typeof(BillingDetails)},
            {DirectDebitConstants.customerIp, STRING_TYPE},
            {DirectDebitConstants.dupCheck, BOOL_TYPE},
            {DirectDebitConstants.txnTime, typeof(DateTime)},
            {DirectDebitConstants.currencyCode,STRING_TYPE},
            {DirectDebitConstants.error, typeof(OptError)},             
            {DirectDebitConstants.status, DirectDebitConstants.enumStatus},          
            {DirectDebitConstants.links, typeof(List<Link>)}
        };       

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(DirectDebitConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(string data)
        {
            this.setProperty(DirectDebitConstants.id, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>string</returns>
        public string merchantRefNum()
        {
            return this.getProperty(DirectDebitConstants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <returns>void</returns>
        public void merchantRefNum(string data)
        {
            this.setProperty(DirectDebitConstants.merchantRefNum, data);
        }

        /// <summary>
        /// Get the amount
        /// </summary>
        /// <returns>int</returns>
        public int amount()
        {
            return this.getProperty(DirectDebitConstants.amount);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <returns>void</returns>
        public void amount(int data)
        {
            this.setProperty(DirectDebitConstants.amount, data);
        }

        /// <summary>
        /// Get the ach
        /// </summary>
        /// <returns>ACHBankAccount</returns>
        public ACHBankAccounts ach()
        {
            return this.getProperty(DirectDebitConstants.ach);
        }

        /// <summary>
        /// Set the ach
        /// </summary>
        /// <returns>void</returns>
        public void ach(ACHBankAccounts data)
        {
            this.setProperty(DirectDebitConstants.ach, data);
        }

        /// <summary>
        /// Get the eft
        /// </summary>
        /// <returns>EFTBankAccount</returns>
        public EFTBankAccounts eft()
        {
            return this.getProperty(DirectDebitConstants.eft);
        }

        /// <summary>
        /// Set the eft
        /// </summary>
        /// <returns>void</returns>
        public void eft(EFTBankAccounts data)
        {
            this.setProperty(DirectDebitConstants.eft, data);
        }

        /// <summary>
        /// Get the bacs
        /// </summary>
        /// <returns>BACSBankAccount</returns>
        public BACSBankAccounts bacs()
        {
            return this.getProperty(DirectDebitConstants.bacs);
        }

        /// <summary>
        /// Set the bacs
        /// </summary>
        /// <returns>void</returns>
        public void bacs(BACSBankAccounts data)
        {
            this.setProperty(DirectDebitConstants.bacs, data);
        }

        /// <summary>
        /// Get the sepa
        /// </summary>
        /// <returns>SEPABankAccount</returns>
        public SEPABankAccounts sepa()
        {
            return this.getProperty(DirectDebitConstants.sepa);
        }

        /// <summary>
        /// Set the sepa
        /// </summary>
        /// <returns>void</returns>
        public void sepa(SEPABankAccounts data)
        {
            this.setProperty(DirectDebitConstants.sepa, data);
        }

        /// <summary>
        /// Get the profile
        /// </summary>
        /// <returns>Profile</returns>
        public Profile profile()
        {
            return this.getProperty(DirectDebitConstants.profile);
        }

        /// <summary>
        /// Set the profile
        /// </summary>
        /// <returns>void</returns>
        public void profile(Profile data)
        {
            this.setProperty(DirectDebitConstants.profile, data);
        }

        /// <summary>
        /// Get the billingDetails
        /// </summary>
        /// <returns>string</returns>
        public BillingDetails billingDetails()
        {
            return this.getProperty(DirectDebitConstants.billingDetails);
        }

        /// <summary>
        /// Set the billingDetails
        /// </summary>
        /// <returns>void</returns>
        public void billingDetails(BillingDetails data)
        {
            this.setProperty(DirectDebitConstants.billingDetails, data);
        }


        /// <summary>
        /// Get the customerIp
        /// </summary>
        /// <returns>string</returns>
        public string customerIp()
        {
            return this.getProperty(DirectDebitConstants.customerIp);
        }

        /// <summary>
        /// Set the customerIp
        /// </summary>
        /// <returns>void</returns>
        public void customerIp(string data)
        {
            this.setProperty(DirectDebitConstants.customerIp, data);
        }

        /// <summary>
        /// Get the dupCheck
        /// </summary>
        /// <returns>bool</returns>
        public bool dupCheck()
        {
            return this.getProperty(DirectDebitConstants.dupCheck);
        }

        /// <summary>
        /// Set the dupCheck
        /// </summary>
        /// <returns>void</returns>
        public void dupCheck(string data)
        {
            this.setProperty(DirectDebitConstants.dupCheck, data);
        }

        /// <summary>
        /// Get the txnTime
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime txnTime()
        {
            return this.getProperty(DirectDebitConstants.txnTime);
        }

        /// <summary>
        /// Set the txnTime
        /// </summary>
        /// <returns>void</returns>
        public void txnTime(DateTime data)
        {
            this.setProperty(DirectDebitConstants.txnTime, data);
        }

        /// <summary>
        /// Get the currencyCode
        /// </summary>
        /// <returns>string</returns>
        public string currencyCode()
        {
            return this.getProperty(DirectDebitConstants.currencyCode);
        }

        /// <summary>
        /// Set the currencyCode
        /// </summary>
        /// <returns>void</returns>
        public void ip(string data)
        {
            this.setProperty(DirectDebitConstants.currencyCode, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>string</returns>
        public string status()
        {
            return this.getProperty(DirectDebitConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(string data)
        {
            this.setProperty(DirectDebitConstants.status, data);
        }

        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
        public OptError error()
        {
            return this.getProperty(DirectDebitConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(DirectDebitConstants.error, data);
        }

        /// <summary>
        /// Get the Links
        /// </summary>
        /// <returns>Link</returns>
        public List<Link> links()
        {
            return this.getProperty(DirectDebitConstants.links);
        }

        /// <summary>
        /// Set the Links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(DirectDebitConstants.links, data);
        }

        public static PurchasesBuilder Builder()
        {
            return new PurchasesBuilder();
        }

        /// <summary>
        /// PurchasesBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Profile object
        /// </summary>
        public class PurchasesBuilder : BaseJSONBuilder<Purchases>
        {

            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder id(string data)
            {
                this.properties[DirectDebitConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder merchantRefNum(string data)
            {
                this.properties[DirectDebitConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the amount parameter
            /// </summary>
            /// <param name=data>List<string></param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder amount(int data)
            {
                this.properties[DirectDebitConstants.amount] = data;
                return this;
            }

            /// <summary>
            /// Build a ACHBankAccount within this authorization.
            /// </summary>
            /// <returns>ACHBankAccount.ACHAccountBuilder<ProfileBuilder></returns>
            public ACHBankAccounts.ACHAccountBuilder<PurchasesBuilder> ach()
            {
                if (!this.properties.ContainsKey(DirectDebitConstants.ach))
                {
                    this.properties[DirectDebitConstants.ach] = new ACHBankAccounts.ACHAccountBuilder<PurchasesBuilder>(this);
                }
                return this.properties[DirectDebitConstants.ach] as ACHBankAccounts.ACHAccountBuilder<PurchasesBuilder>;
            }

            /// <summary>
            /// Build a BACSBankAccount within this authorization.
            /// </summary>
            /// <returns>BACSBankAccount.BACSBankAccountBuilder></returns>
            public BACSBankAccounts.BACSBankAccountBuilder<PurchasesBuilder> bacs()
            {
                if (!this.properties.ContainsKey(DirectDebitConstants.bacs))
                {
                    this.properties[DirectDebitConstants.bacs] = new BACSBankAccounts.BACSBankAccountBuilder<PurchasesBuilder>(this);
                }
                return this.properties[DirectDebitConstants.bacs] as BACSBankAccounts.BACSBankAccountBuilder<PurchasesBuilder>;
            }

            /// <summary>
            /// Build a EFTBankAccount within this authorization.
            /// </summary>
            /// <returns>EFTBankAccount.EFTAccountBuilder</returns>
            public EFTBankAccounts.EFTAccountBuilder<PurchasesBuilder> eft()
            {
                if (!this.properties.ContainsKey(DirectDebitConstants.eft))
                {
                    this.properties[DirectDebitConstants.eft] = new EFTBankAccounts.EFTAccountBuilder<PurchasesBuilder>(this);
                }
                return this.properties[DirectDebitConstants.eft] as EFTBankAccounts.EFTAccountBuilder<PurchasesBuilder>;
            }

            /// <summary>
            /// Build a SEPABankAccount within this authorization.
            /// </summary>
            /// <returns>SEPABankAccount.SEPAAccountBuilder</returns>
            public SEPABankAccounts.SEPAAccountBuilder<PurchasesBuilder> sepa()
            {
                if (!this.properties.ContainsKey(DirectDebitConstants.sepa))
                {
                    this.properties[DirectDebitConstants.sepa] = new SEPABankAccounts.SEPAAccountBuilder<PurchasesBuilder>(this);
                }
                return this.properties[DirectDebitConstants.sepa] as SEPABankAccounts.SEPAAccountBuilder<PurchasesBuilder>;
            }
            
            /// <summary>
            /// Build a profile within this authorization.
            /// </summary>
            /// <returns>profile.profileBuilder<ProfileBuilder></returns>
            public Profile.ProfileBuilder<PurchasesBuilder> profile()
            {
                if (!this.properties.ContainsKey(DirectDebitConstants.profile))
                {
                    this.properties[DirectDebitConstants.profile] = new Profile.ProfileBuilder<PurchasesBuilder>(this);
                }
                return this.properties[DirectDebitConstants.profile] as Profile.ProfileBuilder<PurchasesBuilder>;
            }
           
            /// <summary>
            /// Build a billing details object within this authorization.
            /// </summary>
            /// <returns>BillingDetails.BillingDetailsBuilder<AuthorizationBuilder></returns>
            public BillingDetails.BillingDetailsBuilder<PurchasesBuilder> billingDetails()
            {
                if (!this.properties.ContainsKey(DirectDebitConstants.billingDetails))
                {
                    this.properties[DirectDebitConstants.billingDetails] = new BillingDetails.BillingDetailsBuilder<PurchasesBuilder>(this);
                }
                return this.properties[DirectDebitConstants.billingDetails] as BillingDetails.BillingDetailsBuilder<PurchasesBuilder>;
            }

            /// <summary>
            /// Set the customerIp parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder customerIp(string data)
            {
                this.properties[DirectDebitConstants.customerIp] = data;
                return this;
            }

            /// <summary>
            /// Set the dupCheck parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder dupCheck(bool data)
            {
                this.properties[DirectDebitConstants.dupCheck] = data;
                return this;
            }

            /// <summary>
            /// Set the currencyCode parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder currencyCode(string data)
            {
                this.properties[DirectDebitConstants.currencyCode] = data;
                return this;
            }

            /// <summary>
            /// Set the status parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasesBuilder</returns>
            public PurchasesBuilder status(string data)
            {
                this.properties[DirectDebitConstants.status] = data;
                return this;
            }           
        }
    }
        
}
