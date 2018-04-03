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

namespace Paysafe.CustomerVault
{
    public class CustomerVaultService
    {

        /// <summary>
        /// The api client, performs all http requests
        /// </summary>
        private PaysafeApiClient client;

        /// <summary>
        /// The card payments api base uri 
        /// </summary>
        private string uri = "customervault/v1";

        /// <summary>
        /// Initialize the card payments service with an client object
        /// </summary>
        /// <param name="client">PaysafeApiClient</param>
        public CustomerVaultService(PaysafeApiClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Check if the service is available
        /// </summary>
        /// <returns>true if successful</returns>
        public Boolean monitor()
        {
            Request request = new Request(uri: "customervault/monitor");
            dynamic response = this.client.processRequest(request);

            return ("READY".Equals((string)(response[CustomerVaultConstants.status])));
        }

        /// <summary>
        /// Create profile
        /// </summary>
        /// <param name="profile">Profile</param>
        /// <returns>Profile</returns>
        public Profile create(Profile profile)
        {
            profile.setRequiredFields(new List<string> {
                CustomerVaultConstants.merchantCustomerId,
                CustomerVaultConstants.locale
            });
            profile.setOptionalFields(new List<string> {
                CustomerVaultConstants.firstName,
                CustomerVaultConstants.middleName,
                CustomerVaultConstants.lastName,
                CustomerVaultConstants.dateOfBirth,
                CustomerVaultConstants.ip,
                CustomerVaultConstants.gender,
                CustomerVaultConstants.nationality,
                CustomerVaultConstants.email,
                CustomerVaultConstants.phone,
                CustomerVaultConstants.cellPhone,
                CustomerVaultConstants.card
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles"),
                body: profile
            );
            dynamic response = this.client.processRequest(request);

            return new Profile(response);
        }

        /// <summary>
        /// create address 
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns>Address</returns>
        public Address create(Address address)
        {
            address.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            address.checkRequiredFields();
            address.setRequiredFields(new List<string> { CustomerVaultConstants.country });
            address.setOptionalFields(new List<string> {
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.street,
                CustomerVaultConstants.street2,
                CustomerVaultConstants.city,
                CustomerVaultConstants.state,
                CustomerVaultConstants.zip,
                CustomerVaultConstants.recipientName,
                CustomerVaultConstants.phone
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + address.profileId() + "/addresses"),
                body: address
            );

            dynamic response = this.client.processRequest(request);

            Address returnVal = new Address(response);
            returnVal.profileId(address.profileId());
            return returnVal;
        }

        /// <summary>
        /// Create card 
        /// </summary>
        /// <param name="card">Card</param>
        /// <returns>Card</returns>
        public Card create(Card card)
        {
            card.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            card.checkRequiredFields();
            card.setOptionalFields(new List<string> {
                CustomerVaultConstants.cardNum,
                CustomerVaultConstants.cardExpiry,
                CustomerVaultConstants.singleUseToken,
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum,
                CustomerVaultConstants.holderName,
                CustomerVaultConstants.billingAddressId
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + card.profileId() + "/cards"),
                body: card
            );

            dynamic response = this.client.processRequest(request);

            Card returnVal = new Card(response);
            returnVal.profileId(card.profileId());
            return returnVal;
        }

        /// <summary>
        /// Create ACHBankAccount
        /// </summary>
        /// <param name="ACHBankAccount">ACHBankAccount</param>
        /// <returns>ACHBankAccount</returns>
        public ACHBankAccounts create(ACHBankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setRequiredFields(new List<string> {
                CustomerVaultConstants.accountHolderName,
                CustomerVaultConstants.accountNumber,
                CustomerVaultConstants.routingNumber,
                CustomerVaultConstants.billingAddressId,
                CustomerVaultConstants.accountType,                  
            });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum
            });
            
            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/achbankaccounts"),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            ACHBankAccounts returnVal = new ACHBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;          
        }

