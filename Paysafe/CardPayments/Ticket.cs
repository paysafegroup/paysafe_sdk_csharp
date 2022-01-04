using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments
{
    public class Ticket : JSONObject
    {
        /// <summary>
        /// Initialize the Ticket object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Ticket(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.ticketNumber, STRING_TYPE },
            {GlobalConstants.isRestrictedTicket, BOOL_TYPE },
        };

        /// <summary>
        ///  Get airline ticket number.
        /// </summary>
        /// <returns>string</returns>
        public string ticketNumber()
        {
            return getProperty(GlobalConstants.ticketNumber);
        }

        /// <summary>
        /// Set airline ticket number
        /// </summary>
        /// <returns>void</returns>
        public void ticketNumber(string data)
        {
            setProperty(GlobalConstants.ticketNumber, data);
        }

        /// <summary>
        ///  Indicates whether this ticket is non-refundable.
        ///  This entry should be supplied on CPS/Passenger Transport 1 or 2 transactions 
        ///  if the ticket was purchased as a non-refundable ticket.
        /// </summary>
        /// <returns>string</returns>
        public string isRestrictedTicket()
        {
            return getProperty(GlobalConstants.isRestrictedTicket);
        }

        /// <summary>
        /// Set whether this ticket is non-refundable.
        /// </summary>
        /// <returns>void</returns>
        public void isRestrictedTicket(bool data)
        {
            setProperty(GlobalConstants.isRestrictedTicket, data);
        }

        /// <summary>
        /// TicketBuilder<typeparam name="TBLDR"></typeparam> will allow a TicketBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder
        /// </summary>
        public class TicketBuilder<TBLDR> : NestedJSONBuilder<Ticket, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Ticket builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public TicketBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the ticket number
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> ticketNumber(string data)
            {
                properties[GlobalConstants.ticketNumber] = data;
                return this;
            }

            /// <summary>
            /// Set whether this ticket is non-refundable.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> isRestrictedTicket(bool data)
            {
                properties[GlobalConstants.isRestrictedTicket] = data;
                return this;
            }

        }
    }
}
