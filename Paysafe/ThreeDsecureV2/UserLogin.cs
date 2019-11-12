using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;
namespace Paysafe.ThreeDsecureV2
{
    public class UserLogin : JSONObject
    {
        /// <summary>
        /// Initialize the UserLogin object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public UserLogin(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.authenticationMethod, ThreeDSecureV2Constants.enumAuthenticationMethod},
            {ThreeDSecureV2Constants.data, STRING_TYPE},  
            {ThreeDSecureV2Constants.time, STRING_TYPE}  

        };

        /// <summary>
        /// Get the authenticationMethod
        /// </summary>
        /// <returns>string</returns>
        public bool authenticationMethod()
        {
            return this.getProperty(ThreeDSecureV2Constants.authenticationMethod);
        }

        /// <summary>
        /// Set the authenticationMethod
        /// </summary>
        /// <returns>void</returns>
        public void isElectronicDelivery(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.authenticationMethod, data);
        }

        /// <summary>
        /// Get the data
        /// </summary>
        /// <returns>string</returns>
        public bool data()
        {
            return this.getProperty(ThreeDSecureV2Constants.data);
        }

        /// <summary>
        /// Set the authenticationMethod
        /// </summary>
        /// <returns>void</returns>
        public void data(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.data, data);
        }

        /// <summary>
        /// Get the time
        /// </summary>
        /// <returns>string</returns>
        public bool time()
        {
            return this.getProperty(ThreeDSecureV2Constants.time);
        }

        /// <summary>
        /// Set the time
        /// </summary>
        /// <returns>void</returns>
        public void time(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.time, data);
        }

        /// <summary>
        /// UserLoginBuilder<typeparam name="TBLDR"></typeparam> will allow an UserLogin to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class UserLoginBuilder<TBLDR> : NestedJSONBuilder<UserLogin, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the UserLogin builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public UserLoginBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }



            /// <summary>
            /// Set the authenticationMethod
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserLoginBuilder<TBLDR></returns>
            public UserLoginBuilder<TBLDR> authenticationMethod(string data)
            {
                this.properties[ThreeDSecureV2Constants.authenticationMethod] = data;
                return this;
            }


            /// <summary>
            /// Set the data
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserLoginBuilder<TBLDR></returns>
            public UserLoginBuilder<TBLDR> data(string data)
            {
                this.properties[ThreeDSecureV2Constants.data] = data;
                return this;
            }

            /// <summary>
            /// Set the time
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>UserLoginBuilder<TBLDR></returns>
            public UserLoginBuilder<TBLDR> time(string data)
            {
                this.properties[ThreeDSecureV2Constants.time] = data;
                return this;
            }
        }

    }
}
