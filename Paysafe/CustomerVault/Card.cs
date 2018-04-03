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
    public class Card : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the Card object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Card(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CustomerVaultConstants.id, STRING_TYPE},
            {CustomerVaultConstants.nickName, STRING_TYPE},
            {CustomerVaultConstants.singleUseToken, STRING_TYPE},
            {CustomerVaultConstants.status, CustomerVaultConstants.enumStatus},
            {CustomerVaultConstants.merchantRefNum, STRING_TYPE},
            {CustomerVaultConstants.holderName, STRING_TYPE},
            {CustomerVaultConstants.cardNum, STRING_TYPE},
            {CustomerVaultConstants.cardBin, STRING_TYPE},
            {CustomerVaultConstants.lastDigits, STRING_TYPE},
            {CustomerVaultConstants.cardExpiry, typeof(CardExpiry)},
            {CustomerVaultConstants.cardType, STRING_TYPE},
            {CustomerVaultConstants.billingAddressId, STRING_TYPE},
            {CustomerVaultConstants.defaultCardIndicator, BOOL_TYPE},
            {CustomerVaultConstants.paymentToken, STRING_TYPE},
            {CustomerVaultConstants.error, typeof(OptError)},
            {CustomerVaultConstants.links, typeof(List<Link>)},
            {CustomerVaultConstants.profileId, STRING_TYPE},
            {CustomerVaultConstants.billingAddress, typeof(BillingAddress)}
            
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>String</returns>
        public String id()
        {
            return this.getProperty(CustomerVaultConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(String data)
        {
            this.setProperty(CustomerVaultConstants.id, data);
        }

        /// <summary>
        /// Get the singleUseToken
        /// </summary>
        /// <returns>String</returns>
        public String singleUseToken()
        {
            return this.getProperty(CustomerVaultConstants.singleUseToken);
        }

        /// <summary>
        /// Set the singleUseToken
        /// </summary>
        /// <returns>void</returns>
        public void singleUseToken(String data)
        {
            this.setProperty(CustomerVaultConstants.singleUseToken, data);
        }

        /// <summary>
        /// Get the nickName
        /// </summary>
        /// <returns>String</returns>
        public String nickName()
        {
            return this.getProperty(CustomerVaultConstants.nickName);
        }

        /// <summary>
        /// Set the nickName
        /// </summary>
        /// <returns>void</returns>
        public void nickName(String data)
        {
            this.setProperty(CustomerVaultConstants.nickName, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>String</returns>
        public String status()
        {
            return this.getProperty(CustomerVaultConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(String data)
        {
            this.setProperty(CustomerVaultConstants.status, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>String</returns>
        public String merchantRefNum()
        {
            return this.getProperty(CustomerVaultConstants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <returns>void</returns>
        public void merchantRefNum(String data)
        {
            this.setProperty(CustomerVaultConstants.merchantRefNum, data);
        }

        /// <summary>
        /// Get the holderName
        /// </summary>
        /// <returns>String</returns>
        public String holderName()
        {
            return this.getProperty(CustomerVaultConstants.holderName);
        }

        /// <summary>
        /// Set the holderName
        /// </summary>
        /// <returns>void</returns>
        public void holderName(String data)
        {
            this.setProperty(CustomerVaultConstants.holderName, data);
        }

        /// <summary>
        /// Get the cardNum
        /// </summary>
        /// <returns>String</returns>
        public String cardNum()
        {
            return this.getProperty(CustomerVaultConstants.cardNum);
        }

        /// <summary>
        /// Set the cardNum
        /// </summary>
        /// <returns>void</returns>
        public void cardNum(String data)
        {
            this.setProperty(CustomerVaultConstants.cardNum, data);
        }

        /// <summary>
        /// Get the cardBin
        /// </summary>
        /// <returns>String</returns>
        public String cardBin()
        {
            return this.getProperty(CustomerVaultConstants.cardBin);
        }

        /// <summary>
        /// Set the cardBin
        /// </summary>
        /// <returns>void</returns>
        public void cardBin(String data)
        {
            this.setProperty(CustomerVaultConstants.cardBin, data);
        }

        /// <summary>
        /// Get the lastDigits
        /// </summary>
        /// <returns>String</returns>
        public String lastDigits()
        {
            return this.getProperty(CustomerVaultConstants.lastDigits);
        }

        /// <summary>
        /// Set the lastDigits
        /// </summary>
        /// <returns>void</returns>
        public void lastDigits(String data)
        {
            this.setProperty(CustomerVaultConstants.lastDigits, data);
        }

        /// <summary>
        /// Get the cardExpiry
        /// </summary>
        /// <returns>CardExpiry</returns>
        public CardExpiry cardExpiry()
        {
            return this.getProperty(CustomerVaultConstants.cardExpiry);
        }

        /// <summary>
        /// Set the cardExpiry
        /// </summary>
        /// <returns>void</returns>
        public void cardExpiry(CardExpiry data)
        {
            this.setProperty(CustomerVaultConstants.cardExpiry, data);
        }

        /// <summary>
        /// Get the cardType
        /// </summary>
        /// <returns>String</returns>
        public String cardType()
        {
            return this.getProperty(CustomerVaultConstants.cardType);
        }

        /// <summary>
        /// Set the cardType
        /// </summary>
        /// <returns>void</returns>
        public void cardType(String data)
        {
            this.setProperty(CustomerVaultConstants.cardType, data);
        }
  
        /// <summary>
        /// Get the billingAddressId
        /// </summary>
        /// <returns>String</returns>
        public String billingAddressId()
        {
            return this.getProperty(CustomerVaultConstants.billingAddressId);
        }

        /// <summary>
        /// Set the billingAddressId
        /// </summary>
        /// <returns>void</returns>
        public void billingAddressId(String data)
        {
            this.setProperty(CustomerVaultConstants.billingAddressId, data);
        }
        
        /// <summary>
        /// Get the defaultCardIndicator
        /// </summary>
        /// <returns>bool</returns>
        public bool defaultCardIndicator()
        {
            return this.getProperty(CustomerVaultConstants.defaultCardIndicator);
        }

        /// <summary>
        /// Set the defaultCardIndicator
        /// </summary>
        /// <returns>void</returns>
        public void defaultCardIndicator(bool data)
        {
            this.setProperty(CustomerVaultConstants.defaultCardIndicator, data);
        }
        
        /// <summary>
        /// Get the paymentToken
        /// </summary>
        /// <returns>String</returns>
        public String paymentToken()
        {
            return this.getProperty(CustomerVaultConstants.paymentToken);
        }

        /// <summary>
        /// Set the paymentToken
        /// </summary>
        /// <returns>void</returns>
        public void paymentToken(String data)
        {
            this.setProperty(CustomerVaultConstants.paymentToken, data);
        }
        
        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
        public OptError error()
        {
            return this.getProperty(CustomerVaultConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(CustomerVaultConstants.error, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>List<Link></returns>
        public List<Link> links()
        {
            return this.getProperty(CustomerVaultConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(CustomerVaultConstants.links, data);
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

        /// <summary>
        /// Get the billingAddress
        /// </summary>
        /// <returns>List<Link></returns>
        public BillingAddress billingAddress()
        {
            return this.getProperty(CustomerVaultConstants.billingAddress);
        }

        /// <summary>
        /// Set the billingAddress
        /// </summary>
        /// <returns>void</returns>
        public void billingAddress(BillingAddress data)
        {
            this.setProperty(CustomerVaultConstants.billingAddress, data);
        }

        public static CardBuilder Builder()
        {
            return new CardBuilder();
        }

        /// <summary>
        /// CardBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Card object
        /// </summary>
        public class CardBuilder : BaseJSONBuilder<Card>
        {
            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder id(string data)
            {
                this.properties[CustomerVaultConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the profileId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder profileId(string data)
            {
                this.properties[CustomerVaultConstants.profileId] = data;
                return this;
            }

            /// <summary>
            /// Set the cardNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder cardNum(string data)
            {
                this.properties[CustomerVaultConstants.cardNum] = data;
                return this;
            }

            /// <summary>
            /// Build an cardExpiry object within this authorization.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder></returns>
            public CardExpiry.CardExpiryBuilder<CardBuilder> cardExpiry()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.cardExpiry))
                {
                    this.properties[CustomerVaultConstants.cardExpiry] = new CardExpiry.CardExpiryBuilder<CardBuilder>(this);
                }
                return this.properties[CustomerVaultConstants.cardExpiry] as CardExpiry.CardExpiryBuilder<CardBuilder>;
            }

            /// <summary>
            /// Set the nickName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder nickName(string data)
            {
                this.properties[CustomerVaultConstants.nickName] = data;
                return this;
            }

            /// <summary>
            /// Set the nickName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder singleUseToken(string data)
            {
                this.properties[CustomerVaultConstants.singleUseToken] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder merchantRefNum(string data)
            {
                this.properties[CustomerVaultConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the holderName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder holderName(string data)
            {
                this.properties[CustomerVaultConstants.holderName] = data;
                return this;
            }

            /// <summary>
            /// Set the billingAddressId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilder billingAddressId(string data)
            {
                this.properties[CustomerVaultConstants.billingAddressId] = data;
                return this;
            }

            /// <summary>
            /// Build an cardExpiry object within this authorization.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder></returns>
            public BillingAddress.BillingAddressBuilder<CardBuilder> billingAddress()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.billingAddress))
                {
                    this.properties[CustomerVaultConstants.billingAddress] = new BillingAddress.BillingAddressBuilder<CardBuilder>(this);
                }
                return this.properties[CustomerVaultConstants.billingAddress] as BillingAddress.BillingAddressBuilder<CardBuilder>;
            }
        }


        /// <summary>
        /// CardBuilder<typeparam name="TBLDR"></typeparam> will allow an card to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class CardBuilderSingelUse<TBLDR> : NestedJSONBuilder<Card, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Card builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public CardBuilderSingelUse(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the singelUseToken
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>

            public CardBuilderSingelUse<TBLDR> singleUseToken(String data)
            {
                this.properties[CustomerVaultConstants.singleUseToken] = data;
                return this;
            }

            /// <summary>
            /// Set the id parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilderSingelUse<TBLDR> id(string data)
            {
                this.properties[CustomerVaultConstants.id] = data;
                return this;
            }


            /// <summary>
            /// Set the cardNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilderSingelUse<TBLDR> cardNum(string data)
            {
                this.properties[CustomerVaultConstants.cardNum] = data;
                return this;
            }

            /// <summary>
            /// Build an cardExpiry object within this authorization.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder></returns>
            public CardExpiry.CardExpiryBuilder<CardBuilderSingelUse<TBLDR>> cardExpiry()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.cardExpiry))
                {
                    this.properties[CustomerVaultConstants.cardExpiry] = new CardExpiry.CardExpiryBuilder<CardBuilderSingelUse<TBLDR>>(this);
                }
                return this.properties[CustomerVaultConstants.cardExpiry] as CardExpiry.CardExpiryBuilder<CardBuilderSingelUse<TBLDR>>;
            }

            /// <summary>
            /// Set the nickName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilderSingelUse<TBLDR> nickName(string data)
            {
                this.properties[CustomerVaultConstants.nickName] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilderSingelUse<TBLDR> merchantRefNum(string data)
            {
                this.properties[CustomerVaultConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the holderName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilderSingelUse<TBLDR> holderName(string data)
            {
                this.properties[CustomerVaultConstants.holderName] = data;
                return this;
            }

            /// <summary>
            /// Set the billingAddressId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder</returns>
            public CardBuilderSingelUse<TBLDR> billingAddressId(string data)
            {
                this.properties[CustomerVaultConstants.billingAddressId] = data;
                return this;
            }

            /// <summary>
            /// Build an cardExpiry object within this authorization.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder></returns>
            public BillingAddress.BillingAddressBuilder<CardBuilderSingelUse<TBLDR>> billingAddress()
            {
                if (!this.properties.ContainsKey(CustomerVaultConstants.billingAddress))
                {
                    this.properties[CustomerVaultConstants.billingAddress] = new BillingAddress.BillingAddressBuilder<CardBuilderSingelUse<TBLDR>>(this);
                }
                return this.properties[CustomerVaultConstants.billingAddress] as BillingAddress.BillingAddressBuilder<CardBuilderSingelUse<TBLDR>>;
            }

        }


        ///// <summary>
        ///// CardBuilder<typeparam name="TBLDR"></typeparam> will allow an card to be initialized
        ///// within another builder. Set properties and subpropeties, then trigger .Done() to 
        ///// get back tot he parent builder
        ///// </summary>
        //public class CardBuilder1<TBLDR> : NestedJSONBuilder<Card, TBLDR>
        //    where TBLDR : GenericJSONBuilder
        //{
        //    /// <summary>
        //    /// Initialize the Card builder within the context of a parent builder
        //    /// </summary>
        //    /// <param name="parent">TBLDR</param>
        //    public CardBuilder1(TBLDR parent)
        //        : base(parent)
        //    {
        //        this.parent = parent;
        //    }


        //    /// <summary>
        //    /// Set the id parameter
        //    /// </summary>
        //    /// <param name=data>string</param>
        //    /// <returns>CardBuilder</returns>
        //    public CardBuilder1<TBLDR> id(string data)
        //    {
        //        this.properties[CustomerVaultConstants.id] = data;
        //        return this;
        //    }


        //    /// <summary>
        //    /// Set the cardNum parameter
        //    /// </summary>
        //    /// <param name=data>string</param>
        //    /// <returns>CardBuilder</returns>
        //    public CardBuilder1<TBLDR> cardNum(string data)
        //    {
        //        this.properties[CustomerVaultConstants.cardNum] = data;
        //        return this;
        //    }

        //    /// <summary>
        //    /// Build an cardExpiry object within this authorization.
        //    /// </summary>
        //    /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder></returns>
        //    public CardExpiry.CardExpiryBuilder<CardBuilder1<TBLDR>> cardExpiry()
        //    {
        //        if (!this.properties.ContainsKey(CustomerVaultConstants.cardExpiry))
        //        {
        //            this.properties[CustomerVaultConstants.cardExpiry] = new CardExpiry.CardExpiryBuilder<CardBuilder1<TBLDR>>(this);
        //        }
        //        return this.properties[CustomerVaultConstants.cardExpiry] as CardExpiry.CardExpiryBuilder<CardBuilder1<TBLDR>>;
        //    }

        //    /// <summary>
        //    /// Set the nickName parameter
        //    /// </summary>
        //    /// <param name=data>string</param>
        //    /// <returns>CardBuilder</returns>
        //    public CardBuilder1<TBLDR> nickName(string data)
        //    {
        //        this.properties[CustomerVaultConstants.nickName] = data;
        //        return this;
        //    }

        //    /// <summary>
        //    /// Set the merchantRefNum parameter
        //    /// </summary>
        //    /// <param name=data>string</param>
        //    /// <returns>CardBuilder</returns>
        //    public CardBuilder1<TBLDR> merchantRefNum(string data)
        //    {
        //        this.properties[CustomerVaultConstants.merchantRefNum] = data;
        //        return this;
        //    }

        //    /// <summary>
        //    /// Set the holderName parameter
        //    /// </summary>
        //    /// <param name=data>string</param>
        //    /// <returns>CardBuilder</returns>
        //    public CardBuilder1<TBLDR> holderName(string data)
        //    {
        //        this.properties[CustomerVaultConstants.holderName] = data;
        //        return this;
        //    }

        //    /// <summary>
        //    /// Set the billingAddressId parameter
        //    /// </summary>
        //    /// <param name=data>string</param>
        //    /// <returns>CardBuilder</returns>
        //    public CardBuilder1<TBLDR> billingAddressId(string data)
        //    {
        //        this.properties[CustomerVaultConstants.billingAddressId] = data;
        //        return this;
        //    }

        //    /// <summary>
        //    /// Build an cardExpiry object within this authorization.
        //    /// </summary>
        //    /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder></returns>
        //    public BillingAddress.BillingAddressBuilder<CardBuilder1<TBLDR>> billingAddress()
        //    {
        //        if (!this.properties.ContainsKey(CustomerVaultConstants.billingAddress))
        //        {
        //            this.properties[CustomerVaultConstants.billingAddress] = new BillingAddress.BillingAddressBuilder<CardBuilder1<TBLDR>>(this);
        //        }
        //        return this.properties[CustomerVaultConstants.billingAddress] as BillingAddress.BillingAddressBuilder<CardBuilder1<TBLDR>>;
        //    }
        //}


    }
}
