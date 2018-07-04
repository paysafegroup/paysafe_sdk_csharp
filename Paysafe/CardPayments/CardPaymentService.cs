/*
 * Copyright (c) 2014 Optimal Payments
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
 * associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute,
 * sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
 * NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;
using PaysafeApiClient = Paysafe.PaysafeApiClient;

namespace Paysafe.CardPayments
{
    public class CardPaymentService
    {

        /// <summary>
        /// The api client, performs all http requests
        /// </summary>
        private PaysafeApiClient client;

        /// <summary>
        /// The card payments api base uri 
        /// </summary>
        private string uri = "cardpayments/v1";

        /// <summary>
        /// Initialize the card payments service with an client object
        /// </summary>
        /// <param name="client">PaysafeApiClient</param>
        public CardPaymentService(PaysafeApiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Check if the service is available
        /// </summary>
        /// <returns>true if successful</returns>
        public Boolean monitor() {
            Request request = new Request(uri:"cardpayments/monitor");
            dynamic response = this.client.processRequest(request);

            return ("READY".Equals((string)(response[CardPaymentsConstants.status])));
        }

        /// <summary>
        /// Authorize
        /// </summary>
        /// <param name="auth">Authorization</param>
        /// <returns>Authorization</returns>
        public Authorization authorize(Authorization auth)
        {
            auth.setRequiredFields(new List<string> {
                CardPaymentsConstants.merchantRefNum,
                CardPaymentsConstants.amount,
                CardPaymentsConstants.card
            });
            auth.setOptionalFields(new List<string> {
                CardPaymentsConstants.settleWithAuth,
                CardPaymentsConstants.customerIp, 
                CardPaymentsConstants.dupCheck, 
                CardPaymentsConstants.description,
                CardPaymentsConstants.authentication,
                CardPaymentsConstants.billingDetails,
                CardPaymentsConstants.shippingDetails,
		CardPaymentsConstants.profile,
		CardPaymentsConstants.storedCredential,
                CardPaymentsConstants.recurring,
                CardPaymentsConstants.merchantDescriptor,
                CardPaymentsConstants.accordD
            });
		
            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/auths"),
                body: auth
            );
            dynamic response = this.client.processRequest(request);

            return new Authorization(response);
        }

        /// <summary>
        /// Cancel the Authorization
        /// </summary>
        /// <param name="auth">Authorization</param>
        /// <returns>Authorization</returns>
        public Authorization cancelHeldAuth(Authorization auth)
        {
            auth.setRequiredFields(new List<string> {CardPaymentsConstants.id});
            auth.checkRequiredFields();

            Authorization tmpAuth = new Authorization();
            tmpAuth.status("CANCELLED");

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/auths/" + auth.id()),
                body: tmpAuth
            );

            dynamic response = this.client.processRequest(request);

            return new Authorization(response);
        }

        /// <summary>
        /// Approve
        /// </summary>
        /// <param name="auth">Authorization</param>
        /// <returns>Authorization</returns>
        public Authorization approveHeldAuth(Authorization auth)
        {
            auth.setRequiredFields(new List<string> {CardPaymentsConstants.id});

            auth.checkRequiredFields();

            Authorization tmpAuth = new Authorization();
            tmpAuth.status("COMPLETED");

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/auths/" + auth.id()),
                body: tmpAuth
            );

            dynamic response = this.client.processRequest(request);

            return new Authorization(response);
        }

        /// <summary>
        /// Reverse
        /// </summary>
        /// <param name="authReversal">AuthorizationReversal</param>
        /// <returns>AuthorizationReversal</returns>
        public AuthorizationReversal reverseAuth(AuthorizationReversal authReversal)
        {
            authReversal.setRequiredFields(new List<string> {CardPaymentsConstants.authorizationId});
            authReversal.checkRequiredFields();
            authReversal.setRequiredFields(new List<string> {CardPaymentsConstants.merchantRefNum});
            authReversal.setOptionalFields(new List<string> {
                CardPaymentsConstants.amount,
                CardPaymentsConstants.dupCheck
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/auths/" + authReversal.authorizationId() + "/voidauths"),
                body: authReversal
            );

            dynamic response = this.client.processRequest(request);

            return new AuthorizationReversal(response);
        }

        /// <summary>
        /// Settlement
        /// </summary>
        /// <param name="settlement">Settlement</param>
        /// <returns>Settlement</returns>
        public Settlement settlement(Settlement settle)
        {
            settle.setRequiredFields(new List<string> { CardPaymentsConstants.authorizationId });
            settle.checkRequiredFields();
            settle.setRequiredFields(new List<string> { CardPaymentsConstants.merchantRefNum });
            settle.setOptionalFields(new List<string> {
                CardPaymentsConstants.amount,
                CardPaymentsConstants.dupCheck
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/auths/" + settle.authorizationId() + "/settlements"),
                body: settle
            );

            dynamic response = this.client.processRequest(request);

            return new Settlement(response);
        }

        /// <summary>
        /// Cancel Settlement
        /// </summary>
        /// <param name="settlement">Settlement</param>
        /// <returns>Settlement</returns>
        public Settlement cancelSettlement(Settlement settle)
        {
            settle.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            settle.checkRequiredFields();

            Settlement tmpSettlement = new Settlement();
            tmpSettlement.status("CANCELLED");

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/settlements/" + settle.id()),
                body: tmpSettlement
            );

            dynamic response = this.client.processRequest(request);

            return new Settlement(response);
        }

        /// <summary>
        /// Refund
        /// </summary>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        public Refund refund(Refund newRefund)
        {
            newRefund.setRequiredFields(new List<string> { CardPaymentsConstants.settlementId });
            newRefund.checkRequiredFields();
            newRefund.setRequiredFields(new List<string> { CardPaymentsConstants.merchantRefNum });
            newRefund.setOptionalFields(new List<string> {
                CardPaymentsConstants.amount,
                CardPaymentsConstants.dupCheck
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/settlements/" + newRefund.settlementId() + "/refunds"),
                body: newRefund
            );

            dynamic response = this.client.processRequest(request);

            return new Refund(response);
        }

        /// <summary>
        /// Cancel Refund
        /// </summary>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        public Refund cancelRefund(Refund refund)
        {
            refund.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            refund.checkRequiredFields();

            Refund tmpRefund = new Refund();
            tmpRefund.status("CANCELLED");

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/refunds/" + refund.id()),
                body: tmpRefund
            );

            dynamic response = this.client.processRequest(request);

            return new Refund(response);
        }

        /// <summary>
        /// Verify
        /// </summary>
        /// <param name="verify">Verification</param>
        /// <returns>Verificationd</returns>
        public Verification verify(Verification verification)
        {
            verification.setRequiredFields(new List<string> { 
                CardPaymentsConstants.merchantRefNum,
                CardPaymentsConstants.card
            });

            verification.setOptionalFields(new List<string> {
                CardPaymentsConstants.profile,
                CardPaymentsConstants.customerIp,
                CardPaymentsConstants.dupCheck,
                CardPaymentsConstants.description,
                CardPaymentsConstants.billingDetails
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/verifications"),
                body: verification
            );

            dynamic response = this.client.processRequest(request);

            return new Verification(response);
        }

        /// <summary>
        /// Get the authorization
        /// </summary>
        /// <param name="auth">Authorization</param>
        /// <returns>Authorization</returns>
        public Authorization get(Authorization auth)
        {
            auth.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            auth.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/auths/" + auth.id())
            );

            dynamic response = this.client.processRequest(request);

            return new Authorization(response);
        }

        /// <summary>
        /// Get the AuthorizationReversal
        /// </summary>
        /// <param name="authReversal">AuthorizationReversal</param>
        /// <returns>AuthorizationReversal</returns>
        public AuthorizationReversal get(AuthorizationReversal authReversal)
        {
            authReversal.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            authReversal.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/voidauths/" + authReversal.id())
            );

            dynamic response = this.client.processRequest(request);

            return new AuthorizationReversal(response);
        }

        /// <summary>
        /// Get the Settlement
        /// </summary>
        /// <param name="settlement">Settlement</param>
        /// <returns>Settlement</returns>
        public Settlement get(Settlement settlement)
        {
            settlement.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            settlement.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/settlements/" + settlement.id())
            );

            dynamic response = this.client.processRequest(request);

            return new Settlement(response);
        }

        /// <summary>
        /// Get the Refund
        /// </summary>
        /// <param name="refund">Refund</param>
        /// <returns>Refund</returns>
        public Refund get(Refund refund)
        {
            refund.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            refund.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/refunds/" + refund.id())
            );

            dynamic response = this.client.processRequest(request);

            return new Refund(response);
        }

        /// <summary>
        /// Get the verification
        /// </summary>
        /// <param name="verification">Verification</param>
        /// <returns>Verification</returns>
        public Verification get(Verification verify)
        {
            verify.setRequiredFields(new List<string> { CardPaymentsConstants.id });
            verify.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/verifications/" + verify.id())
            );

            dynamic response = this.client.processRequest(request);

            return new Verification(response);
        }

        /// <summary>
        /// Get matching authorizations
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<Authorization> getAuths(Authorization auth = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (auth != null && !String.IsNullOrWhiteSpace(auth.merchantRefNum())) {
              queryStr.Add("merchantRefNum", auth.merchantRefNum());
            }
            if (filter != null)
            {
                if (filter.limit != null)
                {
                    queryStr.Add("limit", filter.limit.ToString());
                }
                if (filter.offset != null)
                {
                    queryStr.Add("offset", filter.offset.ToString());
                }
                if (!String.IsNullOrWhiteSpace(filter.startDate))
                {
                    queryStr.Add("startDate", filter.startDate);
                }
                if (!String.IsNullOrWhiteSpace(filter.endDate))
                {
                    queryStr.Add("endDate", filter.endDate);
                }
            }

            Request request = new Request(
                    method: RequestType.GET,
                    uri: this.prepareURI("/auths"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<Authorization>(this.client, typeof(Authorization), response);
        }

        /// <summary>
        /// Get matching authorization reversals
        /// </summary>
        /// <param name="authReversal"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<AuthorizationReversal> getAuthReversals(AuthorizationReversal authReversal = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (authReversal != null && !String.IsNullOrWhiteSpace(authReversal.merchantRefNum()))
            {
                queryStr.Add("merchantRefNum", authReversal.merchantRefNum());
            }
            if (filter != null)
            {
                if (filter.limit != null)
                {
                    queryStr.Add("limit", filter.limit.ToString());
                }
                if (filter.offset != null)
                {
                    queryStr.Add("offset", filter.offset.ToString());
                }
                if (!String.IsNullOrWhiteSpace(filter.startDate))
                {
                    queryStr.Add("startDate", filter.startDate);
                }
                if (!String.IsNullOrWhiteSpace(filter.endDate))
                {
                    queryStr.Add("endDate", filter.endDate);
                }
            }

            Request request = new Request(
                    method: RequestType.GET,
                    uri: this.prepareURI("/voidauths"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<AuthorizationReversal>(this.client, typeof(AuthorizationReversal), response);
        }

        /// <summary>
        /// Get matching settlements
        /// </summary>
        /// <param name="settlement"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<Settlement> getSettlements(Settlement settlement = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (settlement != null && !String.IsNullOrWhiteSpace(settlement.merchantRefNum()))
            {
                queryStr.Add("merchantRefNum", settlement.merchantRefNum());
            }
            if (filter != null)
            {
                if (filter.limit != null)
                {
                    queryStr.Add("limit", filter.limit.ToString());
                }
                if (filter.offset != null)
                {
                    queryStr.Add("offset", filter.offset.ToString());
                }
                if (!String.IsNullOrWhiteSpace(filter.startDate))
                {
                    queryStr.Add("startDate", filter.startDate);
                }
                if (!String.IsNullOrWhiteSpace(filter.endDate))
                {
                    queryStr.Add("endDate", filter.endDate);
                }
            }

            Request request = new Request(
                    method: RequestType.GET,
                    uri: this.prepareURI("/settlements"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<Settlement>(this.client, typeof(Settlement), response);
        }

        /// <summary>
        /// Get matching refunds
        /// </summary>
        /// <param name="refund"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<Refund> getRefunds(Refund refund = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (refund != null && !String.IsNullOrWhiteSpace(refund.merchantRefNum()))
            {
                queryStr.Add("merchantRefNum", refund.merchantRefNum());
            }
            if (filter != null)
            {
                if (filter.limit != null)
                {
                    queryStr.Add("limit", filter.limit.ToString());
                }
                if (filter.offset != null)
                {
                    queryStr.Add("offset", filter.offset.ToString());
                }
                if (!String.IsNullOrWhiteSpace(filter.startDate))
                {
                    queryStr.Add("startDate", filter.startDate);
                }
                if (!String.IsNullOrWhiteSpace(filter.endDate))
                {
                    queryStr.Add("endDate", filter.endDate);
                }
            }

            Request request = new Request(
                    method: RequestType.GET,
                    uri: this.prepareURI("/refunds"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<Refund>(this.client, typeof(Refund), response);
        }

        /// <summary>
        /// Get matching verifications
        /// </summary>
        /// <param name="verify"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<Verification> getVerifications(Verification verify = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (verify != null && !String.IsNullOrWhiteSpace(verify.merchantRefNum()))
            {
                queryStr.Add("merchantRefNum", verify.merchantRefNum());
            }
            if (filter != null)
            {
                if (filter.limit != null)
                {
                    queryStr.Add("limit", filter.limit.ToString());
                }
                if (filter.offset != null)
                {
                    queryStr.Add("offset", filter.offset.ToString());
                }
                if (!String.IsNullOrWhiteSpace(filter.startDate))
                {
                    queryStr.Add("startDate", filter.startDate);
                }
                if (!String.IsNullOrWhiteSpace(filter.endDate))
                {
                    queryStr.Add("endDate", filter.endDate);
                }
            }

            Request request = new Request(
                    method: RequestType.GET,
                    uri: this.prepareURI("/verifications"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<Verification>(this.client, typeof(Verification), response);
        }

        private string prepareURI(string path)
        {
            if (String.IsNullOrWhiteSpace(this.client.account()))
            {
                throw new PaysafeException("Missing or invalid account");
            }
            return this.uri + "/accounts/" + this.client.account() + path;
        }
    }
}
