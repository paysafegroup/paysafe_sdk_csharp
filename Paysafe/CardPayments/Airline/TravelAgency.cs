
using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments
{
    public class TravelAgency : JSONObject
    {
        /// <summary>
        /// Initialize the Travel agency object with some set of properties.
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public TravelAgency(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.code, STRING_TYPE },
            {GlobalConstants.name, STRING_TYPE },
        };

        /// <summary>
        /// Code identifying travel agency if the ticket was issued by a travel agency.
        /// </summary>
        /// <returns>string</returns>
        public string code()
        {
            return getProperty(GlobalConstants.code);
        }

        /// <summary>
        /// Set code identifying travel agency if the ticket was issued by a travel agency.
        /// </summary>
        /// <returns>void</returns>
        public void code(string data)
        {
            setProperty(GlobalConstants.code, data);
        }

        /// <summary>
        /// Get name of travel agency if the ticket was issued by a travel agency.
        /// </summary>
        /// <returns>string</returns>
        public string name()
        {
            return getProperty(GlobalConstants.name);
        }

        /// <summary>
        /// Set name of travel agency if the ticket was issued by a travel agency.
        /// </summary>
        /// <returns>void</returns>
        public void name(string data)
        {
            setProperty(GlobalConstants.name, data);
        }

        /// <summary>
        /// TravelAgencyBuilder<typeparam name="TBLDR"></typeparam> will allow a TravelAgencyBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class TravelAgencyBuilder<TBLDR> : NestedJSONBuilder<TravelAgency, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Travel agency builder within the context of a parent builder.
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public TravelAgencyBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set code identifying travel agency if the ticket was issued by a travel agency.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelAgencyBuilder<TBLDR></returns>
            public TravelAgencyBuilder<TBLDR> code(string data)
            {
                properties[GlobalConstants.code] = data;
                return this;
            }

            /// <summary>
            /// Set name of travel agency if the ticket was issued by a travel agency.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelAgencyBuilder<TBLDR></returns>
            public TravelAgencyBuilder<TBLDR> name(string data)
            {
                properties[GlobalConstants.name] = data;
                return this;
            }
        }
    }
}
