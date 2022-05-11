using Paysafe.Common;
using System.Collections.Generic;


namespace Paysafe.CardPayments.Airline
{
    public class Passengers : JSONObject
    {
        /// <summary>
        /// Initialize the Passengers object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Passengers(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.passenger1, typeof(Passenger) },
            {GlobalConstants.passenger2, typeof(Passenger) },
            {GlobalConstants.passenger3, typeof(Passenger) },
            {GlobalConstants.passenger4, typeof(Passenger) },
            {GlobalConstants.passenger5, typeof(Passenger) },
            {GlobalConstants.passenger6, typeof(Passenger) },
            {GlobalConstants.passenger7, typeof(Passenger) },
            {GlobalConstants.passenger8, typeof(Passenger) },
            {GlobalConstants.passenger9, typeof(Passenger) },
            {GlobalConstants.passenger10, typeof(Passenger) },
        };

        /// <summary>
        /// Get passenger 1.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger1()
        {
            return getProperty(GlobalConstants.passenger1);
        }

        /// <summary>
        /// Set passenger 1.
        /// </summary>
        /// <returns>void</returns>
        public void passenger1(Passenger data)
        {
            setProperty(GlobalConstants.passenger1, data);
        }

        /// <summary>
        /// Get passenger 2.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger2()
        {
            return getProperty(GlobalConstants.passenger2);
        }

        /// <summary>
        /// Set passenger 2.
        /// </summary>
        /// <returns>void</returns>
        public void passenger2(Passenger data)
        {
            setProperty(GlobalConstants.passenger2, data);
        }

        /// <summary>
        /// Get passenger 3.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger3()
        {
            return getProperty(GlobalConstants.passenger3);
        }

        /// <summary>
        /// Set passenger 3.
        /// </summary>
        /// <returns>void</returns>
        public void passenger3(Passenger data)
        {
            setProperty(GlobalConstants.passenger3, data);
        }

        /// <summary>
        /// Get passenger 4.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger4()
        {
            return getProperty(GlobalConstants.passenger4);
        }

        /// <summary>
        /// Set passenger 4.
        /// </summary>
        /// <returns>void</returns>
        public void passenger4(Passenger data)
        {
            setProperty(GlobalConstants.passenger4, data);
        }

        /// <summary>
        /// Get passenger 5.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger5()
        {
            return getProperty(GlobalConstants.passenger5);
        }

        /// <summary>
        /// Set passenger 5.
        /// </summary>
        /// <returns>void</returns>
        public void passenger5(Passenger data)
        {
            setProperty(GlobalConstants.passenger5, data);
        }

        /// <summary>
        /// Get passenger 6.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger6()
        {
            return getProperty(GlobalConstants.passenger6);
        }

        /// <summary>
        /// Set passenger 6.
        /// </summary>
        /// <returns>void</returns>
        public void passenger6(Passenger data)
        {
            setProperty(GlobalConstants.passenger6, data);
        }

        /// <summary>
        /// Get passenger 7.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger7()
        {
            return getProperty(GlobalConstants.passenger7);
        }

        /// <summary>
        /// Set passenger 7.
        /// </summary>
        /// <returns>void</returns>
        public void passenger7(Passenger data)
        {
            setProperty(GlobalConstants.passenger7, data);
        }

        /// <summary>
        /// Get passenger 8.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger8()
        {
            return getProperty(GlobalConstants.passenger8);
        }

        /// <summary>
        /// Set passenger 8.
        /// </summary>
        /// <returns>void</returns>
        public void passenger8(Passenger data)
        {
            setProperty(GlobalConstants.passenger8, data);
        }

        /// <summary>
        /// Get passenger 9.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger9()
        {
            return getProperty(GlobalConstants.passenger9);
        }

        /// <summary>
        /// Set passenger 9.
        /// </summary>
        /// <returns>void</returns>
        public void passenger9(Passenger data)
        {
            setProperty(GlobalConstants.passenger9, data);
        }

        /// <summary>
        /// Get passenger 10.
        /// </summary>
        /// <returns>Passenger</returns>
        public Passenger passenger10()
        {
            return getProperty(GlobalConstants.passenger10);
        }

        /// <summary>
        /// Set passenger 10.
        /// </summary>
        /// <returns>void</returns>
        public void passenger10(Passenger data)
        {
            setProperty(GlobalConstants.passenger10, data);
        }

        /// <summary>
        /// PassengersBuilder<typeparam name="TBLDR"></typeparam> will allow Passengers to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class PassengersBuilder<TBLDR> : NestedJSONBuilder<Passengers, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the PassengersBuilder builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public PassengersBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set passenger 1.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger1()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger1))
                {
                    properties[GlobalConstants.passenger1] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger1] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 2.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger2()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger2))
                {
                    properties[GlobalConstants.passenger2] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger2] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 3.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger3()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger3))
                {
                    properties[GlobalConstants.passenger3] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger3] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 4.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger4()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger4))
                {
                    properties[GlobalConstants.passenger4] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger4] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 5.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger5()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger5))
                {
                    properties[GlobalConstants.passenger5] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger5] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 6.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger6()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger6))
                {
                    properties[GlobalConstants.passenger6] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger6] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 7.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returnsPassenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger7()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger7))
                {
                    properties[GlobalConstants.passenger7] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger7] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 8.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger8()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger8))
                {
                    properties[GlobalConstants.passenger8] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger8] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 9.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger9()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger9))
                {
                    properties[GlobalConstants.passenger9] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger9] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set passenger 10.
            /// </summary>
            /// <param name=data>Passenger</param>
            /// <returns>Passenger.PassengerBuilder<PassengersBuilder<TBLDR>></returns>
            public Passenger.PassengerBuilder<PassengersBuilder<TBLDR>> passenger10()
            {
                if (!properties.ContainsKey(GlobalConstants.passenger10))
                {
                    properties[GlobalConstants.passenger10] = new Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.passenger10] as Passenger.PassengerBuilder<PassengersBuilder<TBLDR>>;
            }
        }
    }
}
