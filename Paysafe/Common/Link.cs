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
    public class Link: JSONObject
    {
        /// <summary>
        /// Initialize the Link object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Link(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
             {CommonConstants.rel, STRING_TYPE},
             {CommonConstants.href, URL_TYPE}
         };


        /// <summary>
        /// Get the rel
        /// </summary>
        /// <returns>string</returns>
        public string rel()
        {
            return this.getProperty(CommonConstants.rel);
        }

        /// <summary>
        /// Set the rel
        /// </summary>
        /// <returns>void</returns>
        public void rel(string data)
        {
            this.setProperty(CommonConstants.rel, data);
        }

        /// <summary>
        /// Get the href
        /// </summary>
        /// <returns>string</returns>
        public string href()
        {
            return this.getProperty(CommonConstants.href);
        }

        /// <summary>
        /// Set the href
        /// </summary>
        /// <returns>void</returns>
        public void href(string data)
        {
            this.setProperty(CommonConstants.href, data);
        }

    }
}
