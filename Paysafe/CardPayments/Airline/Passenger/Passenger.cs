using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments.Airline.Passenger
{
    public class Passenger : JSONObject
    {
        /// <summary>
        /// Initialize the Passenger object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Passenger(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.ticketNumber, STRING_TYPE },
            {GlobalConstants.firstName, STRING_TYPE },
            {GlobalConstants.lastName, STRING_TYPE },
            {GlobalConstants.phoneNumber, STRING_TYPE },
            {GlobalConstants.passengerCode, STRING_TYPE },
            {GlobalConstants.gender,  GlobalConstants.enumGenderPassenger },
        };

        /// <summary>
        /// Get the ticket for this passenger only.
        /// </summary>
        /// <returns>string</returns>
        public string ticketNumber()
        {
            return getProperty(GlobalConstants.ticketNumber);
        }

        /// <summary>
        /// Set a ticket for this passenger only.
        /// </summary>
        /// <returns>void</returns>
        public void ticketNumber(string data)
        {
            setProperty(GlobalConstants.ticketNumber, data);
        }

        /// <summary>
        /// Get passenger's first name.
        /// </summary>
        /// <returns>string</returns>
        public string firstName()
        {
            return getProperty(GlobalConstants.firstName);
        }

        /// <summary>
        /// Set passenger's first name.
        /// </summary>
        /// <returns>void</returns>
        public void firstName(string data)
        {
            setProperty(GlobalConstants.firstName, data);
        }

        /// <summary>
        /// Get passenger's last name.
        /// </summary>
        /// <returns>string</returns>
        public string lastName()
        {
            return getProperty(GlobalConstants.lastName);
        }

        /// <summary>
        /// Set passenger's lsat name.
        /// </summary>
        /// <returns>void</returns>
        public void lastName(string data)
        {
            setProperty(GlobalConstants.lastName, data);
        }

        /// <summary>
        /// Get passenger's phone number.
        /// </summary>
        /// <returns>string</returns>
        public string phoneNumber()
        {
            return getProperty(GlobalConstants.phoneNumber);
        }

        /// <summary>
        /// Set passenger's phone number.
        /// </summary>
        /// <returns>void</returns>
        public void phoneNumber(string data)
        {
            setProperty(GlobalConstants.phoneNumber, data);
        }

        /// <summary>
        /// Get a code that identifies a type of passenger.
        /// </summary>
        /// <returns>string</returns>
        public string passengerCode()
        {
            return getProperty(GlobalConstants.passengerCode);
        }

        /// <summary>
        /// Set a code that identifies a type of passenger. Ex: INF
        /// </summary>
        /// <returns>void</returns>
        public void passengerCode(string data)
        {
            setProperty(GlobalConstants.passengerCode, data);
        }

        /// <summary>
        /// Get passenger's gender.
        /// </summary>
        /// <returns>string</returns>
        public string gender()
        {
            return getProperty(GlobalConstants.gender);
        }

        /// <summary>
        /// Set passenger's gender. Options: [M – Male, F – Female, O – Other, N – Not Specified]
        /// </summary>
        /// <returns>void</returns>
        public void gender(string data)
        {
            setProperty(GlobalConstants.gender, data);
        }

        /// <summary>
        /// PassengerBuilder<typeparam name="TBLDR"></typeparam> will allow a Passenger to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class PassengerBuilder<TBLDR> : NestedJSONBuilder<Passenger, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the PassengerBuilder builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public PassengerBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set a ticket for this passenger only.
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PassengerBuilder<TBLDR></returns>
            public PassengerBuilder<TBLDR> ticketNumber(string data)
            {
                properties[GlobalConstants.ticketNumber] = data;
                return this;
            }

            /// <summary>
            /// Set passenger's first name
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PassengerBuilder<TBLDR></returns>
            public PassengerBuilder<TBLDR> firstName(string data)
            {
                properties[GlobalConstants.firstName] = data;
                return this;
            }

            /// <summary>
            /// Set passenger's last name
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PassengerBuilder<TBLDR></returns>
            public PassengerBuilder<TBLDR> lastName(string data)
            {
                properties[GlobalConstants.lastName] = data;
                return this;
            }

            /// <summary>
            /// Set passenger's phone number
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PassengerBuilder<TBLDR></returns>
            public PassengerBuilder<TBLDR> phoneNumber(string data)
            {
                properties[GlobalConstants.phoneNumber] = data;
                return this;
            }

            /// <summary>
            /// Set a code that identifies a type of passenger. Ex: INF
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PassengerBuilder<TBLDR></returns>
            public PassengerBuilder<TBLDR> passengerCode(string data)
            {
                properties[GlobalConstants.passengerCode] = data;
                return this;
            }

            /// <summary>
            /// Set passenger's gender. Options: [M – Male, F – Female, O – Other, N – Not Specified]
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>PassengerBuilder<TBLDR></returns>
            public PassengerBuilder<TBLDR> gender(string data)
            {
                properties[GlobalConstants.gender] = data;
                return this;
            }
        }
    }
}
