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
    public class VisaAdditionalAuthData : JSONObject
    {
        /// <summary>
        /// Initialize the VisaAdditionalAuthData object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public VisaAdditionalAuthData(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {CardPaymentsConstants.recipientDateOfBirth, typeof(RecipientDateOfBirth)},
            {CardPaymentsConstants.recipientZip, STRING_TYPE},
            {CardPaymentsConstants.recipientLastName, STRING_TYPE},
            {CardPaymentsConstants.recipientAccountNumber, STRING_TYPE}
        };

        /// <summary>
        /// Get the recipientDateOfBirth
        /// </summary>
        /// <returns>string</returns>
        public string recipientDateOfBirth()
        {
            return this.getProperty(CardPaymentsConstants.recipientDateOfBirth);
        }

        /// <summary>
        /// Set the recipientDateOfBirth
        /// </summary>
        /// <returns>void</returns>
        public void recipientDateOfBirth(string data)
        {
            this.setProperty(CardPaymentsConstants.recipientDateOfBirth, data);
        }

        /// <summary>
        /// Get the recipientZip
        /// </summary>
        /// <returns>string</returns>
        public string recipientZip()
        {
            return this.getProperty(CardPaymentsConstants.recipientZip);
        }

        /// <summary>
        /// Set the recipientZip
        /// </summary>
        /// <returns>void</returns>
        public void recipientZip(string data)
        {
            this.setProperty(CardPaymentsConstants.recipientZip, data);
        }

        /// <summary>
        /// Get the recipientLastName
        /// </summary>
        /// <returns>string</returns>
        public string recipientLastName()
        {
            return this.getProperty(CardPaymentsConstants.recipientLastName);
        }

        /// <summary>
        /// Set the recipientLastName
        /// </summary>
        /// <returns>void</returns>
        public void recipientLastName(string data)
        {
            this.setProperty(CardPaymentsConstants.recipientLastName, data);
        }

        /// <summary>
        /// Get the recipientAccountNumber
        /// </summary>
        /// <returns>string</returns>
        public string recipientAccountNumbere()
        {
            return this.getProperty(CardPaymentsConstants.recipientAccountNumber);
        }

        /// <summary>
        /// Set the recipientAccountNumber
        /// </summary>
        /// <returns>void</returns>
        public void recipientAccountNumber(string data)
        {
            this.setProperty(CardPaymentsConstants.recipientAccountNumber, data);
        }
    }
}
