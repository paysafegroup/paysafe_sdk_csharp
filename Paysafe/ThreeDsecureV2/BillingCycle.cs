using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class BillingCycle : JSONObject
    {
        /// <summary>
        /// Initialize the BillingCycle object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public BillingCycle(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }
        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
             {ThreeDSecureV2Constants.endDate, STRING_TYPE},
             {ThreeDSecureV2Constants.frequency, INT_TYPE}
         };

        /// <summary>
        /// Get the endDate
        /// </summary>
        /// <returns>string</returns>
        public string endDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.endDate);
        }

        /// <summary>
        /// Set the endDate
        /// </summary>
        /// <returns>void</returns>
        public void endDate(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.endDate, data);
        }

        /// <summary>
        /// Get the frequency
        /// </summary>
        /// <returns>int</returns>
        public int frequency()
        {
            return this.getProperty(ThreeDSecureV2Constants.frequency);
        }

        /// <summary>
        /// Set the frequency
        /// </summary>
        /// <returns>void</returns>
        public void frequency(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.frequency, data);
        }

        /// <summary>
        /// BillingCycleBuilder<typeparam name="TBLDR"></typeparam> will allow a BillingCycle to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class BillingCycleBuilder<TBLDR> : NestedJSONBuilder<BillingCycle, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the BillingCycleBuilder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public BillingCycleBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the endDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingCycleBuilder<TBLDR></returns>
            public BillingCycleBuilder<TBLDR> endDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.endDate] = data;
                return this;
            }

            /// <summary>
            /// Set the frequency
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>BillingCycleBuilder<TBLDR></returns>
            public BillingCycleBuilder<TBLDR> frequency(int data)
            {
                this.properties[ThreeDSecureV2Constants.frequency] = data;
                return this;
            }
        }
    }
}
