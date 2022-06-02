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
            {GlobalConstants.cityOfTicketIssuing, STRING_TYPE },
            {GlobalConstants.ticketDeliveryMethod, GlobalConstants.enumTicketDeliveryMethod },
            {GlobalConstants.isAgencyCard, BOOL_TYPE },
            {GlobalConstants.ticketIssueDate, STRING_TYPE },
            {GlobalConstants.ticketPrice, INT_TYPE },
            {GlobalConstants.numberOfPax, INT_TYPE },
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
        /// Set airline ticket number.
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
        /// <returns>bool</returns>
        public bool isRestrictedTicket()
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
        ///  Place of issue for the ticket for this passenger.
        /// </summary>
        /// <returns>string</returns>
        public string cityOfTicketIssuing()
        {
            return getProperty(GlobalConstants.cityOfTicketIssuing);
        }

        /// <summary>
        /// Set place of issue for the ticket for this passenger.
        /// </summary>
        /// <returns>void</returns>
        public void cityOfTicketIssuing(string data)
        {
            setProperty(GlobalConstants.cityOfTicketIssuing, data);
        }

        /// <summary>
        /// The way of delivering the ticket.
        /// </summary>
        /// <returns>string</returns>
        public string ticketDeliveryMethod()
        {
            return getProperty(GlobalConstants.ticketDeliveryMethod);
        }

        /// <summary>
        /// Set way of delivering the ticket. (ex: E_TICKET)
        /// </summary>
        /// <returns>void</returns>
        public void ticketDeliveryMethod(string data)
        {
            setProperty(GlobalConstants.ticketDeliveryMethod, data);
        }

        /// <summary>
        /// Specifies whether the purchaser is the ticket holder or agency.
        /// </summary>
        /// <returns>bool</returns>
        public bool isAgencyCard()
        {
            return getProperty(GlobalConstants.isAgencyCard);
        }

        /// <summary>
        /// Specifies whether the purchaser is the ticket holder or agency.
        /// </summary>
        /// <returns>void</returns>
        public void isAgencyCard(bool data)
        {
            setProperty(GlobalConstants.isAgencyCard, data);
        }

        /// <summary>
        /// Ticket's issue date. Sometimes it is different that the date of the transaction (can be before that). Format: yyyy-MM-dd
        /// </summary>
        /// <returns>string</returns>
        public string ticketIssueDate()
        {
            return getProperty(GlobalConstants.ticketIssueDate);
        }

        /// <summary>
        /// Ticket's issue date. Sometimes it is different that the date of the transaction (can be before that). Format: yyyy-MM-dd
        /// </summary>
        /// <returns>void</returns>
        public void ticketIssueDate(string data)
        {
            setProperty(GlobalConstants.ticketIssueDate, data);
        }

        /// <summary>
        /// Price for one ticket.
        /// </summary>
        /// <returns>int</returns>
        public int ticketPrice()
        {
            return getProperty(GlobalConstants.ticketPrice);
        }

        /// <summary>
        /// Price for one ticket.
        /// </summary>
        /// <returns>void</returns>
        public void ticketPrice(int data)
        {
            setProperty(GlobalConstants.ticketPrice, data);
        }

        /// <summary>
        /// The number of the passengers which tickets are with the same PNR.
        /// </summary>
        /// <returns>int</returns>
        public int numberOfPax()
        {
            return getProperty(GlobalConstants.numberOfPax);
        }

        /// <summary>
        /// The number of the passengers which tickets are with the same PNR.
        /// </summary>
        /// <returns>void</returns>
        public void numberOfPax(int data)
        {
            setProperty(GlobalConstants.numberOfPax, data);
        }

        /// <summary>
        /// TicketBuilder<typeparam name="TBLDR"></typeparam> will allow a TicketBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
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
            /// Set the ticket number.
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
            /// <param name=data>bool</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> isRestrictedTicket(bool data)
            {
                properties[GlobalConstants.isRestrictedTicket] = data;
                return this;
            }

            /// <summary>
            /// Set place of issue for the ticket for this passenger.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> cityOfTicketIssuing(string data)
            {
                properties[GlobalConstants.cityOfTicketIssuing] = data;
                return this;
            }

            /// <summary>
            /// Set way of delivering the ticket. (ex: E_TICKET)
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> ticketDeliveryMethod(string data)
            {
                properties[GlobalConstants.ticketDeliveryMethod] = data;
                return this;
            }

            /// <summary>
            /// Specifies whether the purchaser is the ticket holder or agency.
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> isAgencyCard(bool data)
            {
                properties[GlobalConstants.isAgencyCard] = data;
                return this;
            }

            /// <summary>
            /// Ticket's issue date. Sometimes it is different that the date of the transaction (can be before that). Format: yyyy-MM-dd
            /// </summary>
            /// <param name=data>sring</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> ticketIssueDate(string data)
            {
                properties[GlobalConstants.ticketIssueDate] = data;
                return this;
            }

            /// <summary>
            /// Price for one ticket.
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> ticketPrice(int data)
            {
                properties[GlobalConstants.ticketPrice] = data;
                return this;
            }

            /// <summary>
            /// The number of the passengers which tickets are with the same PNR.
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>TicketBuilder<TBLDR></returns>
            public TicketBuilder<TBLDR> numberOfPax(int data)
            {
                properties[GlobalConstants.numberOfPax] = data;
                return this;
            }
        }
    }
}
