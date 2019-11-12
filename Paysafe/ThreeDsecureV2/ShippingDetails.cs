using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;


namespace Paysafe.ThreeDsecureV2
{
    public class ShippingDetails : JSONObject
    {
        /// <summary>
        /// Initialize the ShippingDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public ShippingDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }
        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
             {ThreeDSecureV2Constants.shipMethod, ThreeDSecureV2Constants.enumShipMethod},
             {ThreeDSecureV2Constants.street, STRING_TYPE},
             {ThreeDSecureV2Constants.street2, STRING_TYPE},
             {ThreeDSecureV2Constants.city, STRING_TYPE},
             {ThreeDSecureV2Constants.state, STRING_TYPE},
             {ThreeDSecureV2Constants.country, ThreeDSecureV2Constants.enumCountry},
             {ThreeDSecureV2Constants.zip, STRING_TYPE}

         };


        /// <summary>
        /// Get the shipMethod
        /// </summary>
        /// <returns>string</returns>
        public string shipMethod()
        {
            return this.getProperty(ThreeDSecureV2Constants.shipMethod);
        }

        /// <summary>
        /// Set the shipMethod
        /// </summary>
        /// <returns>void</returns>
        public void shipMethod(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.shipMethod, data);
        }


        /// <summary>
        /// Get the street
        /// </summary>
        /// <returns>string</returns>
        public string street()
        {
            return this.getProperty(ThreeDSecureV2Constants.street);
        }

        /// <summary>
        /// Set the street
        /// </summary>
        /// <returns>void</returns>
        public void street(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.street, data);
        }

        /// <summary>
        /// Get the street2
        /// </summary>
        /// <returns>string</returns>
        public string street2()
        {
            return this.getProperty(ThreeDSecureV2Constants.street2);
        }

        /// <summary>
        /// Set the street2
        /// </summary>
        /// <returns>void</returns>
        public void street2(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.street2, data);
        }

        /// <summary>
        /// Get the city
        /// </summary>
        /// <returns>string</returns>
        public string city()
        {
            return this.getProperty(ThreeDSecureV2Constants.city);
        }

        /// <summary>
        /// Set the city
        /// </summary>
        /// <returns>void</returns>
        public void city(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.city, data);
        }

        /// <summary>
        /// Get the state
        /// </summary>
        /// <returns>string</returns>
        public string state()
        {
            return this.getProperty(ThreeDSecureV2Constants.state);
        }

        /// <summary>
        /// Set the state
        /// </summary>
        /// <returns>void</returns>
        public void state(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.state, data);
        }

        /// <summary>
        /// Get the country
        /// </summary>
        /// <returns>string</returns>
        public string country()
        {
            return this.getProperty(ThreeDSecureV2Constants.country);
        }

        /// <summary>
        /// Set the country
        /// </summary>
        /// <returns>void</returns>
        public void country(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.country, data);
        }

        /// <summary>
        /// Get the zip
        /// </summary>
        /// <returns>string</returns>
        public string zip()
        {
            return this.getProperty(ThreeDSecureV2Constants.zip);
        }

        /// <summary>
        /// Set the zip
        /// </summary>
        /// <returns>void</returns>
        public void zip(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.zip, data);
        }


        /// <summary>
        /// ShippingDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow a ShippingDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class ShippingDetailsBuilder<TBLDR> : NestedJSONBuilder<ShippingDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the ShippingDetailsBuilder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public ShippingDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the shipMethod
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> shipMethod(string data)
            {
                this.properties[ThreeDSecureV2Constants.shipMethod] = data;
                return this;
            }

            /// <summary>
            /// Set the street
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> street(string data)
            {
                this.properties[ThreeDSecureV2Constants.street] = data;
                return this;
            }

            /// <summary>
            /// Set the street2
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> street2(string data)
            {
                this.properties[ThreeDSecureV2Constants.street2] = data;
                return this;
            }

            /// <summary>
            /// Set the city
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> city(string data)
            {
                this.properties[ThreeDSecureV2Constants.city] = data;
                return this;
            }

            /// <summary>
            /// Set the state
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> state(string data)
            {
                this.properties[ThreeDSecureV2Constants.state] = data;
                return this;
            }

            /// <summary>
            /// Set the country
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> country(string data)
            {
                this.properties[ThreeDSecureV2Constants.country] = data;
                return this;
            }

            /// <summary>
            /// Set the zip
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> zip(string data)
            {
                this.properties[ThreeDSecureV2Constants.zip] = data;
                return this;
            }


        }
    }
}
