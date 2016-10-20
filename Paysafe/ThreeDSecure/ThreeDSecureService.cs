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

namespace Paysafe.ThreeDSecure
{
    //Created by Tushar.Sukhiya on 03.05.2016. This is ThreeDSecureService class
    public class ThreeDSecureService
    {
        /// <summary>
        /// The api client, performs all http requests
        /// </summary>
        private PaysafeApiClient client;

        /// <summary>
        /// The ThreeDSecure api base uri 
        /// </summary>
        private string uri = "threedsecure/v1";

        /// <summary>
        /// Initialize the ThreeDSecure service with an client object
        /// </summary>
        /// <param name="client">PaysafeApiClient</param>
        public ThreeDSecureService(PaysafeApiClient client)
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

            return ("READY".Equals((string)(response[ThreeDSecureConstants.status])));
        }

        /// <summary>
        /// Submit an enrollment lookup request
        /// </summary>
        /// <param name="EnrollmentLookups">EnrollmentLookups</param>
        /// <returns>EnrollmentLookups</returns>
        public EnrollmentChecks submit(EnrollmentChecks enrollmentChecks)
        {
            enrollmentChecks.setRequiredFields(new List<string> {
                ThreeDSecureConstants.merchantRefNum,
                ThreeDSecureConstants.amount,
                ThreeDSecureConstants.currency,
                ThreeDSecureConstants.card,
                ThreeDSecureConstants.customerIp,
                ThreeDSecureConstants.userAgent,
                ThreeDSecureConstants.acceptHeader,
                ThreeDSecureConstants.merchantUrl
            });

            enrollmentChecks.checkRequiredFields();

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/accounts/" + client.account() +"/enrollmentchecks"),
                body: enrollmentChecks
            );
            dynamic response = this.client.processRequest(request);

            return new EnrollmentChecks(response);
        }

        /// <summary>
        /// Get the Enrollment Lookup
        /// </summary>
        /// <param name="auth">EnrollmentLookups</param>
        /// <returns>EnrollmentLookups</returns>
        public EnrollmentChecks get(EnrollmentChecks enrollmentChecks)
        {
            enrollmentChecks.setRequiredFields(new List<string> { ThreeDSecureConstants.id });
            enrollmentChecks.checkRequiredFields();

            Request request = new Request(
                uri: this.prepareURI("/accounts/" + client.account() + "/enrollmentchecks/" + enrollmentChecks.id())
            );

            dynamic response = this.client.processRequest(request);

            return new EnrollmentChecks(response);
        }

        /// <summary>
        /// Submit an authentications request
        /// </summary>
        /// <param name="Authentications">Authentications</param>
        /// <returns>Authentications</returns>
        public Authentications submit(Authentications authentications)
        {
            authentications.setRequiredFields(new List<string> {
                ThreeDSecureConstants.merchantRefNum,
                ThreeDSecureConstants.paResp,
            });

            authentications.checkRequiredFields();                     
            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/accounts/" + client.account() + "/enrollmentchecks/" + authentications.enrollmentId() + "/authentications"),
                body: authentications
            );
            dynamic response = this.client.processRequest(request);

            return new Authentications(response);
        }

        /// <summary>
        /// Get an authentication usind id
        /// </summary>
        /// <param name="auth">Authentications</param>
        /// <returns>Authentications</returns>
        public Authentications get(Authentications authentications, bool includeEnrollment = false)
        {
            authentications.setRequiredFields(new List<string> { ThreeDSecureConstants.id });
            authentications.checkRequiredFields();

            Dictionary<string, string> queryStr = new Dictionary<string, string>();
            StringBuilder toInclude = new StringBuilder();

            if (includeEnrollment)
            {
                toInclude.Append("enrollmentchecks");
            }
            queryStr.Add("fields", toInclude.ToString());                                          

            Request request = new Request(
                uri: this.prepareURI("/accounts/" + client.account() + "/authentications/" + authentications.id()),
                queryString : queryStr
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
