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
            {CardPaymentsConstants.ticketNumber, STRING_TYPE}
        };


        /// <summary>
        ///  Get airline ticket number.
        /// </summary>
        /// <returns>string</returns>
        public string ticketNumber()
        {
            return getProperty(CardPaymentsConstants.ticketNumber);
        }

        /// <summary>
        /// Set airline ticket number
        /// </summary>
        /// <returns>void</returns>
        public void ticketNumber(string data)
        {
            setProperty(CardPaymentsConstants.ticketNumber, data);
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
                this.properties[CardPaymentsConstants.ticketNumber] = data;
                return this;
            }

        }
    }
}
