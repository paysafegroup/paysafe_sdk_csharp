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
            {CardPaymentsConstants.paymentToken, STRING_TYPE},
            {CardPaymentsConstants.cardNum, STRING_TYPE},
            {CardPaymentsConstants.type, STRING_TYPE},
            {CardPaymentsConstants.lastDigits, STRING_TYPE},
            {CardPaymentsConstants.cardExpiry, typeof(CardExpiry)},
            {CardPaymentsConstants.cvv, STRING_TYPE},
            {CardPaymentsConstants.track1, STRING_TYPE},
            {CardPaymentsConstants.track2, STRING_TYPE},
        };

        /// <summary>
        /// Get the payment token
        /// </summary>
        /// <returns>string</returns>
        public string paymentToken()
        {
            return this.getProperty(CardPaymentsConstants.paymentToken);
        }

        /// <summary>
        /// Set the payment token
        /// </summary>
        /// <param name=data>string</param>
        public void paymentToken(string data)
        {
            this.setProperty(CardPaymentsConstants.paymentToken, data);
        }

        /// <summary>
        /// Get the card number
        /// </summary>
        /// <returns>string</returns>
        public string cardNum()
        {
            return this.getProperty(CardPaymentsConstants.cardNum);
        }

        /// <summary>
        /// Set the card number
        /// </summary>
        /// <param name=data>string</param>
        public void cardNum(string data)
        {
            this.setProperty(CardPaymentsConstants.cardNum, data);
        }

        /// <summary>
        /// Get the card's type
        /// </summary>
        /// <returns>string</returns>
        public string type()
        {
            return this.getProperty(CardPaymentsConstants.type);
        }

        /// <summary>
        /// Set the card's type
        /// </summary>
        /// <param name=data>string</param>
        public void type(string data)
        {
            this.setProperty(CardPaymentsConstants.type, data);
        }

        /// <summary>
        /// Get the card's last digits
        /// </summary>
        /// <returns>string</returns>
        public string lastDigits()
        {
            return this.getProperty(CardPaymentsConstants.lastDigits);
        }

        /// <summary>
        /// Set the card's last digits
        /// </summary>
        /// <param name=data>string</param>
        public void lastDigits(string data)
        {
            this.setProperty(CardPaymentsConstants.lastDigits, data);
        }

        /// <summary>
        /// Get the card expiry
        /// </summary>
        /// <returns>CardExpiry</returns>
        public CardExpiry cardExpiry()
        {
            return this.getProperty(CardPaymentsConstants.cardExpiry);
        }

        /// <summary>
        /// Set the card expiry
        /// </summary>
        /// <param name=data>CardExpiry</param>
        public void cardExpiry(CardExpiry data)
        {
            this.setProperty(CardPaymentsConstants.cardExpiry, data);
        }

        /// <summary>
        /// Get the card cvv
        /// </summary>
        /// <returns>string</returns>
        public string cvv()
        {
            return this.getProperty(CardPaymentsConstants.cvv);
        }

        /// <summary>
        /// Set the card cvv
        /// </summary>
        /// <param name=data>string</param>
        public void cvv(string data)
        {
            this.setProperty(CardPaymentsConstants.cvv, data);
        }

        /// <summary>
        /// Get the track1 data
        /// </summary>
        /// <returns>string</returns>
        public string track1()
        {
            return this.getProperty(CardPaymentsConstants.track1);
        }

        /// <summary>
        /// Set the track1 data
        /// </summary>
        /// <param name=data>string</param>
        public void track1(string data)
        {
            this.setProperty(CardPaymentsConstants.track1, data);
        }

        /// <summary>
        /// Get the track2 data
        /// </summary>
        /// <returns>string</returns>
        public string track2()
        {
            return this.getProperty(CardPaymentsConstants.track1);
        }

        /// <summary>
        /// Set the track2 data
        /// </summary>
        /// <param name=data>string</param>
        public void track2(string data)
        {
            this.setProperty(CardPaymentsConstants.track2, data);
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
                this.properties[CardPaymentsConstants.paymentToken] = data;
                return this;
            }

            /// <summary>
            /// Set the card number
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cardNum(string data)
            {
                this.properties[CardPaymentsConstants.cardNum] = data;
                return this;
            }

            /// <summary>
            /// Set the card's type
            /// </summary>
            /// <param name=CardPaparam>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> type(string data)
            {
                this.properties[CardPaymentsConstants.type] = data;
                return this;
            }

            /// <summary>
            /// Set the card's last digits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> lastDigits(string data)
            {
                this.properties[CardPaymentsConstants.lastDigits] = data;
                return this;
            }

            /// <summary>
            /// Build a card expiry within this card.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>></returns>
            public CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>> cardExpiry()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.cardExpiry))
                {
                    this.properties[CardPaymentsConstants.cardExpiry] = new CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>>(this);
                }
                return this.properties[CardPaymentsConstants.cardExpiry] as CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set the card cvv
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cvv(string data)
            {
                this.properties[CardPaymentsConstants.cvv] = data;
                return this;
            }

            /// <summary>
            /// Set the track1 data
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> track1(string data)
            {
                this.properties[CardPaymentsConstants.track1] = data;
                return this;
            }

            /// <summary>
            /// Set the track2 data
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> track2(string data)
            {
                this.properties[CardPaymentsConstants.track2] = data;
                return this;
            }
        }
    }
}
