using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class PurchasedGiftCardDetails : JSONObject
    {
        /// <summary>
        /// Initialize the StoredCredential object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public PurchasedGiftCardDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
                {ThreeDSecureV2Constants.amount, LONG_TYPE}, 
                {ThreeDSecureV2Constants.count, INT_TYPE}, 
                {ThreeDSecureV2Constants.currency, STRING_TYPE}
        };
        /// <summary>
        /// Get the amount
        /// </summary>
        /// <returns>string</returns>
        public long amount()
        {
            return this.getProperty(ThreeDSecureV2Constants.amount);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <returns>void</returns>
        public void amount(long data)
        {
            this.setProperty(ThreeDSecureV2Constants.amount, data);
        }

        /// <summary>
        /// Get the count
        /// </summary>
        /// <returns>string</returns>
        public int count()
        {
            return this.getProperty(ThreeDSecureV2Constants.count);
        }

        /// <summary>
        /// Set the count
        /// </summary>
        /// <returns>void</returns>
        public void count(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.count, data);
        }

        /// <summary>
        /// Get the currency
        /// </summary>
        /// <returns>string</returns>
        public string currency()
        {
            return this.getProperty(ThreeDSecureV2Constants.currency);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <returns>void</returns>
        public void currency(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.currency, data);
        }

        /// <summary>
        /// PurchasedGiftCardDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow a PurchasedGiftCardDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class PurchasedGiftCardDetailsBuilder<TBLDR> : NestedJSONBuilder<PurchasedGiftCardDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the PurchasedGiftCardDetailsBuilder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public PurchasedGiftCardDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the amount
            /// </summary>
            /// <param name=data>long</param>
            /// <returns>PurchasedGiftCardDetailsBuilder<TBLDR></returns>
            public PurchasedGiftCardDetailsBuilder<TBLDR> amount(long data)
            {
                this.properties[ThreeDSecureV2Constants.amount] = data;
                return this;

            }

            /// <summary>
            /// Set the count
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>PurchasedGiftCardDetailsBuilder<TBLDR></returns>
            public PurchasedGiftCardDetailsBuilder<TBLDR> count(int data)
            {
                this.properties[ThreeDSecureV2Constants.count] = data;
                return this;
            }

            /// <summary>
            /// Set the currency
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PurchasedGiftCardDetailsBuilder<TBLDR></returns>
            public PurchasedGiftCardDetailsBuilder<TBLDR> currency(string data)
            {
                this.properties[ThreeDSecureV2Constants.currency] = data;
                return this;

            }
        }
    }
}
