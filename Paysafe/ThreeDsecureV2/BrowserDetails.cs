using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class BrowserDetails : JSONObject
    {

        /// <summary>
        /// Initialize the BrowserDetails object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public BrowserDetails(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.acceptHeader, STRING_TYPE},
            {ThreeDSecureV2Constants.colorDepthBits, ThreeDSecureV2Constants.enumColorDepthBits },
            {ThreeDSecureV2Constants.javaEnabled, BOOL_TYPE},  
            {ThreeDSecureV2Constants.customerIp, STRING_TYPE},
            {ThreeDSecureV2Constants.javascriptEnabled, BOOL_TYPE},
            {ThreeDSecureV2Constants.language, STRING_TYPE},  
            {ThreeDSecureV2Constants.screenHeight, INT_TYPE},  
            {ThreeDSecureV2Constants.screenWidth, INT_TYPE},  
            {ThreeDSecureV2Constants.timezoneOffset, INT_TYPE},  
            {ThreeDSecureV2Constants.userAgent, STRING_TYPE},                          
          };

        /// <summary>
        /// Get the acceptHeader
        /// </summary>
        /// <returns>string</returns>
        public bool acceptHeader()
        {
            return this.getProperty(ThreeDSecureV2Constants.acceptHeader);
        }

        /// <summary>
        /// Set the acceptHeader
        /// </summary>
        /// <returns>void</returns>
        public void acceptHeader(String data)
        {
            this.setProperty(ThreeDSecureV2Constants.acceptHeader, data);
        }

        /// <summary>
        /// Get the colorDepthBits
        /// </summary>
        /// <returns>string</returns>
        public string colorDepthBits()
        {
            return this.getProperty(ThreeDSecureV2Constants.colorDepthBits);
        }

        /// <summary>
        /// Set the colorDepthBits
        /// </summary>
        /// <returns>void</returns>
        public void colorDepthBits(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.colorDepthBits, data);
        }

        /// <summary>
        /// Get the customerIp
        /// </summary>
        /// <returns>string</returns>
        public string customerIp()
        {
            return this.getProperty(ThreeDSecureV2Constants.customerIp);
        }

        /// <summary>
        /// Set the customerIp
        /// </summary>
        /// <returns>void</returns>
        public void customerIp(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.customerIp, data);
        }


        /// <summary>
        /// Get the javaEnabled
        /// </summary>
        /// <returns>bool</returns>
        public bool javaEnabled()
        {
            return this.getProperty(ThreeDSecureV2Constants.javaEnabled);
        }

        /// <summary>
        /// Set the javaEnabled
        /// </summary>
        /// <returns>void</returns>
        public void javaEnabled(bool data)
        {
            this.setProperty(ThreeDSecureV2Constants.javaEnabled, data);
        }


        /// <summary>
        /// Get the javascriptEnabled
        /// </summary>
        /// <returns>bool</returns>
        public bool javascriptEnabled()
        {
            return this.getProperty(ThreeDSecureV2Constants.javascriptEnabled);
        }

        /// <summary>
        /// Set the javascriptEnabled
        /// </summary>
        /// <returns>void</returns>
        public void javascriptEnabled(bool data)
        {
            this.setProperty(ThreeDSecureV2Constants.javascriptEnabled, data);
        }


        /// <summary>
        /// Get the language
        /// </summary>
        /// <returns>string</returns>
        public string language()
        {
            return this.getProperty(ThreeDSecureV2Constants.language);
        }

        /// <summary>
        /// Set the language
        /// </summary>
        /// <returns>void</returns>
        public void language(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.language, data);
        }

        /// <summary>
        /// Get the screenHeight
        /// </summary>
        /// <returns>int</returns>
        public string screenHeight()
        {
            return this.getProperty(ThreeDSecureV2Constants.screenHeight);
        }

        /// <summary>
        /// Set the screenHeight
        /// </summary>
        /// <returns>void</returns>
        public void screenHeight(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.screenHeight, data);
        }

        /// <summary>
        /// Get the screenWidth
        /// </summary>
        /// <returns>int</returns>
        public int screenWidth()
        {
            return this.getProperty(ThreeDSecureV2Constants.screenWidth);
        }

        /// <summary>
        /// Set the screenWidth
        /// </summary>
        /// <returns>void</returns>
        public void screenWidth(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.screenWidth, data);
        }


        /// <summary>
        /// Get the timezoneOffset
        /// </summary>
        /// <returns>int</returns>
        public string timezoneOffset()
        {
            return this.getProperty(ThreeDSecureV2Constants.timezoneOffset);
        }

        /// <summary>
        /// Set the timezoneOffset
        /// </summary>
        /// <returns>void</returns>
        public void timezoneOffset(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.timezoneOffset, data);
        }


        /// <summary>
        /// Get the userAgent
        /// </summary>
        /// <returns>string</returns>
        public string userAgent()
        {
            return this.getProperty(ThreeDSecureV2Constants.userAgent);
        }

        /// <summary>
        /// Set the userAgent
        /// </summary>
        /// <returns>void</returns>
        public void userAgent(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.userAgent, data);
        }

        /// <summary>
        /// BrowserDetailsBuilder<typeparam name="TBLDR"></typeparam> will allow an BrowserDetails to be initialized
        /// within another builder. Set properties and subpropeties, then trigger .Done() to 
        /// get back tot he parent builder
        /// </summary>
        public class BrowserDetailsBuilder<TBLDR> : NestedJSONBuilder<BrowserDetails, TBLDR>
            where TBLDR : GenericJSONBuilder
        {
            /// <summary>
            /// Initialize the BrowserDetails builder within the context of a parent builder
            /// </summary>
            /// <param name="parent">TBLDR</param>
            public BrowserDetailsBuilder(TBLDR parent)
                : base(parent)
            {
                this.parent = parent;
            }

            /// <summary>
            /// Set the acceptHeader
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> acceptHeader(string data)
            {
                this.properties[ThreeDSecureV2Constants.acceptHeader] = data;
                return this;
            }

            /// <summary>
            /// Set the colorDepthBits
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> colorDepthBits(string data)
            {
                this.properties[ThreeDSecureV2Constants.colorDepthBits] = data;
                return this;
            }

            /// <summary>
            /// Set the customerIp
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> customerIp(string data)
            {
                this.properties[ThreeDSecureV2Constants.customerIp] = data;
                return this;
            }

            /// <summary>
            /// Set the javaEnabled
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> javaEnabled(bool data)
            {
                this.properties[ThreeDSecureV2Constants.javaEnabled] = data;
                return this;
            }

            /// <summary>
            /// Set the javascriptEnabled
            /// </summary>
            /// <param name=data>bool</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> javascriptEnabled(bool data)
            {
                this.properties[ThreeDSecureV2Constants.javascriptEnabled] = data;
                return this;
            }

            /// <summary>
            /// Set the language
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> language(string data)
            {
                this.properties[ThreeDSecureV2Constants.language] = data;
                return this;
            }

            /// <summary>
            /// Set the screenHeight
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> screenHeight(int data)
            {
                this.properties[ThreeDSecureV2Constants.screenHeight] = data;
                return this;
            }

            /// <summary>
            /// Set the screenWidth
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> screenWidth(int data)
            {
                this.properties[ThreeDSecureV2Constants.screenWidth] = data;
                return this;
            }

            /// <summary>
            /// Set the timezoneOffset
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> timezoneOffset(int data)
            {
                this.properties[ThreeDSecureV2Constants.timezoneOffset] = data;
                return this;
            }

            /// <summary>
            /// Set the userAgent
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>BrowserDetailsBuilder<TBLDR></returns>
            public BrowserDetailsBuilder<TBLDR> userAgent(string data)
            {
                this.properties[ThreeDSecureV2Constants.userAgent] = data;
                return this;
            }
        }
    }
}
