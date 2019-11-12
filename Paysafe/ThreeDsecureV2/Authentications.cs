using Paysafe.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Paysafe.ThreeDsecureV2
{
    public class Authentications : JSONObject
    {
        /// <summary>
        /// Initialize the Authentications object with some set of properties
        /// </summary>
        /// <param name="properties">Dictionary<string, object></param>
        public Authentications(Dictionary<string, object> properties = null)
            : base(fieldTypes, properties)
        {
        }

        private static new Dictionary<string, object> fieldTypes = new Dictionary<string, object>
        {
            {ThreeDSecureV2Constants.id, STRING_TYPE},
            {ThreeDSecureV2Constants.deviceFingerprintingId, STRING_TYPE},
            {ThreeDSecureV2Constants.merchantRefNum, STRING_TYPE},
            {ThreeDSecureV2Constants.amount,LONG_TYPE},
            {ThreeDSecureV2Constants.currency, STRING_TYPE},
            {ThreeDSecureV2Constants.card,typeof(Card)},
            {ThreeDSecureV2Constants.merchantUrl, STRING_TYPE},
            {ThreeDSecureV2Constants.txnTime, typeof(DateTime)},
            {ThreeDSecureV2Constants.error, typeof(Error)},
            {ThreeDSecureV2Constants.status, ThreeDSecureV2Constants.enumStatus},
            {ThreeDSecureV2Constants.acsURL, STRING_TYPE},
            {ThreeDSecureV2Constants.payload, STRING_TYPE},
            {ThreeDSecureV2Constants.threeDEnrollment, ThreeDSecureV2Constants.enumThreeDEnrollment},
            {ThreeDSecureV2Constants.threeDResult, ThreeDSecureV2Constants.enumThreeDResult},
            {ThreeDSecureV2Constants.threeDSecureVersion, STRING_TYPE},
            {ThreeDSecureV2Constants.directoryServerTransactionId, STRING_TYPE},
            {ThreeDSecureV2Constants.eci, INT_TYPE},
            {ThreeDSecureV2Constants.cavv, STRING_TYPE},
            {ThreeDSecureV2Constants.xid, STRING_TYPE},
            {ThreeDSecureV2Constants.sdkChallengePayload, STRING_TYPE},
            {ThreeDSecureV2Constants.transactionIntent, ThreeDSecureV2Constants.enumTransactionIntent},
            {ThreeDSecureV2Constants.maxAuthorizationsForInstalmentPayment, INT_TYPE},
            {ThreeDSecureV2Constants.authenticationPurpose, ThreeDSecureV2Constants.enumAuthenticationPurpose},
            {ThreeDSecureV2Constants.deviceChannel, ThreeDSecureV2Constants.enumDeviceChannel},
            {ThreeDSecureV2Constants.messageCategory, ThreeDSecureV2Constants.enumMessageCategory},
            {ThreeDSecureV2Constants.initialPurchaseTime, STRING_TYPE},
            {ThreeDSecureV2Constants.requestorChallengePreference, ThreeDSecureV2Constants.enumRequestorChallengePreference}, 
            {ThreeDSecureV2Constants.electronicDelivery, typeof(ElectronicDelivery)}, 
            {ThreeDSecureV2Constants.orderItemDetails, typeof(OrderItemDetails)}, 
            {ThreeDSecureV2Constants.purchasedGiftCardDetails, typeof(PurchasedGiftCardDetails)}, 
            {ThreeDSecureV2Constants.billingCycle, typeof(BillingCycle)},
            {ThreeDSecureV2Constants.browserDetails, typeof(BrowserDetails)},
            {ThreeDSecureV2Constants.userAccountDetails, typeof(UserAccountDetails)},
            {ThreeDSecureV2Constants.billingDetails, typeof(BillingDetails)},
            {ThreeDSecureV2Constants.shippingDetails, typeof(ShippingDetails)},
            {ThreeDSecureV2Constants.profile, typeof(Profile)},
            {ThreeDSecureV2Constants.signatureStatus, ThreeDSecureV2Constants.enumSignatureStatus},
            {ThreeDSecureV2Constants.threeDSecureServerTransactionId, STRING_TYPE},
            {ThreeDSecureV2Constants.mcc, STRING_TYPE},
            {ThreeDSecureV2Constants.merchantName, STRING_TYPE}

        };

        /// <summary>
        /// Get the id
        /// </summary>
        /// <returns>string</returns>
        public string id()
        {
            return this.getProperty(ThreeDSecureV2Constants.id);
        }

        /// <summary>
        /// Set the id
        /// </summary>
        /// <turns>void</returns>
        public void id(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.id, data);
        }


        /// <summary>
        /// Get the deviceFingerprintingId
        /// </summary>
        /// <returns>string</returns>
        public string deviceFingerprintingId()
        {
            return this.getProperty(ThreeDSecureV2Constants.deviceFingerprintingId);
        }

        /// <summary>
        /// Set the deviceFingerprintingId
        /// </summary>
        /// <turns>void</returns>
        public void deviceFingerprintingId(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.deviceFingerprintingId, data);
        }

        /// <summary>
        /// Get the merchantRefNum
        /// </summary>
        /// <returns>string</returns>
        public string merchantRefNum()
        {
            return this.getProperty(ThreeDSecureV2Constants.merchantRefNum);
        }

        /// <summary>
        /// Set the merchantRefNum
        /// </summary>
        /// <turns>void</returns>
        public void merchantRefNum(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.merchantRefNum, data);
        }

        /// <summary>
        /// Get the amount
        /// </summary>
        /// <returns>long</returns>
        public long amount()
        {
            return this.getProperty(ThreeDSecureV2Constants.amount);
        }

        /// <summary>
        /// Set the amount
        /// </summary>
        /// <turns>void</returns>
        public void amount(long data)
        {
            this.setProperty(ThreeDSecureV2Constants.amount, data);
        }

        /// <summary>
        /// Get the currency
        /// </summary>
        /// <returns>string</returns>
        public string currency()
        {
            return this.getProperty(ThreeDSecureV2Constants.currency);
        }

        /// <summary>
        /// Set the currency
        /// </summary>
        /// <turns>void</returns>
        public void currency(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.currency, data);
        }

        /// <summary>
        /// Get the card
        /// </summary>
        /// <returns>Card</returns>
        public Card card()
        {
            return this.getProperty(ThreeDSecureV2Constants.card);
        }

        /// <summary>
        /// Set the card
        /// </summary>
        /// <turns>void</returns>
        public void card(Card data)
        {
            this.setProperty(ThreeDSecureV2Constants.card, data);
        }


        /// <summary>
        /// Get the merchantUrl
        /// </summary>
        /// <returns>string</returns>
        public string merchantUrl()
        {
            return this.getProperty(ThreeDSecureV2Constants.merchantUrl);
        }

        /// <summary>
        /// Set the merchantUrl
        /// </summary>
        /// <turns>void</returns>
        public void merchantUrl(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.merchantUrl, data);
        }


        /// <summary>
        /// Get the txnTime
        /// </summary>
        /// <returns>string</returns>
        public DateTime txnTime()
        {
            return this.getProperty(ThreeDSecureV2Constants.txnTime);
        }

        /// <summary>
        /// Set the txnTime
        /// </summary>
        /// <turns>void</returns>
        public void txnTime(DateTime data)
        {
            this.setProperty(ThreeDSecureV2Constants.txnTime, data);
        }


        /// <summary>
        /// Get the error
        /// </summary>
        /// <returns>Error</returns>
        public Error error()
        {
            return this.getProperty(ThreeDSecureV2Constants.error);
        }

        /// <summary>
        /// Set the error
        /// </summary>
        /// <turns>void</returns>
        public void error(Error data)
        {
            this.setProperty(ThreeDSecureV2Constants.error, data);
        }

        /// <summary>
        /// Get the status
        /// </summary>
        /// <returns>string</returns>
        public string status()
        {
            return this.getProperty(ThreeDSecureV2Constants.status);
        }

        /// <summary>
        /// Set the status
        /// </summary>
        /// <turns>void</returns>
        public void status(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.status, data);
        }

        /// <summary>
        /// Get the acsURL
        /// </summary>
        /// <returns>string</returns>
        public string acsURL()
        {
            return this.getProperty(ThreeDSecureV2Constants.acsURL);
        }

        /// <summary>
        /// Set the acsURL
        /// </summary>
        /// <turns>void</returns>
        public void acsURL(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.acsURL, data);
        }

        /// <summary>
        /// Get the payload
        /// </summary>
        /// <returns>string</returns>
        public string payload()
        {
            return this.getProperty(ThreeDSecureV2Constants.payload);
        }

        /// <summary>
        /// Set the payload
        /// </summary>
        /// <turns>void</returns>
        public void payload(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.payload, data);
        }

        /// <summary>
        /// Get the threeDEnrollment
        /// </summary>
        /// <returns>string</returns>
        public string threeDEnrollment()
        {
            return this.getProperty(ThreeDSecureV2Constants.threeDEnrollment);
        }

        /// <summary>
        /// Set the threeDEnrollment
        /// </summary>
        /// <turns>void</returns>
        public void threeDEnrollment(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.threeDEnrollment, data);
        }


        /// <summary>
        /// Get the threeDResult
        /// </summary>
        /// <returns>string</returns>
        public string threeDResult()
        {
            return this.getProperty(ThreeDSecureV2Constants.threeDResult);
        }

        /// <summary>
        /// Set the threeDResult
        /// </summary>
        /// <turns>void</returns>
        public void threeDResult(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.threeDResult, data);
        }


        /// <summary>
        /// Get the threeDSecureVersion
        /// </summary>
        /// <returns>string</returns>
        public string threeDSecureVersion()
        {
            return this.getProperty(ThreeDSecureV2Constants.threeDSecureVersion);
        }

        /// <summary>
        /// Set the threeDSecureVersion
        /// </summary>
        /// <turns>void</returns>
        public void threeDSecureVersion(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.threeDSecureVersion, data);
        }

        /// <summary>
        /// Get the directoryServerTransactionId
        /// </summary>
        /// <returns>string</returns>
        public string directoryServerTransactionId()
        {
            return this.getProperty(ThreeDSecureV2Constants.directoryServerTransactionId);
        }

        /// <summary>
        /// Set the directoryServerTransactionId
        /// </summary>
        /// <turns>void</returns>
        public void directoryServerTransactionId(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.directoryServerTransactionId, data);
        }

        /// <summary>
        /// Get the eci
        /// </summary>
        /// <returns>int</returns>
        public int eci()
        {
            return this.getProperty(ThreeDSecureV2Constants.eci);
        }

        /// <summary>
        /// Set the eci
        /// </summary>
        /// <turns>void</returns>
        public void eci(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.eci, data);
        }

        /// <summary>
        /// Get the cavv
        /// </summary>
        /// <returns>string</returns>
        public string cavv()
        {
            return this.getProperty(ThreeDSecureV2Constants.cavv);
        }

        /// <summary>
        /// Set the cavv
        /// </summary>
        /// <turns>void</returns>
        public void cavv(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.cavv, data);
        }

        /// <summary>
        /// Get the xid
        /// </summary>
        /// <returns>string</returns>
        public string xid()
        {
            return this.getProperty(ThreeDSecureV2Constants.xid);
        }

        /// <summary>
        /// Set the xid
        /// </summary>
        /// <turns>void</returns>
        public void xid(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.xid, data);
        }

        /// <summary>
        /// Get the sdkChallengePayload
        /// </summary>
        /// <returns>string</returns>
        public string sdkChallengePayload()
        {
            return this.getProperty(ThreeDSecureV2Constants.sdkChallengePayload);
        }

        /// <summary>
        /// Set the sdkChallengePayload
        /// </summary>
        /// <turns>void</returns>
        public void sdkChallengePayload(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.sdkChallengePayload, data);
        }


        /// <summary>
        /// Get the transactionIntent
        /// </summary>
        /// <returns>string</returns>
        public string transactionIntent()
        {
            return this.getProperty(ThreeDSecureV2Constants.transactionIntent);
        }

        /// <summary>
        /// Set the transactionIntent
        /// </summary>
        /// <turns>void</returns>
        public void transactionIntent(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.transactionIntent, data);
        }


        /// <summary>
        /// Get the maxAuthorizationsForInstalmentPayment
        /// </summary>
        /// <returns>int</returns>
        public int maxAuthorizationsForInstalmentPayment()
        {
            return this.getProperty(ThreeDSecureV2Constants.maxAuthorizationsForInstalmentPayment);
        }

        /// <summary>
        /// Set the maxAuthorizationsForInstalmentPayment
        /// </summary>
        /// <turns>void</returns>
        public void maxAuthorizationsForInstalmentPayment(int data)
        {
            this.setProperty(ThreeDSecureV2Constants.maxAuthorizationsForInstalmentPayment, data);
        }


        /// <summary>
        /// Get the authenticationPurpose
        /// </summary>
        /// <returns>string</returns>
        public string authenticationPurpose()
        {
            return this.getProperty(ThreeDSecureV2Constants.authenticationPurpose);
        }

        /// <summary>
        /// Set the authenticationPurpose
        /// </summary>
        /// <turns>void</returns>
        public void authenticationPurpose(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.authenticationPurpose, data);
        }


        /// <summary>
        /// Get the deviceChannel
        /// </summary>
        /// <returns>string</returns>
        public string deviceChannel()
        {
            return this.getProperty(ThreeDSecureV2Constants.deviceChannel);
        }

        /// <summary>
        /// Set the deviceChannel
        /// </summary>
        /// <turns>void</returns>
        public void deviceChannel(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.deviceChannel, data);
        }


        /// <summary>
        /// Get the messageCategory
        /// </summary>
        /// <returns>string</returns>
        public string messageCategory()
        {
            return this.getProperty(ThreeDSecureV2Constants.messageCategory);
        }

        /// <summary>
        /// Set the messageCategory
        /// </summary>
        /// <turns>void</returns>
        public void messageCategory(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.messageCategory, data);
        }


        /// <summary>
        /// Get the initialPurchaseTime
        /// </summary>
        /// <returns>string</returns>
        public string initialPurchaseTime()
        {
            return this.getProperty(ThreeDSecureV2Constants.initialPurchaseTime);
        }

        /// <summary>
        /// Set the initialPurchaseTime
        /// </summary>
        /// <turns>void</returns>
        public void initialPurchaseTime(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.initialPurchaseTime, data);
        }


        /// <summary>
        /// Get the requestorChallengePreference
        /// </summary>
        /// <returns>string</returns>
        public string requestorChallengePreference()
        {
            return this.getProperty(ThreeDSecureV2Constants.requestorChallengePreference);
        }

        /// <summary>
        /// Set the requestorChallengePreference
        /// </summary>
        /// <turns>void</returns>
        public void requestorChallengePreference(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.requestorChallengePreference, data);
        }


        /// <summary>
        /// Get the electronicDelivery
        /// </summary>
        /// <returns>ElectronicDelivery</returns>
        public ElectronicDelivery electronicDelivery()
        {
            return this.getProperty(ThreeDSecureV2Constants.electronicDelivery);
        }

        /// <summary>
        /// Set the electronicDelivery
        /// </summary>
        /// <turns>void</returns>
        public void electronicDelivery(ElectronicDelivery data)
        {
            this.setProperty(ThreeDSecureV2Constants.electronicDelivery, data);
        }



        /// <summary>
        /// Get the orderItemDetails
        /// </summary>
        /// <returns>OrderItemDetails</returns>
        public OrderItemDetails orderItemDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.orderItemDetails);
        }

        /// <summary>
        /// Set the orderItemDetails
        /// </summary>
        /// <turns>void</returns>
        public void orderItemDetails(OrderItemDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.orderItemDetails, data);
        }


        /// <summary>
        /// Get the purchasedGiftCardDetails
        /// </summary>
        /// <returns>PurchasedGiftCardDetails</returns>
        public PurchasedGiftCardDetails purchasedGiftCardDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.purchasedGiftCardDetails);
        }

        /// <summary>
        /// Set the purchasedGiftCardDetails
        /// </summary>
        /// <turns>void</returns>
        public void purchasedGiftCardDetails(PurchasedGiftCardDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.purchasedGiftCardDetails, data);
        }


        /// <summary>
        /// Get the billingCycle
        /// </summary>
        /// <returns>BillingCycle</returns>
        public BillingCycle billingCycle()
        {
            return this.getProperty(ThreeDSecureV2Constants.billingCycle);
        }

        /// <summary>
        /// Set the billingCycle
        /// </summary>
        /// <turns>void</returns>
        public void billingCycle(BillingCycle data)
        {
            this.setProperty(ThreeDSecureV2Constants.billingCycle, data);
        }


        /// <summary>
        /// Get the browserDetails
        /// </summary>
        /// <returns>BrowserDetails</returns>
        public BrowserDetails browserDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.browserDetails);
        }

        /// <summary>
        /// Set the browserDetails
        /// </summary>
        /// <turns>void</returns>
        public void browserDetails(BrowserDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.browserDetails, data);
        }


        /// <summary>
        /// Get the userAccountDetails
        /// </summary>
        /// <returns>UserAccountDetails</returns>
        public UserAccountDetails userAccountDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.userAccountDetails);
        }

        /// <summary>
        /// Set the userAccountDetails
        /// </summary>
        /// <turns>void</returns>
        public void userAccountDetails(UserAccountDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.userAccountDetails, data);
        }



        /// <summary>
        /// Get the billingDetails
        /// </summary>
        /// <returns>BillingDetails</returns>
        public BillingDetails billingDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.billingDetails);
        }

        /// <summary>
        /// Set the billingDetails
        /// </summary>
        /// <turns>void</returns>
        public void billingDetails(BillingDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.billingDetails, data);
        }


        /// <summary>
        /// Get the shippingDetails
        /// </summary>
        /// <returns>ShippingDetails</returns>
        public ShippingDetails shippingDetails()
        {
            return this.getProperty(ThreeDSecureV2Constants.shippingDetails);
        }

        /// <summary>
        /// Set the shippingDetails
        /// </summary>
        /// <turns>void</returns>
        public void shippingDetails(ShippingDetails data)
        {
            this.setProperty(ThreeDSecureV2Constants.shippingDetails, data);
        }


        /// <summary>
        /// Get the profile
        /// </summary>
        /// <returns>Profile</returns>
        public Profile profile()
        {
            return this.getProperty(ThreeDSecureV2Constants.profile);
        }

        /// <summary>
        /// Set the profile
        /// </summary>
        /// <turns>void</returns>
        public void profile(Profile data)
        {
            this.setProperty(ThreeDSecureV2Constants.profile, data);
        }

        /// <summary>
        /// Get the signatureStatus
        /// </summary>
        /// <returns>string</returns>
        public string signatureStatus()
        {
            return this.getProperty(ThreeDSecureV2Constants.signatureStatus);
        }

        /// <summary>
        /// Set the signatureStatus
        /// </summary>
        /// <turns>void</returns>
        public void signatureStatus(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.signatureStatus, data);
        }

        /// <summary>
        /// Get the threeDSecureServerTransactionId
        /// </summary>
        /// <returns>string</returns>
        public string threeDSecureServerTransactionId()
        {
            return this.getProperty(ThreeDSecureV2Constants.threeDSecureServerTransactionId);
        }

        /// <summary>
        /// Set the threeDSecureServerTransactionId
        /// </summary>
        /// <turns>void</returns>
        public void threeDSecureServerTransactionId(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.threeDSecureServerTransactionId, data);
        }


        /// <summary>
        /// Get the mcc
        /// </summary>
        /// <returns>string</returns>
        public string mcc()
        {
            return this.getProperty(ThreeDSecureV2Constants.mcc);
        }

        /// <summary>
        /// Set the mcc
        /// </summary>
        /// <turns>void</returns>
        public void mcc(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.mcc, data);
        }


        /// <summary>
        /// Get the merchantName
        /// </summary>
        /// <returns>string</returns>
        public string merchantName()
        {
            return this.getProperty(ThreeDSecureV2Constants.merchantName);
        }

        /// <summary>
        /// Set the merchantName
        /// </summary>
        /// <turns>void</returns>
        public void merchantName(string data)
        {
            this.setProperty(ThreeDSecureV2Constants.merchantName, data);
        }


        /// <summary>
        /// Get a new AuthenticationsBuilder
        /// </summary>
        /// <returns>AuthenticationsBuilder</returns>
        public static AuthenticationsBuilder Builder()
        {
            return new AuthenticationsBuilder();
        }

        /// <summary>
        /// AuthorizationBuilder will allow an authorization to be initialized.
        /// set all properties and subpropeties, then trigger .Build() to 
        /// get the generated Authorization object
        /// </summary>
        public class AuthenticationsBuilder : BaseJSONBuilder<Authentications>
        {
            /// <summary>
            /// Set the id
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder id(string data)
            {
                this.properties[ThreeDSecureV2Constants.id] = data;
                return this;
            }

            /// <summary>
            /// Set the deviceFingerprintingId
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder deviceFingerprintingId(string data)
            {
                this.properties[ThreeDSecureV2Constants.deviceFingerprintingId] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantRefNum
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder merchantRefNum(string data)
            {
                this.properties[ThreeDSecureV2Constants.merchantRefNum] = data;
                return this;
            }

            /// <summary>
            /// Set the amount
            /// </summary>
            /// <param name=data>long</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder amount(long data)
            {
                this.properties[ThreeDSecureV2Constants.amount] = data;
                return this;
            }

            /// <summary>
            /// Set the currency
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder currency(string data)
            {
                this.properties[ThreeDSecureV2Constants.currency] = data;
                return this;
            }


            /// <summary>
            /// Build a card within this Authentications.
            /// </summary>
            /// <returns>Card.CardBuilder<AuthenticationsBuilder></returns>
            public Card.CardBuilder<AuthenticationsBuilder> card()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.card))
                {
                    this.properties[ThreeDSecureV2Constants.card] = new Card.CardBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.card] as Card.CardBuilder<AuthenticationsBuilder>;
            }

            /// <summary>
            /// Set the merchantUrl
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder merchantUrl(string data)
            {
                this.properties[ThreeDSecureV2Constants.merchantUrl] = data;
                return this;
            }

            /// <summary>
            /// Set the txnTime
            /// </summary>
            /// <param name=data>System.DateTime</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder txnTime(DateTime data)
            {
                this.properties[ThreeDSecureV2Constants.txnTime] = data;
                return this;
            }

            /// <summary>
            /// Build a error within this Authentications.
            /// </summary>
            /// <returns>Error.CardBuilder<AuthenticationsBuilder></returns>
            public Error.ErrorBuilder<AuthenticationsBuilder> error()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.error))
                {
                    this.properties[ThreeDSecureV2Constants.error] = new Error.ErrorBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.error] as Error.ErrorBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Set the status
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder status(string data)
            {
                this.properties[ThreeDSecureV2Constants.status] = data;
                return this;
            }

            /// <summary>
            /// Set the acsURL
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder acsURL(string data)
            {
                this.properties[ThreeDSecureV2Constants.acsURL] = data;
                return this;
            }

            /// <summary>
            /// Set the payload
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder payload(string data)
            {
                this.properties[ThreeDSecureV2Constants.payload] = data;
                return this;
            }


            /// <summary>
            /// Set the threeDEnrollment
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder threeDEnrollment(string data)
            {
                this.properties[ThreeDSecureV2Constants.threeDEnrollment] = data;
                return this;
            }

            /// <summary>
            /// Set the threeDResult
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder threeDResult(string data)
            {
                this.properties[ThreeDSecureV2Constants.threeDResult] = data;
                return this;
            }

            /// <summary>
            /// Set the threeDSecureVersion
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder threeDSecureVersion(string data)
            {
                this.properties[ThreeDSecureV2Constants.threeDSecureVersion] = data;
                return this;
            }

            /// <summary>
            /// Set the directoryServerTransactionId
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder directoryServerTransactionId(string data)
            {
                this.properties[ThreeDSecureV2Constants.directoryServerTransactionId] = data;
                return this;
            }

            /// <summary>
            /// Set the eci
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder eci(int data)
            {
                this.properties[ThreeDSecureV2Constants.eci] = data;
                return this;
            }


            /// <summary>
            /// Set the cavv
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder cavv(string data)
            {
                this.properties[ThreeDSecureV2Constants.cavv] = data;
                return this;
            }


            /// <summary>
            /// Set the xid
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder xid(string data)
            {
                this.properties[ThreeDSecureV2Constants.xid] = data;
                return this;
            }


            /// <summary>
            /// Set the sdkChallengePayload
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder sdkChallengePayload(string data)
            {
                this.properties[ThreeDSecureV2Constants.sdkChallengePayload] = data;
                return this;
            }

            /// <summary>
            /// Set the transactionIntent
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder transactionIntent(string data)
            {
                this.properties[ThreeDSecureV2Constants.transactionIntent] = data;
                return this;
            }


            /// <summary>
            /// Set the maxAuthorizationsForInstalmentPayment
            /// </summary>
            /// <param name=data>int</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder maxAuthorizationsForInstalmentPayment(int data)
            {
                this.properties[ThreeDSecureV2Constants.maxAuthorizationsForInstalmentPayment] = data;
                return this;
            }

            /// <summary>
            /// Set the authenticationPurpose
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder authenticationPurpose(string data)
            {
                this.properties[ThreeDSecureV2Constants.authenticationPurpose] = data;
                return this;
            }


            /// <summary>
            /// Set the deviceChannel
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder deviceChannel(string data)
            {
                this.properties[ThreeDSecureV2Constants.deviceChannel] = data;
                return this;
            }

            /// <summary>
            /// Set the messageCategory
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder messageCategory(string data)
            {
                this.properties[ThreeDSecureV2Constants.messageCategory] = data;
                return this;
            }

            /// <summary>
            /// Set the initialPurchaseTime
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder initialPurchaseTime(string data)
            {
                this.properties[ThreeDSecureV2Constants.initialPurchaseTime] = data;
                return this;
            }

            /// <summary>
            /// Set the requestorChallengePreference
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder requestorChallengePreference(string data)
            {
                this.properties[ThreeDSecureV2Constants.requestorChallengePreference] = data;
                return this;
            }


            /// <summary>
            /// Build a electronicDelivery within this Authentications.
            /// </summary>
            /// <returns>ElectronicDelivery.ElectronicDeliveryBuilder<AuthenticationsBuilder></returns>
            public ElectronicDelivery.ElectronicDeliveryBuilder<AuthenticationsBuilder> electronicDelivery()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.electronicDelivery))
                {
                    this.properties[ThreeDSecureV2Constants.electronicDelivery] = new ElectronicDelivery.ElectronicDeliveryBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.electronicDelivery] as ElectronicDelivery.ElectronicDeliveryBuilder<AuthenticationsBuilder>;
            }

            /// <summary>
            /// Build a OrderItemDetails within this Authentications.
            /// </summary>
            /// <returns>OrderItemDetails.OrderItemDetailsBuilder<AuthenticationsBuilder></returns>
            public OrderItemDetails.OrderItemDetailsBuilder<AuthenticationsBuilder> orderItemDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.orderItemDetails))
                {
                    this.properties[ThreeDSecureV2Constants.orderItemDetails] = new OrderItemDetails.OrderItemDetailsBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.orderItemDetails] as OrderItemDetails.OrderItemDetailsBuilder<AuthenticationsBuilder>;
            }

            /// <summary>
            /// Build a purchasedGiftCardDetails within this Authentications.
            /// </summary>
            /// <returns>PurchasedGiftCardDetails.CardBuilder<AuthenticationsBuilder></returns>
            public PurchasedGiftCardDetails.PurchasedGiftCardDetailsBuilder<AuthenticationsBuilder> purchasedGiftCardDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.purchasedGiftCardDetails))
                {
                    this.properties[ThreeDSecureV2Constants.purchasedGiftCardDetails] = new PurchasedGiftCardDetails.PurchasedGiftCardDetailsBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.purchasedGiftCardDetails] as PurchasedGiftCardDetails.PurchasedGiftCardDetailsBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Build a billingCycle within this Authentications.
            /// </summary>
            /// <returns>BillingCycle.BillingCycleBuilder<AuthenticationsBuilder></returns>
            public BillingCycle.BillingCycleBuilder<AuthenticationsBuilder> billingCycle()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.billingCycle))
                {
                    this.properties[ThreeDSecureV2Constants.billingCycle] = new BillingCycle.BillingCycleBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.billingCycle] as BillingCycle.BillingCycleBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Build a browserDetails within this Authentications.
            /// </summary>
            /// <returns>BrowserDetails.BrowserDetailsBuilder<AuthenticationsBuilder></returns>
            public BrowserDetails.BrowserDetailsBuilder<AuthenticationsBuilder> browserDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.browserDetails))
                {
                    this.properties[ThreeDSecureV2Constants.browserDetails] = new BrowserDetails.BrowserDetailsBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.browserDetails] as BrowserDetails.BrowserDetailsBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Build a userAccountDetails within this Authentications.
            /// </summary>
            /// <returns>UserAccountDetails.UserAccountDetailsBuilder<AuthenticationsBuilder></returns>
            public UserAccountDetails.UserAccountDetailsBuilder<AuthenticationsBuilder> userAccountDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.userAccountDetails))
                {
                    this.properties[ThreeDSecureV2Constants.userAccountDetails] = new UserAccountDetails.UserAccountDetailsBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.userAccountDetails] as UserAccountDetails.UserAccountDetailsBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Build a billingDetails within this Authentications.
            /// </summary>
            /// <returns>BillingDetails.BillingDetailsBuilder<AuthenticationsBuilder></returns>
            public BillingDetails.BillingDetailsBuilder<AuthenticationsBuilder> billingDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.billingDetails))
                {
                    this.properties[ThreeDSecureV2Constants.billingDetails] = new BillingDetails.BillingDetailsBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.billingDetails] as BillingDetails.BillingDetailsBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Build a shippingDetails within this Authentications.
            /// </summary>
            /// <returns>ShippingDetails.ShippingDetailsBuilder<AuthenticationsBuilder></returns>
            public ShippingDetails.ShippingDetailsBuilder<AuthenticationsBuilder> shippingDetails()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.shippingDetails))
                {
                    this.properties[ThreeDSecureV2Constants.shippingDetails] = new ShippingDetails.ShippingDetailsBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.shippingDetails] as ShippingDetails.ShippingDetailsBuilder<AuthenticationsBuilder>;
            }


            /// <summary>
            /// Build a profile within this Authentications.
            /// </summary>
            /// <returns>Profile.ProfileBuilder<AuthenticationsBuilder></returns>
            public Profile.ProfileBuilder<AuthenticationsBuilder> profile()
            {
                if (!this.properties.ContainsKey(ThreeDSecureV2Constants.profile))
                {
                    this.properties[ThreeDSecureV2Constants.profile] = new Profile.ProfileBuilder<AuthenticationsBuilder>(this);
                }
                return this.properties[ThreeDSecureV2Constants.profile] as Profile.ProfileBuilder<AuthenticationsBuilder>;
            }

            /// <summary>
            /// Set the signatureStatus
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder signatureStatus(string data)
            {
                this.properties[ThreeDSecureV2Constants.signatureStatus] = data;
                return this;
            }


            /// <summary>
            /// Set the threeDSecureServerTransactionId
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder threeDSecureServerTransactionId(string data)
            {
                this.properties[ThreeDSecureV2Constants.threeDSecureServerTransactionId] = data;
                return this;
            }

            /// <summary>
            /// Set the mcc
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder mcc(string data)
            {
                this.properties[ThreeDSecureV2Constants.mcc] = data;
                return this;
            }

            /// <summary>
            /// Set the merchantName
            /// </summary>
            /// <param name=data>string</param>
            /// <returns>AuthenticationsBuilder</returns>
            public AuthenticationsBuilder merchantName(string data)
            {
                this.properties[ThreeDSecureV2Constants.merchantName] = data;
                return this;
            }
        }
    }
}