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

namespace Paysafe.DirectDebit
{
    //Created by Manjiri.Bankar on 03.05.2016. This is DirectDebitService class.
    public class DirectDebitService
    {
         /// <summary>
        /// The api client, performs all http requests
        /// </summary>
        private PaysafeApiClient client;

        /// <summary>
        /// The direct debit api base uri 
        /// </summary>
        private string uri = "directdebit/v1/accounts/";

        /// <summary>
        /// Initialize the direct debit service with an client object
        /// </summary>
        /// <param name="client">PaysafeApiClient</param>
        public DirectDebitService(PaysafeApiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Check if the service is available
        /// </summary>
        /// <returns>true if successful</returns>
        public Boolean monitor()
        {
            Request request = new Request(uri: "directdebit/monitor");
            dynamic response = this.client.processRequest(request);

            return ("READY".Equals((string)(response[DirectDebitConstants.status])));
        }

        /// <summary>
        /// Create submit for Purchases
        /// </summary>
        /// <param name="submit">submit</param>
        /// <returns>Purchases</returns>
        public Purchases submit(Purchases purchases)
        {
            purchases.setRequiredFields(new List<string> {
                DirectDebitConstants.merchantRefNum,
                DirectDebitConstants.amount,                
            });
            purchases.checkRequiredFields();
            purchases.setOptionalFields(new List<string> {
                DirectDebitConstants.customerIp,
                DirectDebitConstants.dupCheck, 
                DirectDebitConstants.ach,
                DirectDebitConstants.bacs,
                DirectDebitConstants.eft,
                DirectDebitConstants.sepa,
                DirectDebitConstants.billingDetails,
                DirectDebitConstants.profile
            });
            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI(client.account() + "/purchases"),
                body: purchases
            );
            dynamic response = this.client.processRequest(request);

            return new Purchases(response);
        }

        /// <summary>
        /// Create submit for Standalone Credits
        /// </summary>
        /// <param name="submit">submit</param>
        /// <returns>StandaloneCredits</returns>
        public StandaloneCredits submit(StandaloneCredits standalonecredits)
        {
            standalonecredits.setRequiredFields(new List<string> {
                DirectDebitConstants.merchantRefNum,
                DirectDebitConstants.amount,               
            });
            standalonecredits.checkRequiredFields();
            standalonecredits.setOptionalFields(new List<string> {
                DirectDebitConstants.customerIp,
                DirectDebitConstants.dupCheck,
                DirectDebitConstants.ach,
                DirectDebitConstants.bacs,
                DirectDebitConstants.eft, 
                DirectDebitConstants.billingDetails,
                DirectDebitConstants.profile,
            });
            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI(client.account() + "/standalonecredits"),
                body: standalonecredits
            );
            dynamic response = this.client.processRequest(request);

            return new StandaloneCredits(response);
        }

        /// <summary>
        /// Create cancel for Purchases
        /// </summary>
        /// <param name="cancel">cancel</param>
        /// <returns>Purchases</returns>
        public Purchases cancel(Purchases purchases)
        {
            purchases.setRequiredFields(new List<string> {
                DirectDebitConstants.status,  
                DirectDebitConstants.id
            });
            purchases.checkRequiredFields();
            purchases.setOptionalFields(new List<string>{
                 DirectDebitConstants.ach,
                DirectDebitConstants.bacs,
                DirectDebitConstants.eft,
                DirectDebitConstants.sepa,
            });
            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI(client.account() + "/purchases/" + purchases.id()),
                body: purchases
            );
            dynamic response = this.client.processRequest(request);

            Purchases returnVal = new Purchases(response);
            returnVal.id(purchases.id());
            return returnVal;
        }

        /// <summary>
        /// Create cancel for Standalone Credits
        /// </summary>
        /// <param name="cancel">cancel</param>
        /// <returns>StandaloneCredits</returns>
        public StandaloneCredits cancel(StandaloneCredits standalonecredits)
        {
            standalonecredits.setRequiredFields(new List<string> {
                DirectDebitConstants.status,  
                DirectDebitConstants.id
            });
            standalonecredits.checkRequiredFields();
            standalonecredits.setOptionalFields(new List<string>{
                 DirectDebitConstants.ach,
                DirectDebitConstants.bacs,
                DirectDebitConstants.eft,               
            });

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI(client.account() + "/standalonecredits/" + standalonecredits.id()),
                body: standalonecredits
            );
            dynamic response = this.client.processRequest(request);

            StandaloneCredits returnVal = new StandaloneCredits(response);
            returnVal.id(standalonecredits.id());
            return returnVal;
        }

        /// <summary>
        /// Create get
        /// </summary>
        /// <param name="get">get</param>
        /// <returns>Purchases</returns>
        public Purchases get(Purchases purchase)
        {
            purchase.setRequiredFields(new List<string> {               
                DirectDebitConstants.id,               
            });
            purchase.checkRequiredFields();
            purchase.setOptionalFields(new List<string>{
                 DirectDebitConstants.ach,
                DirectDebitConstants.bacs,
                DirectDebitConstants.eft,  
                DirectDebitConstants.sepa,
            });

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI(client.account() + "/purchases/" + purchase.id()),
                body: purchase
            );
            dynamic response = this.client.processRequest(request);

            return new Purchases(response);
        }

        /// <summary>
        /// Get matching Purchases
        /// </summary>
        /// <param name="purchases"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<Purchases> getPurchase(Purchases purchases = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (purchases != null && !String.IsNullOrWhiteSpace(purchases.merchantRefNum()))
            {
                queryStr.Add("merchantRefNum", purchases.merchantRefNum());
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
                    uri: this.prepareURI(client.account() + "/purchases"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<Purchases>(this.client, typeof(Purchases), response);
        }

        /// <summary>
        /// Create get
        /// </summary>
        /// <param name="get">get</param>
        /// <returns>StandaloneCredits</returns>
        public StandaloneCredits get(StandaloneCredits standalonescredits)
        {
            standalonescredits.setRequiredFields(new List<string> {               
                DirectDebitConstants.id,                
            });
            standalonescredits.checkRequiredFields();
            standalonescredits.setOptionalFields(new List<string>{
                 DirectDebitConstants.ach,
                DirectDebitConstants.bacs,
                DirectDebitConstants.eft,                  
            });
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI(client.account() + "/standalonecredits/" + standalonescredits.id()),
                body: standalonescredits
            );
            dynamic response = this.client.processRequest(request);

            return new StandaloneCredits(response);
        }

        /// <summary>
        /// Get matching StandaloneCredits
        /// </summary>
        /// <param name="standalonescredits"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Pagerator<StandaloneCredits> getStandaloneCredits(StandaloneCredits standalonescredits = null, Filter filter = null)
        {
            Dictionary<String, String> queryStr = new Dictionary<String, String>();
            if (standalonescredits != null && !String.IsNullOrWhiteSpace(standalonescredits.merchantRefNum()))
            {
                queryStr.Add("merchantRefNum", standalonescredits.merchantRefNum());
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
                    uri: this.prepareURI(client.account() + "/standalonecredits"),
                    queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Pagerator<StandaloneCredits>(this.client, typeof(StandaloneCredits), response);
        }

        private string prepareURI(string path)
        {
            return this.uri + path;
        }
    }
}
