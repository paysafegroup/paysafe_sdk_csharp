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
    public class BillingAddress : AddressDetails
    {

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>(addressFieldTypes);

        public BillingAddress(Dictionary<string, object> properties)
            : base(fieldTypes, properties)
        {
        }


        /// <summary>
        /// BillingAddressBuilder<typeparam name="TBLDR"></typeparam> will allow a BillingAddress to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class BillingAddressBuilder<TBLDR> : NestedJSONBuilder<BillingAddress, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the BillingDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public BillingAddressBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the nickName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> nickName(string data)
            {
                this.properties[CustomerVaultConstants.nickName] = data;
                return this;
            }

            /// <summary>
            /// Set the street
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> street(string data)
            {
                this.properties[CustomerVaultConstants.street] = data;
                return this;
            }

            /// <summary>
            /// Set the street2
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> street2(string data)
            {
                this.properties[CustomerVaultConstants.street2] = data;
                return this;
            }

            /// <summary>
            /// Set the city
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> city(string data)
            {
                this.properties[CustomerVaultConstants.city] = data;
                return this;
            }

            /// <summary>
            /// Set the state
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> state(string data)
            {
                this.properties[CustomerVaultConstants.state] = data;
                return this;
            }

            /// <summary>
            /// Set the country
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> country(string data)
            {
                this.properties[CustomerVaultConstants.country] = data;
                return this;
            }

            /// <summary>
            /// Set the zip
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> zip(string data)
            {
                this.properties[CustomerVaultConstants.zip] = data;
                return this;
            }

            /// <summary>
            /// Set the phone
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingAddressBuilder<TBLDR></returns>
            public BillingAddressBuilder<TBLDR> phone(string data)
            {
                this.properties[CustomerVaultConstants.phone] = data;
                return this;
            }
        }
    }
}
