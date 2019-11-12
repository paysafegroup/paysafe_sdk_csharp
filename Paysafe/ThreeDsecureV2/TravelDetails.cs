using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class TravelDetails : JSONObject
    {
        /// <summary>
        /// Initialize the TravelDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public TravelDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.isAirTravel, BOOL_TYPE},
            {ThreeDSecureV2Constants.airlineCarrier, STRING_TYPE},
            {ThreeDSecureV2Constants.departureDate, STRING_TYPE}, 
            {ThreeDSecureV2Constants.destination, STRING_TYPE},  
            {ThreeDSecureV2Constants.origin, STRING_TYPE},
            {ThreeDSecureV2Constants.passengerFirstName, STRING_TYPE},  
            {ThreeDSecureV2Constants.passengerLastName, STRING_TYPE},  
        };

        /// <summary>
        /// Get the isAirTravel
        /// </summary>
        /// <returns>Bool</returns>
        public bool isAirTravel()
        {
            return this.getProperty(ThreeDSecureV2Constants.isAirTravel);
        }

        /// <summary>
        /// Set the isAirTravel
        /// </summary>
        /// <returns>void</returns>
        public void isAirTravel(bool data)
        {
            this.setProperty(ThreeDSecureV2Constants.isAirTravel, data);
        }

        /// <summary>
        /// Get the airlineCarrier
        /// </summary>
        /// <returns>string</returns>
        public string airlineCarrier()
        {
            return this.getProperty(ThreeDSecureV2Constants.airlineCarrier);
        }

        /// <summary>
        /// Set the airlineCarrier
        /// </summary>
        /// <returns>void</returns>
        public void airlineCarrier(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.airlineCarrier, data);
        }

        /// <summary>
        /// Get the departureDate
        /// </summary>
        /// <returns>string</returns>
        public string departureDate()
        {
            return this.getProperty(ThreeDSecureV2Constants.departureDate);
        }

        /// <summary>
        /// Set the departureDate
        /// </summary>
        /// <returns>void</returns>
        public void departureDate(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.departureDate, data);
        }

        /// <summary>
        /// Get the destination
        /// </summary>
        /// <returns>string</returns>
        public string destination()
        {
            return this.getProperty(ThreeDSecureV2Constants.destination);
        }

        /// <summary>
        /// Set the destination
        /// </summary>
        /// <returns>void</returns>
        public void destination(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.destination, data);
        }

        /// <summary>
        /// Get the origin
        /// </summary>
        /// <returns>string</returns>
        public string origin()
        {
            return this.getProperty(ThreeDSecureV2Constants.origin);
        }

        /// <summary>
        /// Set the origin
        /// </summary>
        /// <returns>void</returns>
        public void origin(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.origin, data);
        }

        /// <summary>
        /// Get the passengerFirstName
        /// </summary>
        /// <returns>string</returns>
        public string passengerFirstName()
        {
            return this.getProperty(ThreeDSecureV2Constants.passengerFirstName);
        }

        /// <summary>
        /// Set the passengerFirstName
        /// </summary>
        /// <returns>void</returns>
        public void passengerFirstName(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.passengerFirstName, data);
        }

        /// <summary>
        /// Get the passengerFirstName
        /// </summary>
        /// <returns>string</returns>
        public string passengerLastName()
        {
            return this.getProperty(ThreeDSecureV2Constants.passengerLastName);
        }

        /// <summary>
        /// Set the passengerLastName
        /// </summary>
        /// <returns>void</returns>
        public void passengerLastName(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.passengerLastName, data);
        }

        /// <summary>
        /// TravelDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow an TravelDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class TravelDetailsBuilder<TBLDR> : NestedJSONBuilder<TravelDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the TravelDetailsBuilder  within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public TravelDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the isAirTravel
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> isAirTravel(bool data)
            {
                this.properties[ThreeDSecureV2Constants.isAirTravel] = data;
                return this;
            }

            /// <summary>
            /// Set the airlineCarrier
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> airlineCarrier(string data)
            {
                this.properties[ThreeDSecureV2Constants.airlineCarrier] = data;
                return this;
            }

            /// <summary>
            /// Set the departureDate
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> departureDate(string data)
            {
                this.properties[ThreeDSecureV2Constants.departureDate] = data;
                return this;
            }

            /// <summary>
            /// Set the destination
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> destination(string data)
            {
                this.properties[ThreeDSecureV2Constants.destination] = data;
                return this;
            }

            /// <summary>
            /// Set the origin
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> origin(string data)
            {
                this.properties[ThreeDSecureV2Constants.origin] = data;
                return this;
            }

            /// <summary>
            /// Set the passengerFirstName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> passengerFirstName(string data)
            {
                this.properties[ThreeDSecureV2Constants.passengerFirstName] = data;
                return this;
            }


            /// <summary>
            /// Set the passengerLastName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TravelDetailsBuilder<TBLDR></returns>
            public TravelDetailsBuilder<TBLDR> passengerLastName(string data)
            {
                this.properties[ThreeDSecureV2Constants.passengerLastName] = data;
                return this;
            }
        }
    }
}
