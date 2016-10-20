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

namespace Paysafe.DirectDebit
{
    //Created by Manjiri.Bankar on 03.05.2016. This is ShippingDetails class.
    public class ShippingDetails : AddressDetails
    {
        /// <summary>
        /// Initialize the ShippingDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public ShippingDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>(addressFieldTypes)
        {
            {DirectDebitConstants.recipientName, STRING_TYPE},
            {DirectDebitConstants.carrier, DirectDebitConstants.enumCarrier},
            {DirectDebitConstants.shipMethod, DirectDebitConstants.enumShipMethod}
        };

        /// <summary>
        /// Get the recipientName
        /// </summary>
        /// <returns>string</returns>
        public string recipientName()
        {
            return this.getProperty(DirectDebitConstants.recipientName);
        }

        /// <summary>
        /// Set the recipientName
        /// </summary>
        /// <returns>void</returns>
        public void recipientName(string data)
        {
            this.setProperty(DirectDebitConstants.recipientName, data);
        }

        /// <summary>
        /// Get the carrier
        /// </summary>
        /// <returns>List</returns>
        public List<string> carrier()
        {
            return this.getProperty(DirectDebitConstants.carrier);
        }

        /// <summary>
        /// Set the carrier
        /// </summary>
        /// <returns>void</returns>
        public void carrier(string data)
        {
            this.setProperty(DirectDebitConstants.carrier, data);
        }

        /// <summary>
        /// Get the shipMethod
        /// </summary>
        /// <returns>string</returns>
        public string shipMethod()
        {
            return this.getProperty(DirectDebitConstants.shipMethod);
        }

        /// <summary>
        /// Set the shipMethod
        /// </summary>
        /// <returns>void</returns>
        public void shipMethod(string data)
        {
            this.setProperty(DirectDebitConstants.shipMethod, data);
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
            /// Initialize the ShippingDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public ShippingDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the recipientName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> recipientName(string data)
            {
                this.properties[DirectDebitConstants.recipientName] = data;
                return this;
            }

            /// <summary>
            /// Set the street
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> street(string data)
            {
                this.properties[DirectDebitConstants.street] = data;
                return this;
            }

            /// <summary>
            /// Set the street2
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> street2(string data)
            {
                this.properties[DirectDebitConstants.street2] = data;
                return this;
            }

            /// <summary>
            /// Set the city
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> city(string data)
            {
                this.properties[DirectDebitConstants.city] = data;
                return this;
            }

            /// <summary>
            /// Set the state
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> state(string data)
            {
                this.properties[DirectDebitConstants.state] = data;
                return this;
            }

            /// <summary>
            /// Set the country
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> country(string data)
            {
                this.properties[DirectDebitConstants.country] = data;
                return this;
            }

            /// <summary>
            /// Set the zip
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> zip(string data)
            {
                this.properties[DirectDebitConstants.zip] = data;
                return this;
            }

            /// <summary>
            /// Set the phone
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> phone(string data)
            {
                this.properties[DirectDebitConstants.phone] = data;
                return this;
            }

            /// <summary>
            /// Set the carrier
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> carrier(string data)
            {
                this.properties[DirectDebitConstants.carrier] = data;
                return this;
            }

            /// <summary>
            /// Set the shipMethod
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ShippingDetailsBuilder<TBLDR></returns>
            public ShippingDetailsBuilder<TBLDR> shipMethod(string data)
            {
                this.properties[DirectDebitConstants.shipMethod] = data;
                return this;
            }
        }
    }
}
