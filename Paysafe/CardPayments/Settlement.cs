﻿/*
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
    public class Settlement : JSONObject
    {
        /// <summary>
        /// Initialize the Settlement object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Settlement(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        /// <summary>
        /// Initialize a settlement object with an id
        /// </summary>
        /// <param name="id"></param>
        public Settlement(String id)
            : base(fieldTypes)
        {
            this.id(id);
        }

        /// <summary>
        /// Gets the array key to access the array of settlements
        /// </summary>
        /// <returns>The key to be checked in the returning JSON</returns>
        public static string getPageableArrayKey()
        {
            return CardPaymentsConstants.settlements;
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
            {CardPaymentsConstants.id, STRING_TYPE},
            {CardPaymentsConstants.merchantRefNum, STRING_TYPE},
            {CardPaymentsConstants.amount, INT_TYPE},
            {CardPaymentsConstants.availableToRefund, INT_TYPE},
            {CardPaymentsConstants.childAccountNum, STRING_TYPE},
            {CardPaymentsConstants.txnTime, typeof(System.DateTime)},
            {CardPaymentsConstants.dupCheck, BOOL_TYPE},
            {CardPaymentsConstants.status, CardPaymentsConstants.enumStatus},
            {CardPaymentsConstants.riskReasonCode, typeof(List<int>)},
            {CardPaymentsConstants.acquirerResponse, typeof(AcquirerResponse)},
            {CardPaymentsConstants.error, typeof(OptError)},
            {CardPaymentsConstants.links, typeof(List<Link>)},
            {CardPaymentsConstants.authorizationId, STRING_TYPE},
            {CardPaymentsConstants.airlineTravelDetails, typeof(AirlineTravelDetails) }
         };


        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(CardPaymentsConstants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(string data)
        {
            this.setProperty(CardPaymentsConstants.id, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>string</returns>
        public string merchantRefNum()
        {
            return this.getProperty(CardPaymentsConstants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <returns>void</returns>
        public void merchantRefNum(string data)
        {
            this.setProperty(CardPaymentsConstants.merchantRefNum, data);
        }

        /// <summary>
        /// Get the amount
        /// </summary>
        /// <returns>int</returns>
        public int amount()
        {
            return this.getProperty(CardPaymentsConstants.amount);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <returns>void</returns>
        public void amount(int data)
        {
            this.setProperty(CardPaymentsConstants.amount, data);
        }

        /// <summary>
        /// Get the availableToRefund
        /// </summary>
        /// <returns>int</returns>
        public int availableToRefund()
        {
            return this.getProperty(CardPaymentsConstants.availableToRefund);
        }

        /// <summary>
        /// Set the availableToRefund
        /// </summary>
        /// <returns>void</returns>
        public void availableToRefund(int data)
        {
            this.setProperty(CardPaymentsConstants.availableToRefund, data);
        }

        /// <summary>
        /// Get the childAccountNum
        /// </summary>
        /// <returns>string</returns>
        public string childAccountNum()
        {
            return this.getProperty(CardPaymentsConstants.childAccountNum);
        }

        /// <summary>
        /// Set the childAccountNum
        /// </summary>
        /// <returns>void</returns>
        public void childAccountNum(string data)
        {
            this.setProperty(CardPaymentsConstants.childAccountNum, data);
        }

        /// <summary>
        /// Get the txnTime
        /// </summary>
        /// <returns>System.DateTime</returns>
        public System.DateTime txnTime()
        {
            return this.getProperty(CardPaymentsConstants.txnTime);
        }

        /// <summary>
        /// Set the txnTime
        /// </summary>
        /// <returns>void</returns>
        public void txnTime(System.DateTime data)
        {
            this.setProperty(CardPaymentsConstants.txnTime, data);
        }

        /// <summary>
        /// Get the dupCheck
        /// </summary>
        /// <returns>bool</returns>
        public bool dupCheck()
        {
            return this.getProperty(CardPaymentsConstants.dupCheck);
        }

        /// <summary>
        /// Set the dupCheck
        /// </summary>
        /// <returns>void</returns>
        public void dupCheck(bool data)
        {
            this.setProperty(CardPaymentsConstants.dupCheck, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>List</returns>
        public string status()
        {
            return this.getProperty(CardPaymentsConstants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <returns>void</returns>
        public void status(string data)
        {
            this.setProperty(CardPaymentsConstants.status, data);
        }

        /// <summary>
        /// Get the riskReasonCode
        /// </summary>
        /// <returns>List<int></returns>
        public List<int> riskReasonCode()
        {
            return this.getProperty(CardPaymentsConstants.riskReasonCode);
        }

        /// <summary>
        /// Set the riskReasonCode
        /// </summary>
        /// <returns>void</returns>
        public void riskReasonCode(List<int> data)
        {
            this.setProperty(CardPaymentsConstants.riskReasonCode, data);
        }

        /// <summary>
        /// Get the acquireResponse
        /// </summary>
        /// <returns>AcquirerResponse</returns>
        public AcquirerResponse acquireResponse()
        {
            return this.getProperty(CardPaymentsConstants.acquirerResponse);
        }

        /// <summary>
        /// Set the acquireResponse
        /// </summary>
        /// <returns>void</returns>
        public void acquireResponse(AcquirerResponse data)
        {
            this.setProperty(CardPaymentsConstants.acquirerResponse, data);
        }

        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>OptError</returns>
        public OptError error()
        {
            return this.getProperty(CardPaymentsConstants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <returns>void</returns>
        public void error(OptError data)
        {
            this.setProperty(CardPaymentsConstants.error, data);
        }

        /// <summary>
        /// Get the links
        /// </summary>
        /// <returns>List<Link></returns>
        public List<Link> links()
        {
            return this.getProperty(CardPaymentsConstants.links);
        }

        /// <summary>
        /// Set the links
        /// </summary>
        /// <returns>void</returns>
        public void links(List<Link> data)
        {
            this.setProperty(CardPaymentsConstants.links, data);
        }

        /// <summary>
        /// Get the authorizationId
        /// </summary>
        /// <returns>string</returns>
        public string authorizationId()
        {
            return this.getProperty(CardPaymentsConstants.authorizationId);
        }

        /// <summary>
        /// Set the authorizationId
        /// </summary>
        /// <returns>void</returns>
        public void authorizationId(string data)
        {
            this.setProperty(CardPaymentsConstants.authorizationId, data);
        }

        /// <summary>
        /// Get the airline travel details
        /// </summary>
        /// <returns>AirlineTravelDetails</returns>
        public AirlineTravelDetails airlineTravelDetails()
        {
            return getProperty(GlobalConstants.airlineTravelDetails);
        }

        /// <summary>
        /// Set the airline travel details
        /// </summary>
        /// <returns>void</returns>
        public void airlineTravelDetails(AirlineTravelDetails data)
        {
            setProperty(GlobalConstants.airlineTravelDetails, data);
        }


        /// <summary>
        /// Get a new SettlementBuilder
        /// </summary>
        /// <returns>SettlementBuilder</returns>
        public static SettlementBuilder Builder()
        {
            return new SettlementBuilder();
        }

        /// <summary>
        /// SettlementBuilder will allow an Settlement to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Authorization object
        /// </summary>
        public class SettlementBuilder : BaseJSONBuilder<Settlement>
        {
            /// <summary>
            /// Set the id
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SettlementBuilder</returns>
            public SettlementBuilder id(string data)
            {
                this.properties[CardPaymentsConstants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SettlementBuilder</returns>
            public SettlementBuilder merchantRefNum(string data)
            {
                this.properties[CardPaymentsConstants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the amount
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>SettlementBuilder</returns>
            public SettlementBuilder amount(int data)
            {
                this.properties[CardPaymentsConstants.amount] = data;
                return this;
            }

            /// <summary>
            /// Set the dupCheck
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>SettlementBuilder</returns>
            public SettlementBuilder dupCheck(bool data)
            {
                this.properties[CardPaymentsConstants.dupCheck] = data;
                return this;
            }

            /// <summary>
            /// Set the authorizationId
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>SettlementBuilder</returns>
            public SettlementBuilder authorizationId(string data)
            {
                this.properties[CardPaymentsConstants.authorizationId] = data;
                return this;
            }

            /// <summary>
            /// Build an AirlineTravelDetails object within this settlement.
            /// </summary>
            /// <returns>AirlineTravelDetails.AirlineTravelDetailsBuilder<SettlementBuilder></returns>
            public AirlineTravelDetails.AirlineTravelDetailsBuilder<SettlementBuilder> airlineTravelDetails()
            {
                if (!properties.ContainsKey(GlobalConstants.airlineTravelDetails))
                {
                    properties[GlobalConstants.airlineTravelDetails] = new AirlineTravelDetails.AirlineTravelDetailsBuilder<SettlementBuilder>(this);
                }
                return properties[GlobalConstants.airlineTravelDetails] as AirlineTravelDetails.AirlineTravelDetailsBuilder<SettlementBuilder>;
            }
        }
    }
}
