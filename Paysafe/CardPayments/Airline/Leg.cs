using Paysafe.CardPayments.Airline;
using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments
{
    public class Leg : JSONObject
    {
        /// <summary>
        /// Initialize the trip Leg object with some set of properties.
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Leg(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.flight, typeof(Flight) },
            {GlobalConstants.serviceClass, STRING_TYPE },
            {GlobalConstants.isStopOverAllowed, BOOL_TYPE },
            {GlobalConstants.destination, STRING_TYPE },
            {GlobalConstants.fareBasis, STRING_TYPE },
            {GlobalConstants.departureDate, STRING_TYPE },
        };

        /// <summary>
        /// Get operating Carrier Code and the number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
        /// </summary>
        /// <returns>Flight</returns>
        public Flight flight()
        {
            return getProperty(GlobalConstants.flight);
        }

        /// <summary>
        /// Set operating Carrier Code and the number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
        /// </summary>
        /// <returns>void</returns>
        public void flight(Flight data)
        {
            setProperty(GlobalConstants.flight, data);
        }

        /// <summary>
        ///  Get service class (first class, business class, etc.).
        /// </summary>
        /// <returns>string</returns>
        public string serviceClass()
        {
            return getProperty(GlobalConstants.serviceClass);
        }

        /// <summary>
        /// Set service class (first class, business class, etc.). Example values (not limited to): 
        ///  F - first class, J - business class, W - premium economy class, Y - economy class
        /// </summary>
        /// <returns>void</returns>
        public void serviceClass(string data)
        {
            setProperty(GlobalConstants.serviceClass, data);
        }

        /// <summary>
        /// Get whether a stopover is allowed on this ticket.
        /// </summary>
        /// <returns>bool</returns>
        public bool isStopOverAllowed()
        {
            return getProperty(GlobalConstants.isStopOverAllowed);
        }

        /// <summary>
        /// Set whether a stopover is allowed on this ticket.
        /// </summary>
        /// <returns>void</returns>
        public void isStopOverAllowed(bool data)
        {
            setProperty(GlobalConstants.isStopOverAllowed, data);
        }

        /// <summary>
        /// Get destination Airport Code (IATA Airport Code).
        /// </summary>
        /// <returns>string</returns>
        public string destination()
        {
            return getProperty(GlobalConstants.destination);
        }

        /// <summary>
        /// Set destination Airport Code (IATA Airport Code).Example “YUL”
        /// </summary>
        /// <returns>void</returns>
        public void destination(string data)
        {
            setProperty(GlobalConstants.destination, data);
        }

        /// <summary>
        /// Get a Fare Basis Code for Leg that carriers assign to a particular ticket type, 
        /// such as business class or discounted/nonrefundable.
        /// </summary>
        /// <returns>string</returns>
        public string fareBasis()
        {
            return getProperty(GlobalConstants.fareBasis);
        }

        /// <summary>
        /// Set a Fare Basis Code for Leg that carriers assign to a particular ticket type, 
        /// such as business class or discounted/nonrefundable.
        /// </summary>
        /// <returns>void</returns>
        public void fareBasis(string data)
        {
            setProperty(GlobalConstants.fareBasis, data);
        }

        /// <summary>
        /// Get date of passenger’s departure for this leg. Date format = YYYY-MM-DD, ISO 8601 expected
        /// </summary>
        /// <returns>string</returns>
        public string departureDate()
        {
            return getProperty(GlobalConstants.departureDate);
        }

        /// <summary>
        /// Set date of passenger’s departure for this leg. Date format = YYYY-MM-DD, ISO 8601 expected. 
        /// For example, 2023-01-26
        /// </summary>
        /// <returns>void</returns>
        public void departureDate(string data)
        {
            setProperty(GlobalConstants.departureDate, data);
        }

        /// <summary>
        /// LegBuilder<typeparam name="TBLDR"></typeparam> will allow a LegBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class LegBuilder<TBLDR> : NestedJSONBuilder<Leg, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Leg builder within the context of a parent builder.
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public LegBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set operating Carrier Code and the Number of the airline flight to be taken on Leg of the trip (excluding the carrier code).
            /// </summary>
            /// <returns>Flight.FlightBuilder<LegBuilder<TBLDR>></returns>
            public Flight.FlightBuilder<LegBuilder<TBLDR>> flight()
            {
                if (!properties.ContainsKey(GlobalConstants.flight))
                {
                    properties[GlobalConstants.flight] = new Flight.FlightBuilder<LegBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.flight] as Flight.FlightBuilder<LegBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set service class (first class, business class, etc.). Example values (not limited to): 
            ///  F - first class, J - business class, W - premium economy class, Y - economy class
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> serviceClass(string data)
            {
                properties[GlobalConstants.serviceClass] = data;
                return this;
            }

            /// <summary>
            /// Set whether a stopover is allowed on this ticket.
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> isStopOverAllowed(bool data)
            {
                properties[GlobalConstants.isStopOverAllowed] = data;
                return this;
            }

            /// <summary>
            /// Set destination Airport Code (IATA Airport Code).Example “YUL”
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> destination(string data)
            {
                properties[GlobalConstants.destination] = data;
                return this;
            }

            /// <summary>
            /// Set Set a Fare Basis Code for Leg that carriers assign to a particular ticket type, 
            /// such as business class or discounted/nonrefundable.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> fareBasis(string data)
            {
                properties[GlobalConstants.fareBasis] = data;
                return this;
            }

            /// <summary>
            /// Set date of passenger’s departure for this leg. Date format = YYYY-MM-DD, ISO 8601 expected. 
            /// For example, 2023-01-26
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> departureDate(string data)
            {
                properties[GlobalConstants.departureDate] = data;
                return this;
            }
        }
    }
}
