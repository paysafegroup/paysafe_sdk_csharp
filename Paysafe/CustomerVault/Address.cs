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

namespace Paysafe.CustomerVault
{
    public class Address : AddressDetails
    {
        /// <summary>
        /// Initialize the Address object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Address(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>(addressFieldTypes)
        {
            {CustomerVaultConstants.id, STRING_TYPE},
            {CustomerVaultConstants.nickName, STRING_TYPE},
            {CustomerVaultConstants.status, CustomerVaultConstants.enumStatus},
            {CustomerVaultConstants.recipientName, STRING_TYPE},
            {CustomerVaultConstants.defaultShippingAddressIndicator, BOOL_TYPE},
            {CustomerVaultConstants.error, typeof(OptError)},
            {CustomerVaultConstants.links, typeof(List<Link>)},
            {CustomerVaultConstants.profileId, STRING_TYPE}
        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(CustomerVaultConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(string data)
        {
            this.setProperty(CustomerVaultConstants.id, data);
        }

        /// <summary>
        /// Get the nickName
        /// </summary>
        /// <returns>string</returns>
        public string nickName()
        {
            return this.getProperty(CustomerVaultConstants.nickName);
        }

        /// <summary>
        /// Set the nickName
        /// </summary>
        /// <returns>void</returns>
        public void nickName(string data)
        {
            this.setProperty(CustomerVaultConstants.nickName, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>string</returns>
        public string status()
        {
            return this.getProperty(CustomerVaultConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(string data)
        {
            this.setProperty(CustomerVaultConstants.status, data);
        }

        /// <summary>
        /// Get the recipientName
        /// </summary>
        /// <returns>string</returns>
        public string recipientName()
        {
            return this.getProperty(CustomerVaultConstants.recipientName);
        }

        /// <summary>
        /// Set the recipientName
        /// </summary>
        /// <returns>void</returns>
        public void recipientName(string data)
        {
            this.setProperty(CustomerVaultConstants.recipientName, data);
        }

        /// <summary>
        /// Get the defaultShippingAddressIndicator
        /// </summary>
        /// <returns>bool</returns>
        public bool defaultShippingAddressIndicator()
        {
            return this.getProperty(CustomerVaultConstants.defaultShippingAddressIndicator);
        }

        /// <summary>
        /// Set the defaultShippingAddressIndicator
        /// </summary>
        /// <returns>bool</returns>
        public void defaultShippingAddressIndicator(bool data)
        {
            this.setProperty(CustomerVaultConstants.defaultShippingAddressIndicator, data);
        }

        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
        public OptError error()
        {
            return this.getProperty(CustomerVaultConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(CustomerVaultConstants.error, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>List<Paysafe.Common.Link></returns>
        public List<Link> links()
        {
            return this.getProperty(CustomerVaultConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(CustomerVaultConstants.links, data);
        }

        /// <summary>
        /// Get the profileId
        /// </summary>
        /// <returns>string</returns>
        public string profileId()
        {
            return this.getProperty(CustomerVaultConstants.profileId);
        }

        /// <summary>
        /// Set the profileId
        /// </summary>
        /// <returns>void</returns>
        public void profileId(string data)
        {
            this.setProperty(CustomerVaultConstants.profileId, data);
        }

        public static AddressBuilder Builder()
        {
            return new AddressBuilder();
        }

        /// <summary>
        /// AddressBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Address object
        /// </summary>
        public class AddressBuilder : BaseJSONBuilder<Address>
        {
            /// <summary>
            /// Set the profileId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder id(string data)
            {
                this.properties[CustomerVaultConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the profileId parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder profileId(string data)
            {
                this.properties[CustomerVaultConstants.profileId] = data;
                return this;
            }

            /// <summary>
            /// Set the country parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder country(string data)
            {
                this.properties[CustomerVaultConstants.country] = data;
                return this;
            }

            /// <summary>
            /// Set the nickName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder nickName(string data)
            {
                this.properties[CustomerVaultConstants.nickName] = data;
                return this;
            }

            /// <summary>
            /// Set the street parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder street(string data)
            {
                this.properties[CustomerVaultConstants.street] = data;
                return this;
            }

            /// <summary>
            /// Set the street2 parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder street2(string data)
            {
                this.properties[CustomerVaultConstants.street2] = data;
                return this;
            }

            /// <summary>
            /// Set the city parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder city(string data)
            {
                this.properties[CustomerVaultConstants.city] = data;
                return this;
            }

            /// <summary>
            /// Set the state parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder state(string data)
            {
                this.properties[CustomerVaultConstants.state] = data;
                return this;
            }

            /// <summary>
            /// Set the zip parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder zip(string data)
            {
                this.properties[CustomerVaultConstants.zip] = data;
                return this;
            }

            /// <summary>
            /// Set the recipientName parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder recipientName(string data)
            {
                this.properties[CustomerVaultConstants.recipientName] = data;
                return this;
            }

            /// <summary>
            /// Set the phone parameter
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AddressBuilder</returns>
            public AddressBuilder phone(string data)
            {
                this.properties[CustomerVaultConstants.phone] = data;
                return this;
            }
        }
    }
}
