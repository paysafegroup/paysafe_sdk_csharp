using System.Collections.Generic;
using Paysafe.CardPayments.Airline;
using Paysafe.Common;

namespace Paysafe.CardPayments
{
    public class AirlineTravelDetails : JSONObject
    {
        /// <summary>
        /// Initialize the AirlineTravelDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public AirlineTravelDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.passengerName, STRING_TYPE },
            {GlobalConstants.departureDate,  STRING_TYPE },
            {GlobalConstants.origin,  STRING_TYPE },
            {GlobalConstants.computerizedReservationSystem, GlobalConstants.enumComputerizedReservationSystem },
            {GlobalConstants.ticket, typeof(Ticket) },
            {GlobalConstants.passengers, typeof(Passengers) },
            {GlobalConstants.customerReferenceNumber, STRING_TYPE },
            {GlobalConstants.travelAgency, typeof(TravelAgency) },
            {GlobalConstants.tripLegs, typeof(TripLegs) },
            {GlobalConstants.passengerNameRecord, STRING_TYPE },
            {GlobalConstants.additionalBookingReference, STRING_TYPE },
            {GlobalConstants.totalFare, INT_TYPE },
            {GlobalConstants.totalFee, INT_TYPE },
            {GlobalConstants.totalTaxes, INT_TYPE },
        };

        /// <summary>
        /// Get the passenger name
        /// </summary>
        /// <returns>string</returns>
        public string passengerName()
        {
            return getProperty(GlobalConstants.passengerName);
        }

        /// <summary>
        /// Set the passanger name
        /// </summary>
        /// <returns>void</returns>
        public void passengerName(string data)
        {
            setProperty(GlobalConstants.passengerName, data);
        }

        /// <summary>
        /// Get the origin - departure airport code
        /// </summary>
        /// <returns>string</returns>
        public string origin()
        {
            return getProperty(GlobalConstants.origin);
        }

        /// <summary>
        /// Set the origin - departure airport code
        /// </summary>
        /// <returns>void</returns>
        public void origin(string data)
        {
            setProperty(GlobalConstants.origin, data);
        }

        /// <summary>
        /// Get date of passenger’s departure. Date format = YYYY-MM-DD, ISO 8601 expected.
        /// </summary>
        /// <returns>string</returns>
        public string departureDate()
        {
            return getProperty(GlobalConstants.departureDate);
        }

        /// <summary>
        /// Set date of passenger’s departure. Date format = YYYY-MM-DD, ISO 8601 expected.
        /// </summary>
        /// <returns>void</returns>
        public void departureDate(string data)
        {
            setProperty(GlobalConstants.departureDate, data);
        }

        /// <summary>
        /// Get information about the Airline Ticket and if the ticket is restricted.
        /// </summary>
        /// <returns>Ticket</returns>
        public Ticket ticket()
        {
            return getProperty(GlobalConstants.ticket);
        }

        /// <summary>
        /// Set information about the Airline Ticket and if the ticket is restricted.
        /// </summary>
        /// <returns>void</returns>
        public void ticket(Ticket data)
        {
            setProperty(GlobalConstants.ticket, data);
        }

        /// <summary>
        /// Get passengers information.
        /// </summary>
        /// <returns>Passangers</returns>
        public Passengers passengers()
        {
            return getProperty(GlobalConstants.passengers);
        }

        /// <summary>
        /// Set passengers information.
        /// </summary>
        /// <returns>void</returns>
        public void passengers(Passengers data)
        {
            setProperty(GlobalConstants.passengers, data);
        }

        /// <summary>
        /// Get computerized reservation system used to make the reservation and purchase the ticket.
        /// </summary>
        /// <returns>string</returns>
        public string computerizedReservationSystem()
        {
            return getProperty(GlobalConstants.computerizedReservationSystem);
        }

        /// <summary>
        /// Set computerized reservation system used to make the reservation and purchase the ticket. Example: 'STRT'
        /// </summary>
        /// <returns>void</returns>
        public void computerizedReservationSystem(string data)
        {
            setProperty(GlobalConstants.computerizedReservationSystem, data);
        }

