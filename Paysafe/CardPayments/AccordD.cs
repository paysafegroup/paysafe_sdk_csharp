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
    public class AccordD : JSONObject
    {
        /// <summary>
        /// Initialize the AccordD object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public AccordD(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CardPaymentsConstants.financingType, CardPaymentsConstants.enumFinancingType},
            {CardPaymentsConstants.plan, STRING_TYPE},
            {CardPaymentsConstants.gracePeriod, INT_TYPE},
            {CardPaymentsConstants.term, INT_TYPE}
        };

        /// <summary>
        /// Get the financingType
        /// </summary>
        /// <returns>string</returns>
        public string financingType()
        {
            return this.getProperty(CardPaymentsConstants.financingType);
        }

        /// <summary>
        /// Set the financingType
        /// </summary>
        /// <returns>void</returns>
        public void financingType(string data)
        {
            this.setProperty(CardPaymentsConstants.financingType, data);
        }

        /// <summary>
        /// Get the plan
        /// </summary>
        /// <returns>string</returns>
        public string plan()
        {
            return this.getProperty(CardPaymentsConstants.plan);
        }

        /// <summary>
        /// Set the plan
        /// </summary>
        /// <returns>void</returns>
        public void plan(string data)
        {
            this.setProperty(CardPaymentsConstants.plan, data);
        }

        /// <summary>
        /// Get the gracePeriod
        /// </summary>
        /// <returns>int</returns>
        public int gracePeriod()
        {
            return this.getProperty(CardPaymentsConstants.gracePeriod);
        }

        /// <summary>
        /// Set the gracePeriod
        /// </summary>
        /// <returns>void</returns>
        public void gracePeriod(int data)
        {
            this.setProperty(CardPaymentsConstants.gracePeriod, data);
        }

        /// <summary>
        /// Get the term
        /// </summary>
        /// <returns>int</returns>
        public int term()
        {
            return this.getProperty(CardPaymentsConstants.term);
        }

        /// <summary>
        /// Set the term
        /// </summary>
        /// <returns>void</returns>
        public void term(int data)
        {
            this.setProperty(CardPaymentsConstants.term, data);
        }

        /// <summary>
        /// AccordDBuilder<typeparam name="TBLDR"></typeparam> will allow a AccordD to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class AccordDBuilder<TBLDR> : NestedJSONBuilder<AccordD, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the AccordD builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public AccordDBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the financingType
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AccordDBuilder<TBLDR></returns>
            public AccordDBuilder<TBLDR> financingType(string data)
            {
                this.properties[CardPaymentsConstants.financingType] = data;
                return this;
            }

            /// <summary>
            /// Set the plan
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AccordDBuilder<TBLDR></returns>
            public AccordDBuilder<TBLDR> plan(string data)
            {
                this.properties[CardPaymentsConstants.plan] = data;
                return this;
            }

            /// <summary>
            /// Set the gracePeriod
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>AccordDBuilder<TBLDR></returns>
            public AccordDBuilder<TBLDR> gracePeriod(int data)
            {
                this.properties[CardPaymentsConstants.gracePeriod] = data;
                return this;
            }

            /// <summary>
            /// Set the term
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>AccordDBuilder<TBLDR></returns>
            public AccordDBuilder<TBLDR> term(int data)
            {
                this.properties[CardPaymentsConstants.term] = data;
                return this;
            }
        }
    }
}
