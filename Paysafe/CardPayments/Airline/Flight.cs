using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments.Airline
{
    public class Flight : JSONObject
    {
        /// <summary>
        /// Initialize the flight object with some set of properties.
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Flight(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.carrierCode, STRING_TYPE },
            {GlobalConstants.flightNumber, STRING_TYPE },
            {GlobalConstants.airlineName, STRING_TYPE },
            {GlobalConstants.airlineIcaoCode, STRING_TYPE },
        };

        /// <summary>
        /// Get operating carrier code. The standard abbreviation code indicating name of the operating carrier (United Airlines, Jet Blue, etc.).
        /// </summary>
        /// <returns>string</returns>
        public string carrierCode()
        {
            return getProperty(GlobalConstants.carrierCode);
        }

        /// <summary>
        /// Set operating carrier code. The standard abbreviation code indicating name of the operating carrier (United Airlines, Jet Blue, etc.).
        /// </summary>
        /// <returns>void</returns>
        public void carrierCode(string data)
        {
            setProperty(GlobalConstants.carrierCode, data);
        }

        /// <summary>
        /// Get the number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
        /// </summary>
        /// <returns>string</returns>
        public string flightNumber()
        {
            return getProperty(GlobalConstants.flightNumber);
        }

        /// <summary>
        /// Set the number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
        /// </summary>
        /// <returns>void</returns>
        public void flightNumber(string data)
        {
            setProperty(GlobalConstants.flightNumber, data);
        }


        /// <summary>
        /// Airline full name. Example: Bulgaria Air
        /// </summary>
        /// <returns>string</returns>
        public string airlineName()
        {
            return getProperty(GlobalConstants.airlineName);
        }

        /// <summary>
        /// Airline full name. Example: Bulgaria Air
        /// </summary>
        /// <returns>void</returns>
        public void airlineName(string data)
        {
            setProperty(GlobalConstants.airlineName, data);
        }

        /// <summary>
        /// Airline ICAO code. Example: DLH
        /// </summary>
        /// <returns>string</returns>
        public string airlineIcaoCode()
        {
            return getProperty(GlobalConstants.airlineIcaoCode);
        }

        /// <summary>
        /// Airline ICAO code. Example: DLH
        /// </summary>
        /// <returns>void</returns>
        public void airlineIcaoCode(string data)
        {
            setProperty(GlobalConstants.airlineIcaoCode, data);
        }

        /// <summary>
        /// FlightBuilder<typeparam name="TBLDR"></typeparam> will allow a FlightBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class FlightBuilder<TBLDR> : NestedJSONBuilder<Flight, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Flight builder within the context of a parent builder.
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public FlightBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set operating carrier code. The standard abbreviation code indicating name of the operating carrier (United Airlines, Jet Blue, etc.).
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>FlightBuilder<TBLDR></returns>
            public FlightBuilder<TBLDR> carrierCode(string data)
            {
                properties[GlobalConstants.carrierCode] = data;
                return this;
            }

            /// <summary>
            /// Set the number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>FlightBuilder<TBLDR></returns>
            public FlightBuilder<TBLDR> flightNumber(string data)
            {
                properties[GlobalConstants.flightNumber] = data;
                return this;
            }


            /// <summary>
            /// Airline full name. Example: Bulgaria Air
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>FlightBuilder<TBLDR></returns>
            public FlightBuilder<TBLDR> airlineName(string data)
            {
                properties[GlobalConstants.airlineName] = data;
                return this;
            }

            /// <summary>
            /// Airline ICAO code. Example: DLH
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>FlightBuilder<TBLDR></returns>
            public FlightBuilder<TBLDR> airlineIcaoCode(string data)
            {
                properties[GlobalConstants.airlineIcaoCode] = data;
                return this;
            }
        }
    }
}
