using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{
    public class ThreeDSecureV2Service
  
    {
        /// <summary>
        /// The api client, performs all http requests
        /// </summary>
        private PaysafeApiClient client;

        /// <summary>
        /// The ThreeDSecureV2 api base uri 
        /// </summary>
        private string uri = "threedsecure/v2";

        /// <summary>
        /// Initialize the ThreeDSecureV2 service with an client object
        /// </summary>
        /// <param name="client">PaysafeApiClient</param>
        public ThreeDSecureV2Service(PaysafeApiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Check if the service is available
        /// </summary>
        /// <returns>true if successful</returns>
        public Boolean monitor()
        {
            Request request = new Request(uri: "threedsecure/monitor");
            dynamic response = this.client.processRequest(request);

            return ("READY".Equals((string)(response[ThreeDSecureV2Constants.status])));
        }

        /// <summary>
        /// Submit an authentications request
        /// </summary>
        /// <param name="Authentications">Authentications</param>
        /// <returns>Authentications</returns>
        public Authentications authentications(Authentications auth)
        {
            auth.setRequiredFields(new List<string> {
                ThreeDSecureV2Constants.deviceFingerprintingId,
                ThreeDSecureV2Constants.merchantRefNum,
                ThreeDSecureV2Constants.amount,
                ThreeDSecureV2Constants.currency,
                ThreeDSecureV2Constants.card,
                ThreeDSecureV2Constants.merchantUrl,
                ThreeDSecureV2Constants.authenticationPurpose,
                ThreeDSecureV2Constants.deviceChannel,
                ThreeDSecureV2Constants.messageCategory
            });
            auth.setOptionalFields(new List<string> {
                ThreeDSecureV2Constants.orderItemDetails,
                ThreeDSecureV2Constants.requestorChallengePreference, 
                ThreeDSecureV2Constants.purchasedGiftCardDetails, 
                ThreeDSecureV2Constants.browserDetails,
                ThreeDSecureV2Constants.userAccountDetails,
                ThreeDSecureV2Constants.billingDetails,
                ThreeDSecureV2Constants.shippingDetails,
		        ThreeDSecureV2Constants.profile,
		        ThreeDSecureV2Constants.maxAuthorizationsForInstalmentPayment,
                ThreeDSecureV2Constants.transactionIntent,
                ThreeDSecureV2Constants.billingCycle,
                ThreeDSecureV2Constants.initialPurchaseTime,
                ThreeDSecureV2Constants.mcc,
                ThreeDSecureV2Constants.merchantName,
                ThreeDSecureV2Constants.electronicDelivery
            });
            Request request = new Request(
             method: RequestType.POST,
             uri: this.prepareURI("/accounts/" + client.account() + "/authentications"),
             body: auth
         );
            dynamic response = this.client.processRequest(request);
            return new Authentications(response);
        }
        
        /// <summary>
        /// Get the Authentications
        /// </summary>
        /// <param name="auth">Authentications</param>
        /// <returns>Authorization</returns>
        public Authentications get(Authentications auth)
        {
            auth.setRequiredFields(new List<string> { ThreeDSecureV2Constants.id });
            auth.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/accounts/" + client.account() + "/authentications" + auth.id())
            );

            dynamic response = this.client.processRequest(request);

            return new Authentications(response);
        }

        private string prepareURI(string path)
        {
            return this.uri + path;
        }
    }
}
