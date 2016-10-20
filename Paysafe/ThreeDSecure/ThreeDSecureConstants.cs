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
    //Created by Tushar.Sukhiya on 03.05.2016. This is ThreeDSecureConstants class.
    class ThreeDSecureConstants: GlobalConstants
    {
        public static readonly List<string> enumStatus = new List<string>() {
            statusCompleted,
            statusFailed
        };
        public static readonly List<string> enumThreeDEnrollment = new List<string>() {
            threeDEnrolled,             //Cardholder authentication available 
            threeDNotEnrolled,          // Cardholder not enrolled in authentication
            threeDEnrollmentUnavailable //Cardholder authentication unavailable
        };
        public static readonly List<string> enumThreeDResult = new List<string>() {
            authenticated,              //Cardholder authentication available 
            authenticationAttempted,    //Cardholder authentication attempted
            authenticationFailed,       //Cardholder authentication Failed
            authenticationUnavailable,  //Cardholder authentication Unavailable
            authenticationError         //Cardholder authentication Error
        };
        public static readonly List<string> enumSignatureStatus = new List<string>() {
            signatureSatisfied,          //All transaction and signature checks satisfied
            signatureNotSatisfied,       //At least one transaction or signature check failed
        };
        public static readonly List<string> enumType = new List<string>() {
            AM ,// American Express
            DC ,// Diners Club
            DI ,//Discover
            JC ,// JCB
            MC ,//MasterCard
            MD ,// Maestro
            SF ,// Swiff
            SO ,// Solo
            VI ,// Visa
            VD ,// Visa Debit
            VE // Visa Electron
        };
    }
}
