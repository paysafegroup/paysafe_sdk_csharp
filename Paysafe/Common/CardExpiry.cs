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

namespace Paysafe.Common
{
    public class CardExpiry : Paysafe.Common.JSONObject
    {
        /// <summary>
        /// Initialize the CardExpiry object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public CardExpiry(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CommonConstants.month, INT_TYPE},
            {CommonConstants.year, INT_TYPE}
        };

        /// <summary>
        /// Get the month
        /// </summary>
        /// <returns>int</returns>
        public int month()
        {
            return this.getProperty(CommonConstants.month);
        }

        /// <summary>
        /// Set the month
        /// </summary>
        /// <returns>void</returns>
        public void month(int data)
        {
            this.setProperty(CommonConstants.month, data);
        }

        /// <summary>
        /// Get the year
        /// </summary>
        /// <returns>int</returns>
        public int year()
        {
            return this.getProperty(CommonConstants.year);
        }

        /// <summary>
        /// Set the year
        /// </summary>
        /// <returns>void</returns>
        public void year(int data)
        {
            this.setProperty(CommonConstants.year, data);
        }

        /// <summary>
        /// CardExpiryBuilder<typeparam name="TBLDR"></typeparam> will allow a CardExpiry to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class CardExpiryBuilder<TBLDR> : NestedJSONBuilder<CardExpiry, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the CardExpiry builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public CardExpiryBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the month
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>CardExpiryBuilder<TBLDR></returns>
            public CardExpiryBuilder<TBLDR> month(int data)
            {
                this.properties[CommonConstants.month] = data;
                return this;
            }

            /// <summary>
            /// Set the year
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>CardExpiryBuilder<TBLDR></returns>
            public CardExpiryBuilder<TBLDR> year(int data)
            {
                this.properties[CommonConstants.year] = data;
                return this;
            }
        }
    }
}
