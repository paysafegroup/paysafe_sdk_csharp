using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;


namespace Paysafe.ThreeDsecureV2
{
    public class OrderItemDetails : JSONObject
    {
        /// <summary>
        /// Initialize the OrderItemDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public OrderItemDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }
        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.preOrderItemAvailabilityDate, STRING_TYPE}, 
             {ThreeDSecureV2Constants.preOrderPurchaseIndicator, ThreeDSecureV2Constants.enumPreOrderPurchaseIndicator},
             {ThreeDSecureV2Constants.reorderItemsIndicator, ThreeDSecureV2Constants.enumReorderItemsIndicator},
             {ThreeDSecureV2Constants.shippingIndicator, ThreeDSecureV2Constants.enumShippingIndicator}
        };

        /// <summary>
        /// Get the preOrderItemAvailabilityDate
        /// </summary>
        /// <returns>string</returns>
        public string preOrderItemAvailabilityDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.preOrderItemAvailabilityDate);
        }

        /// <summary>
        /// Set the preOrderItemAvailabilityDate
        /// </summary>
        /// <returns>void</returns>
        public void preOrderItemAvailabilityDate(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.preOrderItemAvailabilityDate, data);
        }

        /// <summary>
        /// Get the preOrderPurchaseIndicator
        /// </summary>
        /// <returns>string</returns>
        public string preOrderPurchaseIndicator()
        {
            return this.getProperty(ThreeDSecureV2Constants.preOrderPurchaseIndicator);
        }

        /// <summary>
        /// Set the preOrderPurchaseIndicator
        /// </summary>
        /// <returns>void</returns>
        public void preOrderPurchaseIndicator(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.preOrderPurchaseIndicator, data);
        }

        /// <summary>
        /// Get the reorderItemsIndicator
        /// </summary>
        /// <returns>string</returns>
        public string reorderItemsIndicator()
        {
            return this.getProperty(ThreeDSecureV2Constants.reorderItemsIndicator);
        }

        /// <summary>
        /// Set the reorderItemsIndicator
        /// </summary>
        /// <returns>void</returns>
        public void reorderItemsIndicator(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.reorderItemsIndicator, data);
        }

        /// <summary>
        /// Get the shippingIndicator
        /// </summary>
        /// <returns>string</returns>
        public string shippingIndicator()
        {
            return this.getProperty(ThreeDSecureV2Constants.shippingIndicator);
        }

        /// <summary>
        /// Set the shippingIndicator
        /// </summary>
        /// <returns>void</returns>
        public void shippingIndicator(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.shippingIndicator, data);
        }

        /// <summary>
        /// OrderItemDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow an OrderItemDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class OrderItemDetailsBuilder<TBLDR> : NestedJSONBuilder<OrderItemDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the OrderItemDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public OrderItemDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }
            /// <summary>
            /// Set the preOrderItemAvailabilityDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>OrderItemDetailsBuilder<TBLDR></returns>
            public OrderItemDetailsBuilder<TBLDR> preOrderItemAvailabilityDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.preOrderItemAvailabilityDate] = data;
                return this;
            }

            /// <summary>
            /// Set the preOrderPurchaseIndicator
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>OrderItemDetailsBuilder<TBLDR></returns>
            public OrderItemDetailsBuilder<TBLDR> preOrderPurchaseIndicator(string data)
            {
                this.properties[ThreeDSecureV2Constants.preOrderPurchaseIndicator] = data;
                return this;
            }
            /// <summary>
            /// Set the reorderItemsIndicator
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>OrderItemDetailsBuilder<TBLDR></returns>
            public OrderItemDetailsBuilder<TBLDR> reorderItemsIndicator(string data)
            {
                this.properties[ThreeDSecureV2Constants.reorderItemsIndicator] = data;
                return this;
            }
            /// <summary>
            /// Set the shippingIndicator
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>OrderItemDetailsBuilder<TBLDR></returns>
            public OrderItemDetailsBuilder<TBLDR> shippingIndicator(string data)
            {
                this.properties[ThreeDSecureV2Constants.shippingIndicator] = data;
                return this;
            }
        }
    }
}