        /// <summary>
        /// Create BACSBankAccount
        /// </summary>
        /// <param name="BACSBankAccount">BACSBankAccount</param>
        /// <returns>BACSBankAccount</returns>
        public BACSBankAccounts create(BACSBankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setRequiredFields(new List<string> {               
                CustomerVaultConstants.accountNumber,
                CustomerVaultConstants.sortCode,
                 CustomerVaultConstants.accountHolderName,
                CustomerVaultConstants.billingAddressId,                             
            });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {
                CustomerVaultConstants.mandates,
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum,                
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/bacsbankaccounts"),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            BACSBankAccounts returnVal = new BACSBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// Create EFTBankAccount
        /// </summary>
        /// <param name="EFTBankAccount">EFTBankAccount</param>
        /// <returns>EFTBankAccount</returns>
        public EFTBankAccounts create(EFTBankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setRequiredFields(new List<string> {               
                CustomerVaultConstants.accountNumber,
                CustomerVaultConstants.transitNumber,
                CustomerVaultConstants.institutionId,
                 CustomerVaultConstants.accountHolderName,
                CustomerVaultConstants.billingAddressId,                             
            });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {                
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum,                
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/eftbankaccounts"),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            EFTBankAccounts returnVal = new EFTBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }


        /// <summary>
        /// Create SEPABankAccount
        /// </summary>
        /// <param name="SEPABankAccount">SEPABankAccount</param>
        /// <returns>SEPABankAccount</returns>
        public SEPABankAccounts create(SEPABankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setRequiredFields(new List<string> {               
                CustomerVaultConstants.iban,
                CustomerVaultConstants.bic,           
                 CustomerVaultConstants.accountHolderName,
                CustomerVaultConstants.billingAddressId,                             
            });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {                
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum,  
                CustomerVaultConstants.mandates
            });

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/sepabankaccounts"),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            SEPABankAccounts returnVal = new SEPABankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// Create Mandates
        /// </summary>
        /// <param name="Mandates">Mandates</param>
        /// <returns>Mandates</returns>
        public Mandates create(Mandates account, string accountName)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.reference,
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.bankAccountId
            });
          
            account.checkRequiredFields();

            if (accountName.Equals("SEPA"))
                accountName = "/sepabankaccounts/";
            else
                accountName = "/bacsbankaccounts/";

            Request request = new Request(
                method: RequestType.POST,
                uri: this.prepareURI("/profiles/" + account.profileId() + accountName + account.bankAccountId() + "/mandates"),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            Mandates returnVal = new Mandates(response);            
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// update Profile  
        /// </summary>
        /// <param name="profile">Profile</param>
        /// <returns>Profile</returns>
        public Profile update(Profile profile)
        {
            profile.setRequiredFields(new List<string> { CustomerVaultConstants.id });
            profile.checkRequiredFields();
            profile.setRequiredFields(new List<string> {
                CustomerVaultConstants.merchantCustomerId,
                CustomerVaultConstants.locale
            });
            profile.setOptionalFields(new List<string> {
                CustomerVaultConstants.firstName,
                CustomerVaultConstants.middleName,
                CustomerVaultConstants.lastName,
                CustomerVaultConstants.dateOfBirth,
                CustomerVaultConstants.ip,
                CustomerVaultConstants.gender,
                CustomerVaultConstants.nationality,
                CustomerVaultConstants.email,
                CustomerVaultConstants.phone,
                CustomerVaultConstants.cellPhone
            });

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + profile.id()),
                body: profile
            );

            dynamic response = this.client.processRequest(request);

            return new Profile(response);
        }

        /// <summary>
        /// Update address 
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns>Address</returns>
        public Address update(Address address)
        {
            address.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            address.checkRequiredFields();
            address.setRequiredFields(new List<string> { CustomerVaultConstants.country });
            address.setOptionalFields(new List<string> {
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.street,
                CustomerVaultConstants.street2,
                CustomerVaultConstants.city,
                CustomerVaultConstants.state,
                CustomerVaultConstants.zip,
                CustomerVaultConstants.recipientName,
                CustomerVaultConstants.phone
            });

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + address.profileId() + "/addresses/" + address.id()),
                body: address
            );

            dynamic response = this.client.processRequest(request);

            Address returnVal = new Address(response);
            returnVal.profileId(address.profileId());
            return returnVal;
        }

