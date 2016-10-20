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
using Newtonsoft.Json.Linq;
using Paysafe.Common;

namespace Paysafe.DirectDebit
{
    //Created by Manjiri.Bankar on 03.05.2016. This is DateOfBirth class.
    public class DateOfBirth : RecipientDateOfBirth
    {
        /// <summary>
        /// Initialize the Address object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public DateOfBirth(Dictionary<string, object> properties = null)
            : base(properties)
        {
        }

        public DateOfBirth()
            : base()
        {
        }

        /// <summary>
        /// DateOfBirthBuilder<typeparam name="TBLDR"></typeparam> will allow a DateOfBirth to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class DateOfBirthBuilder<TBLDR> : NestedJSONBuilder<DateOfBirth, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the DateOfBirth builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public DateOfBirthBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the day
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>DateOfBirthBuilder<TBLDR></returns>
            public DateOfBirthBuilder<TBLDR> day(int data)
            {
                this.properties[DirectDebitConstants.day] = data;
                return this;
            }

            /// <summary>
            /// Set the month
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>DateOfBirthBuilder<TBLDR></returns>
            public DateOfBirthBuilder<TBLDR> month(int data)
            {
                this.properties[DirectDebitConstants.month] = data;
                return this;
            }

            /// <summary>
            /// Set the year
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>DateOfBirthBuilder<TBLDR></returns>
            public DateOfBirthBuilder<TBLDR> year(int data)
            {
                this.properties[DirectDebitConstants.year] = data;
                return this;
            }
        }
    }
}
