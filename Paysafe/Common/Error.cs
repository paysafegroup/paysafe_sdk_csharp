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
    public class OptError: JSONObject
    {
        /// <summary>
        /// Initialize the Error object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public OptError(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
             {CommonConstants.code, STRING_TYPE},
             {CommonConstants.message, STRING_TYPE},
             {CommonConstants.details, typeof(List<string>)},
             {CommonConstants.fieldErrors, typeof(List<FieldError>)},
             {CommonConstants.links, typeof(List<Link>)}
         };

        /// <summary>
        /// Get the code
        /// </summary>
        /// <returns>string</returns>
        public string code()
        {
            return this.getProperty(CommonConstants.code);
        }

        /// <summary>
        /// Set the code
        /// </summary>
        /// <returns>void</returns>
        public void code(string data)
        {
            this.setProperty(CommonConstants.code, data);
        }

        /// <summary>
        /// Get the message
        /// </summary>
        /// <returns>string</returns>
        public string message()
        {
            return this.getProperty(CommonConstants.message);
        }

        /// <summary>
        /// Set the message
        /// </summary>
        /// <returns>void</returns>
        public void message(string data)
        {
            this.setProperty(CommonConstants.message, data);
        }

        /// <summary>
        /// Get the details
        /// </summary>
        /// <returns>Array</returns>
        public List<string> details()
        {
            return this.getProperty(CommonConstants.details);
        }

        /// <summary>
        /// Set the details
        /// </summary>
        /// <returns>Array of strings</returns>
        public void details(List<string> data)
        {
            this.setProperty(CommonConstants.details, data);
        }

        /// <summary>
        /// Get the fieldErrors
        /// </summary>
        /// <returns>array of strings</returns>
        public List<FieldError> fieldErrors()
        {
            return this.getProperty(CommonConstants.fieldErrors);
        }

        /// <summary>
        /// Set the fieldErrors
        /// </summary>
        /// <returns>void</returns>
        public void fieldErrors(Array data)
        {
            this.setProperty(CommonConstants.fieldErrors, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>Array of Paysafe.Common.Link</returns>
        public List<Link> links()
        {
            return this.getProperty(CommonConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(CommonConstants.links, data);
        }
    }
}