        /// <summary>
        /// Update card 
        /// </summary>
        /// <param name="card">Card</param>
        /// <returns>Card</returns>
        public Card update(Card card)
        {
            card.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            card.checkRequiredFields();
            card.setRequiredFields(new List<string> {});
            card.setOptionalFields(new List<string> {
                CustomerVaultConstants.cardExpiry,
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum,
                CustomerVaultConstants.holderName,
                CustomerVaultConstants.billingAddressId
            });

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + card.profileId() + "/cards/" + card.id()),
                body: card
            );

            dynamic response = this.client.processRequest(request);

            Card returnVal = new Card(response);
            returnVal.profileId(card.profileId());
            return returnVal;
        }

        /// <summary>
        /// update ACHBankAccount
        /// </summary>
        /// <param name="ACHBankAccount">ACHBankAccount</param>
        /// <returns>ACHBankAccount</returns>
        public ACHBankAccounts update(ACHBankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setRequiredFields(new List<string> {
                CustomerVaultConstants.accountHolderName,                
                CustomerVaultConstants.routingNumber,
                CustomerVaultConstants.billingAddressId,
                CustomerVaultConstants.accountType,                  
            });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum,
                CustomerVaultConstants.accountNumber
            });
         
            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/achbankaccounts/" + account.id()),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            ACHBankAccounts returnVal = new ACHBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;           
        }

        /// <summary>
        /// update BACSBankAccount
        /// </summary>
        /// <param name="BACSBankAccount">BACSBankAccount</param>
        /// <returns>BACSBankAccount</returns>
        public BACSBankAccounts update(BACSBankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {
            CustomerVaultConstants.nickName,
            CustomerVaultConstants.merchantRefNum,  
            CustomerVaultConstants.accountNumber,
            CustomerVaultConstants.accountHolderName,               
            CustomerVaultConstants.sortCode,
            CustomerVaultConstants.billingAddressId,   
            });
            
            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/bacsbankaccounts/" + account.id()),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            BACSBankAccounts returnVal = new BACSBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// update EFTBankAccount
        /// </summary>
        /// <param name="EFTBankAccount">EFTBankAccount</param>
        /// <returns>EFTBankAccount</returns>
        public EFTBankAccounts update(EFTBankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setRequiredFields(new List<string> {
                 CustomerVaultConstants.transitNumber,
                CustomerVaultConstants.institutionId,
                CustomerVaultConstants.accountHolderName,               
                CustomerVaultConstants.billingAddressId                                
            });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {
                CustomerVaultConstants.nickName,
                CustomerVaultConstants.merchantRefNum, 
                CustomerVaultConstants.accountNumber
            });

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/eftbankaccounts/" + account.id()),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            EFTBankAccounts returnVal = new EFTBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// update SEPABankAccount
        /// </summary>
        /// <param name="SEPABankAccount">SEPABankAccount</param>
        /// <returns>SEPABankAccount</returns>
        public SEPABankAccounts update(SEPABankAccounts account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.profileId });
            account.checkRequiredFields();
            account.setOptionalFields(new List<string> {
            CustomerVaultConstants.nickName,
            CustomerVaultConstants.merchantRefNum,  
            CustomerVaultConstants.accountHolderName,
            CustomerVaultConstants.iban,
            CustomerVaultConstants.bic,
            CustomerVaultConstants.billingAddressId,  
            });

            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/sepabankaccounts/" + account.id()),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            SEPABankAccounts returnVal = new SEPABankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// update Mandates
        /// </summary>
        /// <param name="Mandates">Mandates</param>
        /// <returns>Mandates</returns>
        public Mandates update(Mandates account)
        {
            account.setRequiredFields(new List<string> { CustomerVaultConstants.status });
            account.checkRequiredFields();            
            Request request = new Request(
                method: RequestType.PUT,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/mandates/" + account.id()),
                body: account
            );
            dynamic response = this.client.processRequest(request);

            Mandates returnVal = new Mandates(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// delete profile
        /// </summary>
        /// <param name="profile">Profile</param>
        /// <returns>bool</returns>
        public bool delete(Profile profile)
        {
            profile.setRequiredFields(new List<string> { CustomerVaultConstants.id });
            profile.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + profile.id())
            );

            this.client.processRequest(request);

            return true;
        }

        /// <summary>
        ///Delete address 
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns>bool</returns>
        public bool delete(Address address)
        {
            address.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            address.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + address.profileId() + "/addresses/" + address.id())
            );

            this.client.processRequest(request);
            return true;
        }

        /// <summary>
        /// Delete card 
        /// </summary>
        /// <param name="card">Card</param>
        /// <returns>bool</returns>
        public bool delete(Card card)
        {
            card.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            card.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + card.profileId() + "/cards/" + card.id()),
                body: card
            );

            this.client.processRequest(request);

            return true;
        }

        /// <summary>
        ///Delete ACHBankAccount 
        /// </summary>
        /// <param name="ACHBankAccount">ACHBankAccount</param>
        /// <returns>bool</returns>
        public bool delete(ACHBankAccounts account)
        {
            account.setRequiredFields(new List<string> { 
               CustomerVaultConstants.profileId,
               CustomerVaultConstants.id              
            });
            account.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/achbankaccounts/" + account.id())
            );

            this.client.processRequest(request);
            return true;
        }

        /// <summary>
        ///Delete BACSBankAccount 
        /// </summary>
        /// <param name="BACSBankAccount">BACSBankAccount</param>
        /// <returns>bool</returns>
        public bool delete(BACSBankAccounts account)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/bacsbankaccounts/" + account.id())
            );

            this.client.processRequest(request);
            return true;
        }

        /// <summary>
        ///Delete EFTBankAccount 
        /// </summary>
        /// <param name="EFTBankAccount">EFTBankAccount</param>
        /// <returns>bool</returns>
        public bool delete(EFTBankAccounts account)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/eftbankaccounts/" + account.id())
            );

            this.client.processRequest(request);
            return true;
        }


        /// <summary>
        ///Delete SEPABankAccount 
        /// </summary>
        /// <param name="SEPABankAccount">SEPABankAccount</param>
        /// <returns>bool</returns>
        public bool delete(SEPABankAccounts account)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();

            Request request = new Request(
                method: RequestType.DELETE,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/sepabankaccounts/" + account.id())
            );

            this.client.processRequest(request);
            return true;
        }

        /// <summary>
        ///Delete Mandates 
        /// </summary>
        /// <param name="Mandates">Mandates</param>
        /// <returns>bool</returns>
        public bool delete(Mandates account)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id,
                CustomerVaultConstants.bankAccountId
            });           
            Request request = new Request(
                method: RequestType.DELETE,
                 uri: this.prepareURI("/profiles/" + account.profileId() + "/mandates/" + account.id())
            );

            this.client.processRequest(request);
            return true;
        }

        /// <summary>
        /// get profile with subcomponents
        /// </summary>
        /// <param name="profile">Profile</param>
        /// <returns>Profile</returns>
        public Profile get(Profile profile, bool includeAddresses = false, bool includeCards = false, bool includeACHBankAccounts = false,
            bool includeBACSBankAccounts = false, bool includeEFTBankAccounts = false, bool includeSEPABankAccounts = false)
        {
            profile.setRequiredFields(new List<string> { CustomerVaultConstants.id });
            profile.checkRequiredFields();

            Dictionary<string, string> queryStr = new Dictionary<string, string>();                       
            StringBuilder toInclude = new StringBuilder();
            if (includeAddresses)
            {                                            
                toInclude.Append("addresses");
            }
            if (includeCards)
            {
                if (toInclude.Length > 0)
                {
                    toInclude.Append(",");
                }
                toInclude.Append("cards");
            }
            if (includeACHBankAccounts)
            {
                if (toInclude.Length > 0)
                {
                    toInclude.Append(",");
                }
                toInclude.Append("achbankaccounts");
            }
            if (includeBACSBankAccounts)
            {
                if (toInclude.Length > 0)
                {
                    toInclude.Append(",");
                }
                toInclude.Append("bacsbankaccounts");
            }
            if (includeEFTBankAccounts)
            {
                if (toInclude.Length > 0)
                {
                    toInclude.Append(",");
                }
                toInclude.Append("eftbankaccounts");
            }
            if (includeSEPABankAccounts)
            {
                if (toInclude.Length > 0)
                {
                    toInclude.Append(",");
                }
                toInclude.Append("sepabankaccounts");
            }

            queryStr.Add("fields", toInclude.ToString());                                          
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + profile.id()),
                queryString: queryStr
            );

            dynamic response = this.client.processRequest(request);

            return new Profile(response);
        }

        /// <summary>
        /// Get address 
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns>Address</returns>
        public Address get(Address address)
        {
            address.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            address.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + address.profileId() + "/addresses/" + address.id()),
                body: address
            );

            dynamic response = this.client.processRequest(request);

            Address returnVal = new Address(response);
            returnVal.profileId(address.profileId());
            return returnVal;
        }

        /// <summary>
        /// Get card 
        /// </summary>
        /// <param name="card">Card</param>
        /// <returns>Card</returns>
        public Card get(Card card)
        {
            card.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            card.checkRequiredFields();

            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + card.profileId() + "/cards/" + card.id())
            );

            dynamic response = this.client.processRequest(request);

            Card returnVal = new Card(response);
            returnVal.profileId(card.profileId());
            return returnVal;
        }

        /// <summary>
        /// Get ACHBankAccount 
        /// </summary>
        /// <param name="ACHBankAccount">ACHBankAccount</param>
        /// <returns>ACHBankAccount</returns>
        public ACHBankAccounts get(ACHBankAccounts account)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();           
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/achbankaccounts/" + account.id())
            );

            dynamic response = this.client.processRequest(request);

            ACHBankAccounts returnVal = new ACHBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// Get BACSBankAccount 
        /// </summary>
        /// <param name="BACSBankAccount">BACSBankAccount</param>
        /// <returns>BACSBankAccount</returns>
        public BACSBankAccounts get(BACSBankAccounts account)
        {
            account.setRequiredFields(new List<string> { 
                CustomerVaultConstants.profileId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/bacsbankaccounts/" + account.id())
            );

            dynamic response = this.client.processRequest(request);

            BACSBankAccounts returnVal = new BACSBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// Get EFTBankAccount 
        /// </summary>
        /// <param name="EFTBankAccount">EFTBankAccount</param>
        /// <returns>EFTBankAccount</returns>
        public EFTBankAccounts get(EFTBankAccounts account)
        {
            account.setRequiredFields(new List<string> {                 
                CustomerVaultConstants.billingAddressId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/eftbankaccounts/" + account.id())
            );

            dynamic response = this.client.processRequest(request);

            EFTBankAccounts returnVal = new EFTBankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// Get SEPABankAccount 
        /// </summary>
        /// <param name="SEPABankAccount">SEPABankAccount</param>
        /// <returns>SEPABankAccount</returns>
        public SEPABankAccounts get(SEPABankAccounts account)
        {
            account.setRequiredFields(new List<string> {                 
                CustomerVaultConstants.billingAddressId,
                CustomerVaultConstants.id
            });
            account.checkRequiredFields();
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/sepabankaccounts/" + account.id())
            );

            dynamic response = this.client.processRequest(request);

            SEPABankAccounts returnVal = new SEPABankAccounts(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        /// <summary>
        /// Get Mandates 
        /// </summary>
        /// <param name="Mandates">Mandates</param>
        /// <returns>Mandates</returns>
        public Mandates get(Mandates account)
        {
            account.setRequiredFields(new List<string> {                               
                CustomerVaultConstants.id,
                CustomerVaultConstants.profileId
            });            
            account.checkRequiredFields();            
            Request request = new Request(
                method: RequestType.GET,
                uri: this.prepareURI("/profiles/" + account.profileId() + "/mandates/" + account.id())
            );

            dynamic response = this.client.processRequest(request);

            Mandates returnVal = new Mandates(response);
            returnVal.profileId(account.profileId());
            return returnVal;
        }

        private string prepareURI(string path)
        {
            return this.uri + path;
        }
    }
}
