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

namespace Paysafe.ThreeDSecure
{
    //Created by Tushar.Sukhiya on 03.05.2016. This is Error Class.
    public class Error : JSONObject
    {
        /// <summary>
        /// Initialize the Error object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Error(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureConstants.code, STRING_TYPE},
            {ThreeDSecureConstants.message, STRING_TYPE}           
        };

        /// <summary>
        /// Get the code
        /// </summary>
        /// <returns>String</returns>
        public string code()
        {
            return this.getProperty(ThreeDSecureConstants.code);
        }

        /// <summary>
        /// Set the code
        /// </summary>
        /// <returns>void</returns>
        public void code(String data)
        {
            this.setProperty(ThreeDSecureConstants.code, data);
        }

        /// <summary>
        /// Get the message
        /// </summary>
        /// <returns>String</returns>
        public string message()
        {
            return this.getProperty(ThreeDSecureConstants.message);
        }

        /// <summary>
        /// Set the message
        /// </summary>
        /// <returns>void</returns>
        public void message(String data)
        {
            this.setProperty(ThreeDSecureConstants.message, data);
        }

        /// <summary>
        /// ErrorBuilder<typeparam name="TBLDR"></typeparam> will allow an Error to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class ErrorBuilder<TBLDR> : NestedJSONBuilder<Error, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Error builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public ErrorBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the code
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ErrorBuilder<TBLDR></returns>
            public ErrorBuilder<TBLDR> code(string data)
            {
                this.properties[ThreeDSecureConstants.code] = data;
                return this;
            }

            /// <summary>
            /// Set the message
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ErrorBuilder<TBLDR></returns>
            public ErrorBuilder<TBLDR> message(string data)
            {
                this.properties[ThreeDSecureConstants.message] = data;
                return this;
            }
        }
    }
}
