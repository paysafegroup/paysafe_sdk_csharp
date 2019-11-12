
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
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
            {ThreeDSecureV2Constants.code, STRING_TYPE},
            {ThreeDSecureV2Constants.message, STRING_TYPE}   
        
        };

        /// <summary>
        /// Get the code
        /// </summary>
        /// <returns>String</returns>
        public string code()
        {
            return this.getProperty(ThreeDSecureV2Constants.code);
        }

        /// <summary>
        /// Set the code
        /// </summary>
        /// <returns>void</returns>
        public void code(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.code, data);
        }

        /// <summary>
        /// Get the message
        /// </summary>
        /// <returns>String</returns>
        public string message()
        {
            return this.getProperty(ThreeDSecureV2Constants.message);
        }

        /// <summary>
        /// Set the message
        /// </summary>
        /// <returns>void</returns>
        public void message(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.message, data);
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
                this.properties[ThreeDSecureV2Constants.code] = data;
                return this;
            }

            /// <summary>
            /// Set the message
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ErrorBuilder<TBLDR></returns>
            public ErrorBuilder<TBLDR> message(string data)
            {
                this.properties[ThreeDSecureV2Constants.message] = data;
                return this;
            }
        }
    }
}
