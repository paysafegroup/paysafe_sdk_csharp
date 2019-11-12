using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class PriorThreeDSAuthentication : JSONObject
    {
        /// <summary>
        /// Initialize the PriorThreeDSAuthentication object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public PriorThreeDSAuthentication(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.data, STRING_TYPE},
            {ThreeDSecureV2Constants.method, ThreeDSecureV2Constants.enumMethod},
            {ThreeDSecureV2Constants.id, STRING_TYPE},
            {ThreeDSecureV2Constants.time, STRING_TYPE}
        };

        /// <summary>
        /// Get the data
        /// </summary>
        /// <returns>string</returns>
        public string data()
        {
            return this.getProperty(ThreeDSecureV2Constants.data);
        }

        /// <summary>
        /// Set the data
        /// </summary>
        /// <returns>void</returns>
        public void data(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.data, data);
        }

        /// <summary>
        /// Get the method
        /// </summary>
        /// <returns>string</returns>
        public string method()
        {
            return this.getProperty(ThreeDSecureV2Constants.method);
        }

        /// <summary>
        /// Set the data
        /// </summary>
        /// <returns>void</returns>
        public void method(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.method, data);
        }


        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(ThreeDSecureV2Constants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <returns>void</returns>
        public void id(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.id, data);
        }

        /// <summary>
        /// Get the time
        /// </summary>
        /// <returns>string</returns>
        public string time()
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
        /// PriorThreeDSAuthenticationBuilder<typeparam name="TBLDR"></typeparam> will allow an PriorThreeDSAuthentication to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class PriorThreeDSAuthenticationBuilder<TBLDR> : NestedJSONBuilder<PriorThreeDSAuthentication, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the PriorThreeDSAuthenticationBuilder  within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public PriorThreeDSAuthenticationBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the PriorThreeDSAuthenticationBuilder
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PriorThreeDSAuthenticationBuilder<TBLDR></returns>
            public PriorThreeDSAuthenticationBuilder<TBLDR> data(string data)
            {
                this.properties[ThreeDSecureV2Constants.data] = data;
                return this;
            }

            /// <summary>
            /// Set the PriorThreeDSAuthenticationBuilder
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PriorThreeDSAuthenticationBuilder<TBLDR></returns>
            public PriorThreeDSAuthenticationBuilder<TBLDR> method(string data)
            {
                this.properties[ThreeDSecureV2Constants.method] = data;
                return this;
            }

            /// <summary>
            /// Set the PriorThreeDSAuthenticationBuilder
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PriorThreeDSAuthenticationBuilder<TBLDR></returns>
            public PriorThreeDSAuthenticationBuilder<TBLDR> id(string data)
            {
                this.properties[ThreeDSecureV2Constants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the PriorThreeDSAuthenticationBuilder
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PriorThreeDSAuthenticationBuilder<TBLDR></returns>
            public PriorThreeDSAuthenticationBuilder<TBLDR> time(string data)
            {
                this.properties[ThreeDSecureV2Constants.time] = data;
                return this;
            }
        }
    }
}
