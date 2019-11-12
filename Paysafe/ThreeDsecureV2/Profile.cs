using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class Profile : JSONObject
    {
        /// <summary>
        /// Initialize the Profile object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Profile(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.cellPhone, STRING_TYPE},
            {ThreeDSecureV2Constants.email, STRING_TYPE},
            {ThreeDSecureV2Constants.phone, STRING_TYPE},
            
        };
        /// <summary>
        /// Get the cellPhone
        /// </summary>
        /// <returns>String</returns>
        public string cellPhone()
        {
            return this.getProperty(ThreeDSecureV2Constants.cellPhone);
        }

        /// <summary>
        /// Set the cellPhone
        /// </summary>
        /// <returns>void</returns>
        public void cellPhone(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.cellPhone, data);
        }

        /// <summary>
        /// Get the email
        /// </summary>
        /// <returns>String</returns>
        public string email()
        {
            return this.getProperty(ThreeDSecureV2Constants.email);
        }

        /// <summary>
        /// Set the email
        /// </summary>
        /// <returns>void</returns>
        public void email(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.email, data);
        }

        /// <summary>
        /// Get the phone
        /// </summary>
        /// <returns>String</returns>
        public string phone()
        {
            return this.getProperty(ThreeDSecureV2Constants.phone);
        }

        /// <summary>
        /// Set the phone
        /// </summary>
        /// <returns>void</returns>
        public void phone(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.phone, data);
        }

        /// <summary>
        /// ProfileBuilder<typeparam name="TBLDR"></typeparam> will allow an Profile to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class ProfileBuilder<TBLDR> : NestedJSONBuilder<Profile, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Profile builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public ProfileBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the cellPhone
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder<TBLDR></returns>
            public ProfileBuilder<TBLDR> cellPhone(string data)
            {
                this.properties[ThreeDSecureV2Constants.cellPhone] = data;
                return this;
            }

            /// <summary>
            /// Set the email
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder<TBLDR></returns>
            public ProfileBuilder<TBLDR> email(string data)
            {
                this.properties[ThreeDSecureV2Constants.email] = data;
                return this;
            }

            /// <summary>
            /// Set the phone
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>ProfileBuilder<TBLDR></returns>
            public ProfileBuilder<TBLDR> phone(string data)
            {
                this.properties[ThreeDSecureV2Constants.phone] = data;
                return this;
            }
        }
    }
}