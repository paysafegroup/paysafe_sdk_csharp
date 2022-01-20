using Paysafe.Common;
using System.Collections.Generic;

namespace Paysafe.CardPayments
{
    public class TripLegs : JSONObject
    {
        /// <summary>
        /// Initialize the Trip legs object with some set of properties.
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public TripLegs(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {GlobalConstants.leg1, typeof(Leg) },
            {GlobalConstants.leg2, typeof(Leg) },
            {GlobalConstants.leg3, typeof(Leg) },
            {GlobalConstants.leg4, typeof(Leg) },
        };

        /// <summary>
        ///  Get the first leg of trip.
        /// </summary>
        /// <returns>Leg</returns>
        public Leg leg1()
        {
            return getProperty(GlobalConstants.leg1);
        }

        /// <summary>
        /// Set the first leg of the trip.
        /// </summary>
        /// <returns>void</returns>
        public void leg1(Leg data)
        {
            setProperty(GlobalConstants.leg1, data);
        }

        /// <summary>
        ///  Get the second leg of trip.
        /// </summary>
        /// <returns>Leg</returns>
        public Leg leg2()
        {
            return getProperty(GlobalConstants.leg2);
        }

        /// <summary>
        /// Set the second leg of the trip.
        /// </summary>
        /// <returns>void</returns>
        public void leg2(Leg data)
        {
            setProperty(GlobalConstants.leg2, data);
        }

        /// <summary>
        ///  Get the third leg of trip.
        /// </summary>
        /// <returns>Leg</returns>
        public Leg leg3()
        {
            return getProperty(GlobalConstants.leg3);
        }

        /// <summary>
        /// Set the third leg of the trip.
        /// </summary>
        /// <returns>void</returns>
        public void leg3(Leg data)
        {
            setProperty(GlobalConstants.leg3, data);
        }

        /// <summary>
        ///  Get the fourth leg of trip.
        /// </summary>
        /// <returns>Leg</returns>
        public Leg leg4()
        {
            return getProperty(GlobalConstants.leg4);
        }

        /// <summary>
        /// Set the fourth leg of the trip.
        /// </summary>
        /// <returns>void</returns>
        public void leg4(Leg data)
        {
            setProperty(GlobalConstants.leg4, data);
        }

        /// <summary>
        /// TripLegsBuilder<typeparam name="TBLDR"></typeparam> will allow a TripLegsBuilder to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back to the parent builder.
        /// </summary>
        public class TripLegsBuilder<TBLDR> : NestedJSONBuilder<TripLegs, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the Trip legs builder within the context of a parent builder.
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public TripLegsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the first leg of the trip.
            /// </summary>
            /// <returns>Leg.LegBuilder<TripLegsBuilder<TBLDR>></returns>
            public Leg.LegBuilder<TripLegsBuilder<TBLDR>> leg1()
            {
                if (!properties.ContainsKey(GlobalConstants.leg1))
                {
                    properties[GlobalConstants.leg1] = new Leg.LegBuilder<TripLegsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.leg1] as Leg.LegBuilder<TripLegsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set the second leg of the trip.
            /// </summary>
            /// <returns>Leg.LegBuilder<TripLegsBuilder<TBLDR>></returns>
            public Leg.LegBuilder<TripLegsBuilder<TBLDR>> leg2()
            {
                if (!properties.ContainsKey(GlobalConstants.leg2))
                {
                    properties[GlobalConstants.leg2] = new Leg.LegBuilder<TripLegsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.leg2] as Leg.LegBuilder<TripLegsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set the third leg of the trip.
            /// </summary>
            /// <returns>Leg.LegBuilder<TripLegsBuilder<TBLDR>></returns>
            public Leg.LegBuilder<TripLegsBuilder<TBLDR>> leg3()
            {
                if (!properties.ContainsKey(GlobalConstants.leg3))
                {
                    properties[GlobalConstants.leg3] = new Leg.LegBuilder<TripLegsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.leg3] as Leg.LegBuilder<TripLegsBuilder<TBLDR>>;
            }

            /// <summary>
            /// Set the forth leg of the trip.
            /// </summary>
            /// <returns>Leg.LegBuilder<TripLegsBuilder<TBLDR>></returns>
            public Leg.LegBuilder<TripLegsBuilder<TBLDR>> leg4()
            {
                if (!properties.ContainsKey(GlobalConstants.leg4))
                {
                    properties[GlobalConstants.leg4] = new Leg.LegBuilder<TripLegsBuilder<TBLDR>>(this);
                }
                return properties[GlobalConstants.leg4] as Leg.LegBuilder<TripLegsBuilder<TBLDR>>;
            }
        }
    }
}
