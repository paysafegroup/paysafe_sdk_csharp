using System.Collections.Generic;
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
            {CardPaymentsConstants.passengerName, STRING_TYPE},
            {CardPaymentsConstants.departureDate,  STRING_TYPE},
            {CardPaymentsConstants.ticket, typeof(Ticket)},
            {CardPaymentsConstants.origin,  STRING_TYPE},
            {CardPaymentsConstants.computerizedReservationSystem, CardPaymentsConstants.enumComputerizedReservationSystem},
        };

        /// <summary>
        /// Get the passenger name
        /// </summary>
        /// <returns>string</returns>
        public string passengerName()
        {
            return this.getProperty(CardPaymentsConstants.passengerName);
        }

        /// <summary>
        /// Set the passanger name
        /// </summary>
        /// <returns>void</returns>
        public void passengerName(string data)
        {
            this.setProperty(CardPaymentsConstants.passengerName, data);
        }


        /// <summary>
        /// Get the origin - departure airport code
        /// </summary>
        /// <returns>string</returns>
        public string origin()
        {
            return this.getProperty(CardPaymentsConstants.origin);
        }

        /// <summary>
        /// Set the origin - departure airport code
        /// </summary>
        /// <returns>void</returns>
        public void origin(string data)
        {
            this.setProperty(CardPaymentsConstants.origin, data);
        }


        /// <summary>
        /// Get date of passenger’s departure. Date format = YYYY-MM-DD, ISO 8601 expected.
        /// </summary>
        /// <returns>string</returns>
        public string departureDate()
        {
            return this.getProperty(CardPaymentsConstants.departureDate);
        }

        /// <summary>
        /// Set date of passenger’s departure. Date format = YYYY-MM-DD, ISO 8601 expected.
        /// </summary>
        /// <returns>void</returns>
        public void departureDate(string data)
        {
            this.setProperty(CardPaymentsConstants.departureDate, data);
        }


        /// <summary>
        /// Get information about the Airline Ticket and if the ticket is restricted.
        /// </summary>
        /// <returns>string</returns>
        public Ticket ticket()
        {
            return this.getProperty(CardPaymentsConstants.ticket);
        }

        /// <summary>
        /// Set information about the Airline Ticket and if the ticket is restricted.
        /// </summary>
        /// <returns>void</returns>
        public void ticket(Ticket data)
        {
            this.setProperty(CardPaymentsConstants.ticket, data);
        }

        /// <summary>
        /// Get computerized reservation system used to make the reservation and purchase the ticket.
        /// </summary>
        /// <returns>string</returns>
        public string computerizedReservationSystem()
        {
            return getProperty(CardPaymentsConstants.computerizedReservationSystem);
        }

        /// <summary>
        /// Set computerized reservation system used to make the reservation and purchase the ticket. Example: 'STRT'
        /// </summary>
        /// <returns>void</returns>
        public void computerizedReservationSystem(string data)
        {
            setProperty(CardPaymentsConstants.computerizedReservationSystem, data);
        }

        /// <summary>
        /// AirlineTravelDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow a AirlineTravelDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
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
            /// Set the passangerName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> passengerName(string data)
            {
                this.properties[CardPaymentsConstants.passengerName] = data;
                return this;
            }

            /// <summary>
            /// Set the origin - departure airport name
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> origin(string data)
            {
                this.properties[CardPaymentsConstants.origin] = data;
                return this;
            }

            /// <summary>
            /// Set date of passenger’s departure. Date format = YYYY-MM-DD, ISO 8601 expected.
            /// </summary>
            /// <returns>AirlineTravelDetailsBuilder<TBLDR></returns>
            public AirlineTravelDetailsBuilder<TBLDR> departureDate(string data)
            {
                this.properties[CardPaymentsConstants.departureDate] = data;
                return this;
            }

            /// <summary>
            /// Set information about the Airline Ticket and if the ticket is restricted.
            /// </summary>
            /// <returns>Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>></returns>
            public Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>> ticket()
            {
                if (!this.properties.ContainsKey(CardPaymentsConstants.ticket))
                {
                    this.properties[CardPaymentsConstants.ticket] = new Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>>(this);
                }
                return this.properties[CardPaymentsConstants.ticket] as Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set computerized reservation system used to make the reservation and purchase the ticket. Example: 'STRT'
            /// </summary>
            /// <returns>Ticket.TicketBuilder<AirlineTravelDetailsBuilder<TBLDR>></returns>
            public AirlineTravelDetailsBuilder<TBLDR> computerizedReservationSystem(string data)
            {
                properties[CardPaymentsConstants.computerizedReservationSystem] = data;
                return this;
            }
        }
    }
}