        /// <summary>
        /// Get the code that the cardholder supplied to the card acceptor.
        /// </summary>
        /// <returns>string</returns>
        public string customerReferenceNumber()
        {
            return getProperty(GlobalConstants.customerReferenceNumber);
        }

        /// <summary>
        /// Set the code that the cardholder supplied to the card acceptor.
        /// </summary>
        /// <returns>void</returns>
        public void customerReferenceNumber(string data)
        {
            setProperty(GlobalConstants.customerReferenceNumber, data);
        }

        /// <summary>
        /// Get information about the travel agency if the ticket was issued by a travel agency.
        /// </summary>
        /// <returns>TravelAgency</returns>
        public TravelAgency travelAgency()
        {
            return getProperty(GlobalConstants.travelAgency);
        }

        /// <summary>
        /// Set information about the travel agency if the ticket was issued by a travel agency.
        /// </summary>
        /// <returns>void</returns>
        public void travelAgency(TravelAgency data)
        {
            setProperty(GlobalConstants.travelAgency, data);
        }

        /// <summary>
        /// Get a grouping of up to four trip legs. Each leg provides detailed itinerary data.
        /// </summary>
        /// <returns>TripLegs</returns>
        public TripLegs tripLegs()
        {
            return getProperty(GlobalConstants.tripLegs);
        }

        /// <summary>
        /// Set a grouping of up to four trip legs. Each leg provides detailed itinerary data.
        /// </summary>
        /// <returns>void</returns>
        public void tripLegs(TripLegs data)
        {
            setProperty(GlobalConstants.tripLegs, data);
        }

        /// <summary>
        /// Get name of the passenger record.
        /// </summary>
        /// <returns>string</returns>
        public string passengerNameRecord()
        {
            return getProperty(GlobalConstants.passengerNameRecord);
        }

        /// <summary>
        /// Set name of the passenger record.
        /// </summary>
        /// <returns>void</returns>
        public void passengerNameRecord(string data)
        {
            setProperty(GlobalConstants.passengerNameRecord, data);
        }

        /// <summary>
        /// Typically used for the PNR, but should allow an airline to specify any other reference if they feel fit.
        /// </summary>
        /// <returns>string</returns>
        public string additionalBookingReference()
        {
            return getProperty(GlobalConstants.additionalBookingReference);
        }

        /// <summary>
        /// Typically used for the PNR, but should allow an airline to specify any other reference if they feel fit.
        /// </summary>
        /// <returns>void</returns>
        public void additionalBookingReference(string data)
        {
            setProperty(GlobalConstants.additionalBookingReference, data);
        }

        /// <summary>
        /// Total fare for all legs on the ticket, excluding taxes and fees.
        /// </summary>
        /// <returns>int</returns>
        public int totalFare()
        {
            return getProperty(GlobalConstants.totalFare);
        }

        /// <summary>
        /// Total fare for all legs on the ticket, excluding taxes and fees.
        /// </summary>
        /// <returns>void</returns>
        public void totalFare(int data)
        {
            setProperty(GlobalConstants.totalFare, data);
        }

        /// <summary>
        /// Total fee for all legs on the ticket.
        /// </summary>
        /// <returns>int</returns>
        public int totalFee()
        {
            return getProperty(GlobalConstants.totalFee);
        }

        /// <summary>
        /// Total fee for all legs on the ticket.
        /// </summary>
        /// <returns>void</returns>
        public void totalFee(int data)
        {
            setProperty(GlobalConstants.totalFee, data);
        }

        /// <summary>
        /// Total taxes for all legs on the ticket.
        /// </summary>
        /// <returns>int</returns>
        public int totalTaxes()
        {
            return getProperty(GlobalConstants.totalTaxes);
        }

        /// <summary>
        /// Total taxes for all legs on the ticket.
        /// </summary>
        /// <returns>void</returns>
        public void totalTaxes(int data)
        {
            setProperty(GlobalConstants.totalTaxes, data);
        }

        /// <summary>
        /// AirlineTravelDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow a AirlineTravelDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class AirlineTravelDetailsBuilder<TBLDR> : NestedJSONBuilder<AirlineTravelDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the AirlineTravelDetailsBuilder builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public AirlineTravelDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the passengerName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> passengerName(string data)
            {
                properties[GlobalConstants.passengerName] = data;
                return this;
            }

