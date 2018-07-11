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

namespace Paysafe.CardPayments
{
    /**
     * This class can be used to override any of the string literals from the global strings class
     */
    class CardPaymentsConstants : Paysafe.Common.GlobalConstants
    {
        public static readonly List<string> enumAVSResponse = new List<string>() {
            validationMatch,
            validationMatchAddressOnly,
            validationMatchZipOnly,
            validationNoMatch,
            validationNotProcessed,
            validationUnknown
        };
        public static readonly List<string> enumCVVVerification = new List<string>() {
            validationMatch,
            validationNoMatch,
            validationNotProcessed,
            validationUnknown

        };
        public static readonly List<string> enumFinancingType = new List<string>() {
            financingDeferredPayment,
            financingEqualPayment
        };
        public static readonly List<string> enumRecurring = new List<string>() {
            recurringInitial,
            recurringRecurring
        };
        public static readonly List<string> enumType = new List<string>() {
            typeAdhoc,
            typeTopup,
            typeRecurring
        };
        public static readonly List<string> enumOccurrence = new List<string>() {
            occurrenceInitial,
            occurrenceSubsequent
        };
        public static readonly List<string> enumStatus = new List<string>() {
            statusReceived,
            statusPending,
            statusProcessing,
            statusCompleted,
            statusFailed,
            statusCancelled
        };
    }
}
