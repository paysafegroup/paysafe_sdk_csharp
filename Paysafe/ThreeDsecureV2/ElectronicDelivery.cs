using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class ElectronicDelivery : JSONObject
    {

        /// <summary>
        /// Initialize the ElectronicDelivery object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public ElectronicDelivery(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.isElectronicDelivery, BOOL_TYPE},
            {ThreeDSecureV2Constants.email, STRING_TYPE}   
        };

        /// <summary>
        /// Get the isElectronicDelivery
        /// </summary>
        /// <returns>Bool</returns>
        public bool isElectronicDelivery()
        {
            return this.getProperty(ThreeDSecureV2Constants.isElectronicDelivery);
        }

        /// <summary>
        /// Set the isElectronicDelivery
        /// </summary>
        /// <returns>void</returns>
        public void isElectronicDelivery(bool data)
        {
            this.setProperty(ThreeDSecureV2Constants.isElectronicDelivery, data);
        }

        /// <summary>
        /// Get the email
        /// </summary>
        /// <returns>String</returns>
        public string email()
        {
            return this.getProperty(ThreeDSecureV2Constants.email);
        }

        /// <summary>
        /// Set the email
        /// </summary>
        /// <returns>void</returns>
        public void email(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.email, data);
        }

        /// <summary>
        /// ElectronicDeliveryBuilder<typeparam name="TBLDR"></typeparam> will allow an ElectronicDelivery to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class ElectronicDeliveryBuilder<TBLDR> : NestedJSONBuilder<ElectronicDelivery, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the ElectronicDelivery builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public ElectronicDeliveryBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the isElectronicDelivery
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>ElectronicDeliveryBuilder<TBLDR></returns>
            public ElectronicDeliveryBuilder<TBLDR> isElectronicDelivery(bool data)
            {
                this.properties[ThreeDSecureV2Constants.isElectronicDelivery] = data;
                return this;
            }

            /// <summary>
            /// Set the email
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ElectronicDeliveryBuilder<TBLDR></returns>
            public ElectronicDeliveryBuilder<TBLDR> email(string data)
            {
                this.properties[ThreeDSecureV2Constants.email] = data;
                return this;
            }
        }
    }
}
