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
            {GlobalConstants.serviceClassFee, INT_TYPE },
            {GlobalConstants.departureAirport, STRING_TYPE },
            {GlobalConstants.departureTime, STRING_TYPE },
            {GlobalConstants.arrivalTime, STRING_TYPE },
            {GlobalConstants.conjunctionTicket, STRING_TYPE },
            {GlobalConstants.couponNumber, STRING_TYPE },
            {GlobalConstants.notation, STRING_TYPE },
            {GlobalConstants.taxes, INT_TYPE },
            {GlobalConstants.airlineName, STRING_TYPE },
            {GlobalConstants.airlineIcaoCode, STRING_TYPE },
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
        /// Get fee applied to a specific leg.
        /// </summary>
        /// <returns>int</returns>
        public int serviceClassFee()
        {
            return getProperty(GlobalConstants.serviceClassFee);
        }

        /// <summary>
        /// Set fee applied to a specific leg.
        /// </summary>
        /// <returns>void</returns>
        public void serviceClassFee(int data)
        {
            setProperty(GlobalConstants.serviceClassFee, data);
        }

        /// <summary>
        /// Departure airport. Example: SOF
        /// </summary>
        /// <returns>string</returns>
        public string departureAirport()
        {
            return getProperty(GlobalConstants.departureAirport);
        }

        /// <summary>
        /// Departure time at the airport of departure.
        /// </summary>
        /// <returns>void</returns>
        public void departureAirport(string data)
        {
            setProperty(GlobalConstants.departureAirport, data);
        }

        /// <summary>
        /// Departure time at the airport of departure.
        /// </summary>
        /// <returns>string</returns>
        public string departureTime()
        {
            return getProperty(GlobalConstants.departureTime);
        }

        /// <summary>
        /// Departure time at the airport of departure.
        /// </summary>
        /// <returns>void</returns>
        public void departureTime(string data)
        {
            setProperty(GlobalConstants.departureTime, data);
        }

        /// <summary>
        /// Arrival time at the airport for that specific leg.
        /// </summary>
        /// <returns>string</returns>
        public string arrivalTime()
        {
            return getProperty(GlobalConstants.arrivalTime);
        }

        /// <summary>
        /// Arrival time at the airport for that specific leg.
        /// </summary>
        /// <returns>void</returns>
        public void arrivalTime(string data)
        {
            setProperty(GlobalConstants.arrivalTime, data);
        }

        /// <summary>
        /// Specifying a number of the conjunction ticket within a single contract of carriage. Example: NUM123
        /// </summary>
        /// <returns>string</returns>
        public string conjunctionTicket()
        {
            return getProperty(GlobalConstants.conjunctionTicket);
        }

        /// <summary>
        /// Specifying a number of the conjunction ticket within a single contract of carriage. Example: NUM123
        /// </summary>
        /// <returns>void</returns>
        public void conjunctionTicket(string data)
        {
            setProperty(GlobalConstants.conjunctionTicket, data);
        }

        /// <summary>
        /// Coupon number associated with the leg. Every leg could have a coupon number.
        /// </summary>
        /// <returns>string</returns>
        public string couponNumber()
        {
            return getProperty(GlobalConstants.couponNumber);
        }

        /// <summary>
        /// Coupon number associated with the leg. Every leg could have a coupon number.
        /// </summary>
        /// <returns>void</returns>
        public void couponNumber(string data)
        {
            setProperty(GlobalConstants.couponNumber, data);
        }

        /// <summary>
        /// An endorsement can be an agency-added notation or a mandatory government required notation, such as value-added tax. 
        /// A restriction is a limitation based on the type of fare, such as a ticket with a 3-day minimum stay.
        /// </summary>
        /// <returns>string</returns>
        public string notation()
        {
            return getProperty(GlobalConstants.notation);
        }

        /// <summary>
        /// An endorsement can be an agency-added notation or a mandatory government required notation, such as value-added tax. 
        /// A restriction is a limitation based on the type of fare, such as a ticket with a 3-day minimum stay.
        /// </summary>
        /// <returns>void</returns>
        public void notation(string data)
        {
            setProperty(GlobalConstants.notation, data);
        }

        /// <summary>
        /// Taxes for a specific leg.
        /// </summary>
        /// <returns>int</returns>
        public int taxes()
        {
            return getProperty(GlobalConstants.taxes);
        }

        /// <summary>
        /// Taxes for a specific leg.
        /// </summary>
        /// <returns>void</returns>
        public void taxes(int data)
        {
            setProperty(GlobalConstants.taxes, data);
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

            /// <summary>
            /// Set fee applied to a specific leg.
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> serviceClassFee(int data)
            {
                properties[GlobalConstants.serviceClassFee] = data;
                return this;
            }

            /// <summary>
            /// Departure airport. Example: SOF
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> departureAirport(string data)
            {
                properties[GlobalConstants.departureAirport] = data;
                return this;
            }

            /// <summary>
            /// Departure time at the airport of departure.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> departureTime(string data)
            {
                properties[GlobalConstants.departureTime] = data;
                return this;
            }

            /// <summary>
            /// Arrival time at the airport for that specific leg.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> arrivalTime(string data)
            {
                properties[GlobalConstants.arrivalTime] = data;
                return this;
            }

            /// <summary>
            /// Specifying a number of the conjunction ticket within a single contract of carriage. Example: NUM123
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> conjunctionTicket(string data)
            {
                properties[GlobalConstants.conjunctionTicket] = data;
                return this;
            }

            /// <summary>
            /// Coupon number associated with the leg. Every leg could have a coupon number.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> couponNumber(string data)
            {
                properties[GlobalConstants.couponNumber] = data;
                return this;
            }

            /// <summary>
            /// An endorsement can be an agency-added notation or a mandatory government required notation, such as value-added tax. 
            /// A restriction is a limitation based on the type of fare, such as a ticket with a 3-day minimum stay.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> notation(string data)
            {
                properties[GlobalConstants.notation] = data;
                return this;
            }

            /// <summary>
            /// Taxes for a specific leg.
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> taxes(int data)
            {
                properties[GlobalConstants.taxes] = data;
                return this;
            }

            /// <summary>
            /// Airline full name. Example: Bulgaria Air
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> airlineName(string data)
            {
                properties[GlobalConstants.airlineName] = data;
                return this;
            }

            /// <summary>
            /// Airline ICAO code. Example: DLH
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>LegBuilder<TBLDR></returns>
            public LegBuilder<TBLDR> airlineIcaoCode(string data)
            {
                properties[GlobalConstants.airlineIcaoCode] = data;
                return this;
            }
        }
    }
}
