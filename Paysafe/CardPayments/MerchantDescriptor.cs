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

namespace Paysafe.CardPayments
{

    public class MerchantDescriptor : JSONObject
    {
        /// <summary>
        /// Initialize the MerchantDescriptor object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public MerchantDescriptor(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
             {CardPaymentsConstants.dynamicDescriptor, STRING_TYPE},
             {CardPaymentsConstants.phone, STRING_TYPE}
         };

        /// <summary>
        /// Get the dynamicDescriptor
        /// </summary>
        /// <returns>string</returns>
        public string dynamicDescriptor()
        {
            return this.getProperty(CardPaymentsConstants.dynamicDescriptor);
        }

        /// <summary>
        /// Set the dynamicDescriptor
        /// </summary>
        /// <returns>void</returns>
        public void dynamicDescriptor(string data)
        {
            this.setProperty(CardPaymentsConstants.dynamicDescriptor, data);
        }

        /// <summary>
        /// Get the street
        /// </summary>
        /// <returns>string</returns>
        public string street()
        {
            return this.getProperty(CardPaymentsConstants.phone);
        }

        /// <summary>
        /// Set the zip
        /// </summary>
        /// <returns>void</returns>
        public void zip(string data)
        {
            this.setProperty(CardPaymentsConstants.phone, data);
        }

        /// <summary>
        /// MerchantDescriptorBuilder<typeparam name="TBLDR"></typeparam> will allow a MerchantDescriptor to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class MerchantDescriptorBuilder<TBLDR> : NestedJSONBuilder<MerchantDescriptor, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the MerchantDescriptor builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public MerchantDescriptorBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the dynamicDescriptor
            /// </summary>
            /// <param name=CardPayments.dynamicDescriptor>string</param>
            /// <returns>MerchantDescriptorBuilder<TBLDR></returns>
            public MerchantDescriptorBuilder<TBLDR> dynamicDescriptor(string data)
            {
                this.properties[CardPaymentsConstants.dynamicDescriptor] = data;
                return this;
            }


            /// <summary>
            /// Set the phone
            /// </summary>
            /// <param name=CardPayments.phone>string</param>
            /// <returns>MerchantDescriptorBuilder<TBLDR></returns>
            public MerchantDescriptorBuilder<TBLDR> phone(string data)
            {
                this.properties[CardPaymentsConstants.phone] = data;
                return this;
            }
        }
    }
}