            /// <summary>
            /// Set the origin - departure airport name
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> origin(string data)
            {
                properties[GlobalConstants.origin] = data;
                return this;
            }

            /// <summary>
            /// Set date of passenger’s departure. Date format = YYYY-MM-DD, ISO 8601 expected.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> departureDate(string data)
            {
                properties[GlobalConstants.departureDate] = data;
                return this;
            }

            /// <summary>
            /// Set information about the Airline Ticket and if the ticket is restricted.
            /// </summary>
            /// <returns>Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>></returns>
            public Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>> ticket()
            {
                if (!properties.ContainsKey(GlobalConstants.ticket))
                {
                    properties[GlobalConstants.ticket] = new Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.ticket] as Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>>;
            }


            /// <summary>
            /// Set passengers information.
            /// </summary>
            /// <returns>Passengers.PassengersBuilder<AirlineTravelDetailsBuilder<TBLDR>></returns>
            public Passengers.PassengersBuilder<AirlineTravelDetailsBuilder<TBLDR>> passengers()
            {
                if (!properties.ContainsKey(GlobalConstants.passengers))
                {
                    properties[GlobalConstants.passengers] = new Passengers.PassengersBuilder<AirlineTravelDetailsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passengers] as Passengers.PassengersBuilder<AirlineTravelDetailsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set computerized reservation system used to make the reservation and purchase the ticket. Example: 'STRT'
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> computerizedReservationSystem(string data)
            {
                properties[GlobalConstants.computerizedReservationSystem] = data;
                return this;
            }

            /// <summary>
            /// Set the code that the cardholder supplied to the card acceptor.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> customerReferenceNumber(string data)
            {
                properties[GlobalConstants.customerReferenceNumber] = data;
                return this;
            }

            /// <summary>
            /// Set information about the travel agency if the ticket was issued by a travel agency.
            /// </summary>
            /// <returns>TravelAgency.TravelAgencyBuilder<AirlineTravelDetailsBuilder<TBLDR>></returns>
            public TravelAgency.TravelAgencyBuilder<AirlineTravelDetailsBuilder<TBLDR>> travelAgency()
            {
                if (!properties.ContainsKey(GlobalConstants.travelAgency))
                {
                    properties[GlobalConstants.travelAgency] = new TravelAgency.TravelAgencyBuilder<AirlineTravelDetailsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.travelAgency] as TravelAgency.TravelAgencyBuilder<AirlineTravelDetailsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set a grouping of up to four trip legs. Each leg provides detailed itinerary data.
            /// </summary>
            /// <returns>TripLegs.TripLegsBuilder<AirlineTravelDetailsBuilder<TBLDR>></returns>
            public TripLegs.TripLegsBuilder<AirlineTravelDetailsBuilder<TBLDR>> tripLegs()
            {
                if (!properties.ContainsKey(GlobalConstants.tripLegs))
                {
                    properties[GlobalConstants.tripLegs] = new TripLegs.TripLegsBuilder<AirlineTravelDetailsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.tripLegs] as TripLegs.TripLegsBuilder<AirlineTravelDetailsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set name of the passenger record.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> passengerNameRecord(string data)
            {
                properties[GlobalConstants.passengerNameRecord] = data;
                return this;
            }

            /// <summary>
            /// Typically used for the PNR, but should allow an airline to specify any other reference if they feel fit.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> additionalBookingReference(string data)
            {
                properties[GlobalConstants.additionalBookingReference] = data;
                return this;
            }

            /// <summary>
            /// Total fare for all legs on the ticket, excluding taxes and fees.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> totalFare(int data)
            {
                properties[GlobalConstants.totalFare] = data;
                return this;
            }

            /// <summary>
            /// Total fee for all legs on the ticket.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> totalFee(int data)
            {
                properties[GlobalConstants.totalFee] = data;
                return this;
            }

            /// <summary>
            /// Total taxes for all legs on the ticket.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> totalTaxes(int data)
            {
                properties[GlobalConstants.totalTaxes] = data;
                return this;
            }

        }
    }
}
                        