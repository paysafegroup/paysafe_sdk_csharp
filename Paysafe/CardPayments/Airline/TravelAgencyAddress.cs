using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments.Airline
{
    public class TravelAgencyAddress : JSONObject
    {
        /// <summary>
        /// Initialize the Travel agency address object with some set of properties.
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public TravelAgencyAddress(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.street, STRING_TYPE },
            {GlobalConstants.zip, STRING_TYPE },
            {GlobalConstants.country,  GlobalConstants.enumCountry }
        };

        /// <summary>
        /// Address line of the agent selling the ticket.
        /// </summary>
        /// <returns>string</returns>
        public string street()
        {
            return getProperty(GlobalConstants.street);
        }

        /// <summary>
        /// Set address line of the agent selling the ticket.
        /// </summary>
        /// <returns>void</returns>
        public void street(string data)
        {
            setProperty(GlobalConstants.street, data);
        }

        /// <summary>
        /// Postal code of the agent selling the ticket.
        /// </summary>
        /// <returns>string</returns>
        public string zip()
        {
            return getProperty(GlobalConstants.zip);
        }

        /// <summary>
        /// Set postal code of the agent selling the ticket.
        /// </summary>
        /// <returns>void</returns>
        public void zip(string data)
        {
            setProperty(GlobalConstants.zip, data);
        }

        /// <summary>
        /// Country code (ISO alpha-2) of agent selling the ticket.
        /// </summary>
        /// <returns>string</returns>
        public string country()
        {
            return getProperty(GlobalConstants.country);
        }

        /// <summary>
        /// Set country code (ISO alpha-2) of agent selling the ticket.
        /// </summary>
        /// <returns>void</returns>
        public void country(string data)
        {
            setProperty(GlobalConstants.country, data);
        }

        /// <summary>
        /// TravelAgencyBuilder<typeparam name="TBLDR"></typeparam> will allow a TravelAgencyBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class TravelAgencyAddressBuilder<TBLDR> : NestedJSONBuilder<TravelAgencyAddress, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Travel agency address builder within the context of a parent builder.
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public TravelAgencyAddressBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set address line of the agent selling the ticket.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelAgencyAddressBuilder<TBLDR></returns>
            public TravelAgencyAddressBuilder<TBLDR> street(string data)
            {
                properties[GlobalConstants.street] = data;
                return this;
            }

            /// <summary>
            /// Set postal code of the agent selling the ticket.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelAgencyAddressBuilder<TBLDR></returns>
            public TravelAgencyAddressBuilder<TBLDR> zip(string data)
            {
                properties[GlobalConstants.zip] = data;
                return this;
            }

            /// <summary>
            /// Set country code (ISO alpha-2) of agent selling the ticket.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelAgencyAddressBuilder<TBLDR></returns>
            public TravelAgencyAddressBuilder<TBLDR> country(string data)
            {
                properties[GlobalConstants.country] = data;
                return this;
            }
        }
    }
}
