using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paysafe.Common
{
    public abstract class AddressDetails: JSONObject
    {
        /// <summary>
        /// Initialize the BillingDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public AddressDetails(Dictionary<string, object> fieldTypes , Dictionary<string, object> properties = null) 
            : base(fieldTypes, properties)
        {

        }

        /// <summary>
        /// This object is used to validate any properties set within the object
        /// </summary>
        protected static Dictionary<string, object> addressFieldTypes = new Dictionary<string, object>
        {
            {CommonConstants.street, STRING_TYPE},
            {CommonConstants.street2, STRING_TYPE},
            {CommonConstants.city, STRING_TYPE},
            {CommonConstants.state, STRING_TYPE},
            {CommonConstants.country, STRING_TYPE},
            {CommonConstants.zip, STRING_TYPE},
            {CommonConstants.phone, STRING_TYPE}
        };

        /// <summary>
        /// Get the street
        /// </summary>
        /// <returns>string</returns>
        public string street()
        {
            return this.getProperty(CommonConstants.street);
        }

        /// <summary>
        /// Set the street
        /// </summary>
        /// <returns>void</returns>
        public void street(string data)
        {
            this.setProperty(CommonConstants.street, data);
        }

        /// <summary>
        /// Get the street2
        /// </summary>
        /// <returns>string</returns>
        public string street2()
        {
            return this.getProperty(CommonConstants.street2);
        }

        /// <summary>
        /// Set the street2
        /// </summary>
        /// <returns>void</returns>
        public void street2(string data)
        {
            this.setProperty(CommonConstants.street2, data);
        }

        /// <summary>
        /// Get the city
        /// </summary>
        /// <returns>string</returns>
        public string city()
        {
            return this.getProperty(CommonConstants.city);
        }

        /// <summary>
        /// Set the city
        /// </summary>
        /// <returns>void</returns>
        public void city(string data)
        {
            this.setProperty(CommonConstants.city, data);
        }

        /// <summary>
        /// Get the state
        /// </summary>
        /// <returns>string</returns>
        public string state()
        {
            return this.getProperty(CommonConstants.state);
        }

        /// <summary>
        /// Set the state
        /// </summary>
        /// <returns>void</returns>
        public void state(string data)
        {
            this.setProperty(CommonConstants.state, data);
        }

        /// <summary>
        /// Get the country
        /// </summary>
        /// <returns>string</returns>
        public string country()
        {
            return this.getProperty(CommonConstants.country);
        }

        /// <summary>
        /// Set the country
        /// </summary>
        /// <returns>void</returns>
        public void country(string data)
        {
            this.setProperty(CommonConstants.country, data);
        }

        /// <summary>
        /// Get the zip
        /// </summary>
        /// <returns>string</returns>
        public string zip()
        {
            return this.getProperty(CommonConstants.zip);
        }

        /// <summary>
        /// Set the zip
        /// </summary>
        /// <returns>void</returns>
        public void zip(string data)
        {
            this.setProperty(CommonConstants.zip, data);
        }

        /// <summary>
        /// Get the phone
        /// </summary>
        /// <returns>string</returns>
        public string phone()
        {
            return this.getProperty(CommonConstants.phone);
        }

        /// <summary>
        /// Set the phone
        /// </summary>
        /// <returns>void</returns>
        public void phone(string data)
        {
            this.setProperty(CommonConstants.phone, data);
        }
    }
}
