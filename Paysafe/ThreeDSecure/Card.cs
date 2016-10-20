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

namespace Paysafe.ThreeDSecure
{
    public class Card : JSONObject
    {

        /// <summary>
        /// Initialize the Card object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Card(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        /// <summary>
        /// This object is used to validate any properties set within the object
        /// </summary>
        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureConstants.paymentToken, STRING_TYPE},
            {ThreeDSecureConstants.cardNum, STRING_TYPE},
            {ThreeDSecureConstants.cardType, ThreeDSecureConstants.enumType},
            {ThreeDSecureConstants.lastDigits, STRING_TYPE},
            {ThreeDSecureConstants.cardExpiry, typeof(CardExpiry)},
            {ThreeDSecureConstants.cvv, STRING_TYPE},
            {ThreeDSecureConstants.track1, STRING_TYPE},
            {ThreeDSecureConstants.track2, STRING_TYPE},
        };

        /// <summary>
        /// Get the payment token
        /// </summary>
        /// <returns>string</returns>
        public string paymentToken()
        {
            return this.getProperty(ThreeDSecureConstants.paymentToken);
        }

        /// <summary>
        /// Set the payment token
        /// </summary>
        /// <param name=data>string</param>
        public void paymentToken(string data)
        {
            this.setProperty(ThreeDSecureConstants.paymentToken, data);
        }

        /// <summary>
        /// Get the card number
        /// </summary>
        /// <returns>string</returns>
        public string cardNum()
        {
            return this.getProperty(ThreeDSecureConstants.cardNum);
        }

        /// <summary>
        /// Set the card number
        /// </summary>
        /// <param name=data>string</param>
        public void cardNum(string data)
        {
            this.setProperty(ThreeDSecureConstants.cardNum, data);
        }

        /// <summary>
        /// Get the card's type
        /// </summary>
        /// <returns>string</returns>
        public string cardType()
        {
            return this.getProperty(ThreeDSecureConstants.cardType);
        }

        /// <summary>
        /// Set the card's type
        /// </summary>
        /// <param name=data>string</param>
        public void cardType(string data)
        {
            this.setProperty(ThreeDSecureConstants.cardType, data);
        }

        /// <summary>
        /// Get the card's last digits
        /// </summary>
        /// <returns>string</returns>
        public string lastDigits()
        {
            return this.getProperty(ThreeDSecureConstants.lastDigits);
        }

        /// <summary>
        /// Set the card's last digits
        /// </summary>
        /// <param name=data>string</param>
        public void lastDigits(string data)
        {
            this.setProperty(ThreeDSecureConstants.lastDigits, data);
        }

        /// <summary>
        /// Get the card expiry
        /// </summary>
        /// <returns>CardExpiry</returns>
        public CardExpiry cardExpiry()
        {
            return this.getProperty(ThreeDSecureConstants.cardExpiry);
        }

        /// <summary>
        /// Set the card expiry
        /// </summary>
        /// <param name=data>CardExpiry</param>
        public void cardExpiry(CardExpiry data)
        {
            this.setProperty(ThreeDSecureConstants.cardExpiry, data);
        }

        /// <summary>
        /// Get the card cvv
        /// </summary>
        /// <returns>string</returns>
        public string cvv()
        {
            return this.getProperty(ThreeDSecureConstants.cvv);
        }

        /// <summary>
        /// Set the card cvv
        /// </summary>
        /// <param name=data>string</param>
        public void cvv(string data)
        {
            this.setProperty(ThreeDSecureConstants.cvv, data);
        }

        /// <summary>
        /// Get the track1 data
        /// </summary>
        /// <returns>string</returns>
        public string track1()
        {
            return this.getProperty(ThreeDSecureConstants.track1);
        }

        /// <summary>
        /// Set the track1 data
        /// </summary>
        /// <param name=data>string</param>
        public void track1(string data)
        {
            this.setProperty(ThreeDSecureConstants.track1, data);
        }

        /// <summary>
        /// Get the track2 data
        /// </summary>
        /// <returns>string</returns>
        public string track2()
        {
            return this.getProperty(ThreeDSecureConstants.track1);
        }

        /// <summary>
        /// Set the track2 data
        /// </summary>
        /// <param name=data>string</param>
        public void track2(string data)
        {
            this.setProperty(ThreeDSecureConstants.track2, data);
        }

        /// <summary>
        /// CardBuilder<typeparam name="TBLDR"></typeparam> will allow an card to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class CardBuilder<TBLDR> : NestedJSONBuilder<Card, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Card builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public CardBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the payment token
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> paymentToken(string data)
            {
                this.properties[ThreeDSecureConstants.paymentToken] = data;
                return this;
            }

            /// <summary>
            /// Set the card number
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cardNum(string data)
            {
                this.properties[ThreeDSecureConstants.cardNum] = data;
                return this;
            }

            /// <summary>
            /// Set the card's type
            /// </summary>
            /// <param name=CardPaparam>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cardType(string data)
            {
                this.properties[ThreeDSecureConstants.cardType] = data;
                return this;
            }

            /// <summary>
            /// Set the card's last digits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> lastDigits(string data)
            {
                this.properties[ThreeDSecureConstants.lastDigits] = data;
                return this;
            }

            /// <summary>
            /// Build a card expiry within this card.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>></returns>
            public CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>> cardExpiry()
            {
                if (!this.properties.ContainsKey(ThreeDSecureConstants.cardExpiry))
                {
                    this.properties[ThreeDSecureConstants.cardExpiry] = new CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureConstants.cardExpiry] as CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set the card cvv
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cvv(string data)
            {
                this.properties[ThreeDSecureConstants.cvv] = data;
                return this;
            }

            /// <summary>
            /// Set the track1 data
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> track1(string data)
            {
                this.properties[ThreeDSecureConstants.track1] = data;
                return this;
            }

            /// <summary>
            /// Set the track2 data
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> track2(string data)
            {
                this.properties[ThreeDSecureConstants.track2] = data;
                return this;
            }
        }
    }
}
