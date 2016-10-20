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
    //Created by Manjiri.Bankar on 03.05.2016. This is BillingDetails class.
    public class BillingDetails : AddressDetails
    {

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>(addressFieldTypes);

        public BillingDetails(Dictionary<string, object> properties)
            : base(fieldTypes, properties)
        {
        }


        /// <summary>
        /// BillingDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow a BillingDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class BillingDetailsBuilder<TBLDR> : NestedJSONBuilder<BillingDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the BillingDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public BillingDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the street
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> street(string data)
            {
                this.properties[DirectDebitConstants.street] = data;
                return this;
            }

            /// <summary>
            /// Set the street2
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> street2(string data)
            {
                this.properties[DirectDebitConstants.street2] = data;
                return this;
            }

            /// <summary>
            /// Set the city
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> city(string data)
            {
                this.properties[DirectDebitConstants.city] = data;
                return this;
            }

            /// <summary>
            /// Set the state
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> state(string data)
            {
                this.properties[DirectDebitConstants.state] = data;
                return this;
            }

            /// <summary>
            /// Set the country
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> country(string data)
            {
                this.properties[DirectDebitConstants.country] = data;
                return this;
            }

            /// <summary>
            /// Set the zip
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> zip(string data)
            {
                this.properties[DirectDebitConstants.zip] = data;
                return this;
            }

            /// <summary>
            /// Set the phone
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BillingDetailsBuilder<TBLDR></returns>
            public BillingDetailsBuilder<TBLDR> phone(string data)
            {
                this.properties[DirectDebitConstants.phone] = data;
                return this;
            }
        }
    }
}