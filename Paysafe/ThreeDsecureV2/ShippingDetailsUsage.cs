using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class ShippingDetailsUsage : JSONObject
    {
        /// <summary>
        /// Initialize the ShippingDetailsUsage object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public ShippingDetailsUsage(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.cardHolderNameMatch, BOOL_TYPE},
            {ThreeDSecureV2Constants.initialUsageDate, STRING_TYPE}, 
            {ThreeDSecureV2Constants.initialUsageRange, ThreeDSecureV2Constants.enumInitialUsageRange},

        };

        /// <summary>
        /// Get the cardHolderNameMatch
        /// </summary>
        /// <returns>Bool</returns>
        public bool cardHolderNameMatch()
        {
            return this.getProperty(ThreeDSecureV2Constants.cardHolderNameMatch);
        }

        /// <summary>
        /// Set the cardHolderNameMatch
        /// </summary>
        /// <returns>void</returns>
        public void cardHolderNameMatch(bool data)
        {
            this.setProperty(ThreeDSecureV2Constants.cardHolderNameMatch, data);
        }

        /// <summary>
        /// Get the initialUsageDate
        /// </summary>
        /// <returns>String</returns>
        public string initialUsageDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.initialUsageDate);
        }

        /// <summary>
        /// Set the initialUsageDate
        /// </summary>
        /// <returns>void</returns>
        public void initialUsageDate(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.initialUsageDate, data);
        }

        /// <summary>
        /// Get the initialUsageRange
        /// </summary>
        /// <returns>String</returns>
        public string initialUsageRange()
        {
            return this.getProperty(ThreeDSecureV2Constants.initialUsageRange);
        }

        /// <summary>
        /// Set the initialUsageRange
        /// </summary>
        /// <returns>void</returns>
        public void initialUsageRange(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.initialUsageRange, data);
        }

        /// <summary>
        /// ShippingDetailsUsageBuilder<typeparam name="TBLDR"></typeparam> will allow an ShippingDetailsUsage to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class ShippingDetailsUsageBuilder<TBLDR> : NestedJSONBuilder<ShippingDetailsUsage, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the ShippingDetailsUsage builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public ShippingDetailsUsageBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the cardHolderNameMatch
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>ShippingDetailsUsageBuilder<TBLDR></returns>
            public ShippingDetailsUsageBuilder<TBLDR> cardHolderNameMatch(bool data)
            {
                this.properties[ThreeDSecureV2Constants.cardHolderNameMatch] = data;
                return this;
            }

            /// <summary>
            /// Set the initialUsageDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsUsageBuilder<TBLDR></returns>
            public ShippingDetailsUsageBuilder<TBLDR> initialUsageDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.initialUsageDate] = data;
                return this;
            }

            /// <summary>
            /// Set the initialUsageRange
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsUsageBuilder<TBLDR></returns>
            public ShippingDetailsUsageBuilder<TBLDR> initialUsageRange(string data)
            {
                this.properties[ThreeDSecureV2Constants.initialUsageRange] = data;
                return this;
            }
        }

    }
}
