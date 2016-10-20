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

    public class MasterPass : JSONObject
    {
        /// <summary>
        /// Initialize the MasterPass object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public MasterPass(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
            {CardPaymentsConstants.payPassWalletIndicator, STRING_TYPE},
            {CardPaymentsConstants.authenticationMethod, STRING_TYPE},
            {CardPaymentsConstants.cardEnrollementMethod, STRING_TYPE},
            {CardPaymentsConstants.masterCardAssignedId, STRING_TYPE}
         };

        /// <summary>
        /// Get the payPassWalletIndicator
        /// </summary>
        /// <returns>string</returns>
        public string payPassWalletIndicator()
        {
            return this.getProperty(CardPaymentsConstants.payPassWalletIndicator);
        }

        /// <summary>
        /// Set the payPassWalletIndicator
        /// </summary>
        /// <returns>void</returns>
        public void payPassWalletIndicator(string data)
        {
            this.setProperty(CardPaymentsConstants.payPassWalletIndicator, data);
        }

        /// <summary>
        /// Get the authenticationMethod
        /// </summary>
        /// <returns>string</returns>
        public string authenticationMethod()
        {
            return this.getProperty(CardPaymentsConstants.authenticationMethod);
        }

        /// <summary>
        /// Set the authenticationMethod
        /// </summary>
        /// <returns>void</returns>
        public void authenticationMethod(string data)
        {
            this.setProperty(CardPaymentsConstants.authenticationMethod, data);
        }

        /// <summary>
        /// Get the cardEnrollementMethod
        /// </summary>
        /// <returns>string</returns>
        public string cardEnrollementMethod()
        {
            return this.getProperty(CardPaymentsConstants.cardEnrollementMethod);
        }

        /// <summary>
        /// Set the cardEnrollementMethod
        /// </summary>
        /// <returns>void</returns>
        public void cardEnrollementMethod(string data)
        {
            this.setProperty(CardPaymentsConstants.cardEnrollementMethod, data);
        }

        /// <summary>
        /// Get the masterCardAssignedId
        /// </summary>
        /// <returns>string</returns>
        public string masterCardAssignedIdr()
        {
            return this.getProperty(CardPaymentsConstants.masterCardAssignedId);
        }

        /// <summary>
        /// Set the masterCardAssignedId
        /// </summary>
        /// <returns>void</returns>
        public void masterCardAssignedId(string data)
        {
            this.setProperty(CardPaymentsConstants.masterCardAssignedId, data);
        }

    }
}
