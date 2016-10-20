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

    public class AcquirerResponse : JSONObject
    {
        /// <summary>
        /// Initialize the AcquirerResponse object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public AcquirerResponse(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
         {
             {CardPaymentsConstants.code, STRING_TYPE},
             {CardPaymentsConstants.responseCode, STRING_TYPE},
             {CardPaymentsConstants.avsCode, STRING_TYPE},
             {CardPaymentsConstants.balanceResponse, STRING_TYPE},
             {CardPaymentsConstants.batchNumber, STRING_TYPE},
             {CardPaymentsConstants.effectiveDate, STRING_TYPE},
             {CardPaymentsConstants.financingType, STRING_TYPE},
             {CardPaymentsConstants.gracePeriod, STRING_TYPE},
             {CardPaymentsConstants.plan, STRING_TYPE},
             {CardPaymentsConstants.seqNumber, STRING_TYPE},
             {CardPaymentsConstants.term, STRING_TYPE},
             {CardPaymentsConstants.terminalId, STRING_TYPE},
             {CardPaymentsConstants.responseId, STRING_TYPE},
             {CardPaymentsConstants.requestId, STRING_TYPE},
             {CardPaymentsConstants.description, STRING_TYPE},
             {CardPaymentsConstants.authCode, STRING_TYPE},
             {CardPaymentsConstants.txnDateTime, STRING_TYPE},
             {CardPaymentsConstants.referenceNbr, STRING_TYPE},
             {CardPaymentsConstants.responseReasonCode, STRING_TYPE},
             {CardPaymentsConstants.cvv2Result, STRING_TYPE},
             {CardPaymentsConstants.mid, STRING_TYPE}
         };

        /// <summary>
        /// Get the code
        /// </summary>
        /// <returns>string</returns>
        public string code()
        {
            return this.getProperty(CardPaymentsConstants.code);
        }

        /// <summary>
        /// Set the  code
        /// </summary>
        /// <returns>void</returns>
        public void code(string data)
        {
            this.setProperty(CardPaymentsConstants.code, data);
        }

        /// <summary>
        /// Get the responseCode
        /// </summary>
        /// <returns>string</returns>
        public string responseCode()
        {
            return this.getProperty(CardPaymentsConstants.responseCode);
        }

        /// <summary>
        /// Set the responseCode
        /// </summary>
        /// <returns>void</returns>
        public void responseCode(string data)
        {
            this.setProperty(CardPaymentsConstants.responseCode, data);
        }

        /// <summary>
        /// Get the avsCode
        /// </summary>
        /// <returns>string</returns>
        public string avsCode()
        {
            return this.getProperty(CardPaymentsConstants.avsCode);
        }

        /// <summary>
        /// Set the avsCode
        /// </summary>
        /// <returns>void</returns>
        public void avsCode(string data)
        {
            this.setProperty(CardPaymentsConstants.avsCode, data);
        }

        /// <summary>
        /// Get the balanceResponse
        /// </summary>
        /// <returns>string</returns>
        public string balanceResponse()
        {
            return this.getProperty(CardPaymentsConstants.balanceResponse);
        }

        /// <summary>
        /// Set the balanceResponse
        /// </summary>
        /// <returns>void</returns>
        public void balanceResponse(string data)
        {
            this.setProperty(CardPaymentsConstants.balanceResponse, data);
        }

        /// <summary>
        /// Get the batchNumber
        /// </summary>
        /// <returns>string</returns>
        public string batchNumber()
        {
            return this.getProperty(CardPaymentsConstants.batchNumber);
        }

        /// <summary>
        /// Set the batchNumber
        /// </summary>
        /// <returns>void</returns>
        public void batchNumber(string data)
        {
            this.setProperty(CardPaymentsConstants.batchNumber, data);
        }

        /// <summary>
        /// Get the effectiveDate
        /// </summary>
        /// <returns>string</returns>
        public string effectiveDate()
        {
            return this.getProperty(CardPaymentsConstants.effectiveDate);
        }

        /// <summary>
        /// Set the effectiveDate
        /// </summary>
        /// <returns>void</returns>
        public void effectiveDate(string data)
        {
            this.setProperty(CardPaymentsConstants.effectiveDate, data);
        }

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
        /// Get the seqNumber
        /// </summary>
        /// <returns>string</returns>
        public string seqNumber()
        {
            return this.getProperty(CardPaymentsConstants.seqNumber);
        }

        /// <summary>
        /// Set the seqNumber
        /// </summary>
        /// <returns>void</returns>
        public void seqNumber(string data)
        {
            this.setProperty(CardPaymentsConstants.seqNumber, data);
        }

        /// <summary>
        /// Get the term
        /// </summary>
        /// <returns>string</returns>
        public string term()
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
        /// Get the terminalId
        /// </summary>
        /// <returns>string</returns>
        public string terminalId()
        {
            return this.getProperty(CardPaymentsConstants.terminalId);
        }

        /// <summary>
        /// Set the terminalId
        /// </summary>
        /// <returns>void</returns>
        public void terminalId(int data)
        {
            this.setProperty(CardPaymentsConstants.terminalId, data);
        }

        /// <summary>
        /// Get the requestId
        /// </summary>
        /// <returns>string</returns>
        public string requestId()
        {
            return this.getProperty(CardPaymentsConstants.requestId);
        }

        /// <summary>
        /// Set the requestId
        /// </summary>
        /// <returns>void</returns>
        public void requestId(int data)
        {
            this.setProperty(CardPaymentsConstants.requestId, data);
        }

        /// <summary>
        /// Get the responseId
        /// </summary>
        /// <returns>string</returns>
        public string responseId()
        {
            return this.getProperty(CardPaymentsConstants.responseId);
        }

        /// <summary>
        /// Set the responseId
        /// </summary>
        /// <returns>void</returns>
        public void responseId(int data)
        {
            this.setProperty(CardPaymentsConstants.terminalId, data);
        }

        /// <summary>
        /// Get the description
        /// </summary>
        /// <returns>string</returns>
        public string description()
        {
            return this.getProperty(CardPaymentsConstants.description);
        }

        /// <summary>
        /// Set the description
        /// </summary>
        /// <returns>void</returns>
        public void description(string data)
        {
            this.setProperty(CardPaymentsConstants.description, data);
        }

        /// <summary>
        /// Get the authCode
        /// </summary>
        /// <returns>string</returns>
        public string authCode()
        {
            return this.getProperty(CardPaymentsConstants.authCode);
        }

        /// <summary>
        /// Set the authCode
        /// </summary>
        /// <returns>void</returns>
        public void authCode(string data)
        {
            this.setProperty(CardPaymentsConstants.authCode, data);
        }

        /// <summary>
        /// Get the txnDateTime
        /// </summary>
        /// <returns>string</returns>
        public string txnDateTime()
        {
            return this.getProperty(CardPaymentsConstants.txnDateTime);
        }

        /// <summary>
        /// Set the txnDateTime
        /// </summary>
        /// <returns>void</returns>
        public void txnDateTime(string data)
        {
            this.setProperty(CardPaymentsConstants.txnDateTime, data);
        }

        /// <summary>
        /// Get the referenceNbr
        /// </summary>
        /// <returns>string</returns>
        public string referenceNbr()
        {
            return this.getProperty(CardPaymentsConstants.referenceNbr);
        }

        /// <summary>
        /// Set the referenceNbr
        /// </summary>
        /// <returns>void</returns>
        public void referenceNbr(string data)
        {
            this.setProperty(CardPaymentsConstants.referenceNbr, data);
        }

        /// <summary>
        /// Get the responseReasonCode
        /// </summary>
        /// <returns>string</returns>
        public string responseReasonCode()
        {
            return this.getProperty(CardPaymentsConstants.responseReasonCode);
        }

        /// <summary>
        /// Set the responseReasonCode
        /// </summary>
        /// <returns>void</returns>
        public void responseReasonCode(string data)
        {
            this.setProperty(CardPaymentsConstants.responseReasonCode, data);
        }

        /// <summary>
        /// Get the cvv2Result
        /// </summary>
        /// <returns>string</returns>
        public string cvv2Result()
        {
            return this.getProperty(CardPaymentsConstants.cvv2Result);
        }

        /// <summary>
        /// Set the cvv2Result
        /// </summary>
        /// <returns>void</returns>
        public void cvv2Result(string data)
        {
            this.setProperty(CardPaymentsConstants.cvv2Result, data);
        }

        /// <summary>
        /// Get the mid
        /// </summary>
        /// <returns>string</returns>
        public string mid()
        {
            return this.getProperty(CardPaymentsConstants.mid);
        }

        /// <summary>
        /// Set the mid
        /// </summary>
        /// <returns>void</returns>
        public void mid(string data)
        {
            this.setProperty(CardPaymentsConstants.mid, data);
        }

    }
}
