
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
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
            {ThreeDSecureV2Constants.paymentToken, STRING_TYPE},
            {ThreeDSecureV2Constants.cardNum, STRING_TYPE},
            {ThreeDSecureV2Constants.cardBin, STRING_TYPE},
            {ThreeDSecureV2Constants.type, ThreeDSecureV2Constants.enumType},
            {ThreeDSecureV2Constants.lastDigits, STRING_TYPE},
            {ThreeDSecureV2Constants.cardExpiry, typeof(CardExpiry)},
            {ThreeDSecureV2Constants.holderName, STRING_TYPE},
        };
         
        /// <summary>
        /// Get the payment token
        /// </summary>
        /// <returns>string</returns>
        public string paymentToken()
        {
            return this.getProperty(ThreeDSecureV2Constants.paymentToken);
        }

        /// <summary>
        /// Set the payment token
        /// </summary>
        /// <param name=data>string</param>
        public void paymentToken(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.paymentToken, data);
        }

        /// <summary>
        /// Get the card number
        /// </summary>
        /// <returns>string</returns>
        public string cardNum()
        {
            return this.getProperty(ThreeDSecureV2Constants.cardNum);
        }

        /// <summary>
        /// Set the card number
        /// </summary>
        /// <param name=data>string</param>
        public void cardNum(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.cardNum, data);
        }

        /// <summary>
        /// Get the card Bin
        /// </summary>
        /// <returns>string</returns>
        public string cardBin()
        {
            return this.getProperty(ThreeDSecureV2Constants.cardBin);
        }

        /// <summary>
        /// Set the card Bin
        /// </summary>
        /// <param name=data>string</param>
        public void cardBin(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.cardBin, data);
        }

        /// <summary>
        /// Get the card's type
        /// </summary>
        /// <returns>string</returns>
        public string type()
        {
            return this.getProperty(ThreeDSecureV2Constants.type);
        }

        /// <summary>
        /// Set the card's type
        /// </summary>
        /// <param name=data>string</param>
        public void type(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.type, data);
        }

        /// <summary>
        /// Get the card's last digits
        /// </summary>
        /// <returns>string</returns>
        public string lastDigits()
        {
            return this.getProperty(ThreeDSecureV2Constants.lastDigits);
        }

        /// <summary>
        /// Set the card's last digits
        /// </summary>
        /// <param name=data>string</param>
        public void lastDigits(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.lastDigits, data);
        }

        /// <summary>
        /// Get the card expiry
        /// </summary>
        /// <returns>CardExpiry</returns>
        public CardExpiry cardExpiry()
        {
            return this.getProperty(ThreeDSecureV2Constants.cardExpiry);
        }

        /// <summary>
        /// Set the card expiry
        /// </summary>
        /// <param name=data>CardExpiry</param>
        public void cardExpiry(CardExpiry data)
        {
            this.setProperty(ThreeDSecureV2Constants.cardExpiry, data);
        }

        /// <summary>
        /// Get the card holder name 
        /// </summary>
        /// <returns>string</returns>
        public string holderName()
        {
            return this.getProperty(ThreeDSecureV2Constants.holderName);
        }

        /// <summary>
        /// Set the card holder name
        /// </summary>
        /// <param name=data>string</param>
        public void holderName(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.holderName, data);
        }

        /// <summary>
        /// CardBuilder<typeparam name="TBLDR"></typeparam> will allow an card to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
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
                this.properties[ThreeDSecureV2Constants.paymentToken] = data;
                return this;
            }

            /// <summary>
            /// Set the card number
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cardNum(string data)
            {
                this.properties[ThreeDSecureV2Constants.cardNum] = data;
                return this;
            }

            /// <summary>
            /// Set the card Bin
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> cardBin(string data)
            {
                this.properties[ThreeDSecureV2Constants.cardBin] = data;
                return this;
            }

            /// <summary>
            /// Set the card's type
            /// </summary>
            /// <param name=CardPaparam>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> type(string data)
            {
                this.properties[ThreeDSecureV2Constants.type] = data;
                return this;
            }

            /// <summary>
            /// Set the card's last digits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> lastDigits(string data)
            {
                this.properties[ThreeDSecureV2Constants.lastDigits] = data;
                return this;
            }

            /// <summary>
            /// Build a card expiry within this card.
            /// </summary>
            /// <returns>CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>></returns>
            public CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>> cardExpiry()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.cardExpiry))
                {
                    this.properties[ThreeDSecureV2Constants.cardExpiry] = new CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>>(this);
                }
                return this.properties[ThreeDSecureV2Constants.cardExpiry] as CardExpiry.CardExpiryBuilder<CardBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set the card Holder name 
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardBuilder<TBLDR></returns>
            public CardBuilder<TBLDR> holderName(string data)
            {
                this.properties[ThreeDSecureV2Constants.holderName] = data;
                return this;
            }

        }
    }
}
