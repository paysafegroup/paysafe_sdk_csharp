using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class PaymentAccountDetails : JSONObject
    {
        /// <summary>
        /// Initialize the PaymentAccountDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public PaymentAccountDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.createdRange, ThreeDSecureV2Constants.enumCreatedRange},
            {ThreeDSecureV2Constants.createdDate, STRING_TYPE}
        };

        /// <summary>
        /// Get the createdRange
        /// </summary>
        /// <returns>string</returns>
        public string createdRange()
        {
            return this.getProperty(ThreeDSecureV2Constants.createdRange);
        }

        /// <summary>
        /// Set the createdRange
        /// </summary>
        /// <returns>void</returns>
        public void createdRange(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.createdRange, data);
        }

        /// <summary>
        /// Get the createdDate
        /// </summary>
        /// <returns>string</returns>
        public string createdDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.createdDate);
        }

        /// <summary>
        /// Set the createdDate
        /// </summary>
        /// <returns>void</returns>
        public void createdDate(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.createdDate, data);
        }


        /// <summary>
        /// PaymentAccountDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow a PaymentAccountDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class PaymentAccountDetailsBuilder<TBLDR> : NestedJSONBuilder<PaymentAccountDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the paymentAccountDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public PaymentAccountDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the createdRange
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardExpiryBuilder<TBLDR></returns>
            public PaymentAccountDetailsBuilder<TBLDR> createdRange(string data)
            {
                this.properties[ThreeDSecureV2Constants.createdRange] = data;
                return this;
            }


            /// <summary>
            /// Set the createdDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>CardExpiryBuilder<TBLDR></returns>
            public PaymentAccountDetailsBuilder <TBLDR> createdDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.createdDate] = data;
                return this;
            }
        }
    }
}