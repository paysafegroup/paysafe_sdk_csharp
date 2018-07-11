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

namespace Paysafe.Common
{
    /**
     * GlobalConstants class contains all strings that are sent and returned from the netbanx api
     */
    public class GlobalConstants
    {
        //////////// REQUEST PARAMETER STRINGS ////////////
        public static readonly string accordD = "accordD";
        public static readonly string acquirerResponse = "acquirerResponse";
        public static readonly string addendumData = "addendumData";
        public static readonly string addresses = "addresses";
        public static readonly string amount = "amount";
        public static readonly string ancillaryFees = "ancillaryFees";
        public static readonly string associatedTransactions = "associatedTransactions";
        public static readonly string authCode = "authCode";
        public static readonly string authentication = "authentication";
        public static readonly string authenticationMethod = "authenticationMethod";
        public static readonly string authorizationId = "authorizationId";
        public static readonly string authType = "authType";
        public static readonly string availableToRefund = "availableToRefund";
        public static readonly string availableToSettle = "availableToSettle";
        public static readonly string avsCode = "avsCode";
        public static readonly string avsResponse = "avsResponse";
        public static readonly string balanceResponse = "balanceResponse";
        public static readonly string batchNumber = "batchNumber";
        public static readonly string billingAddressId = "billingAddressId";
        public static readonly string billingDetails = "billingDetails";
        public static readonly string brand = "brand";
        public static readonly string callback = "callback";
        public static readonly string card = "card";
        public static readonly string cardBin = "cardBin";
        public static readonly string cardEnrollementMethod = "cardEnrollementMethod";
        public static readonly string cardExpiry = "cardExpiry";
        public static readonly string cardNum = "cardNum";
        public static readonly string cards = "cards";
        public static readonly string cardType = "cardType";
        public static readonly string carrier = "carrier";
        public static readonly string cavv = "cavv";
        public static readonly string cellPhone = "cellPhone";
        public static readonly string childAccountNum = "childAccountNum";
        public static readonly string city = "city";
        public static readonly string code = "code";
        public static readonly string confirmationNumber = "confirmationNumber";
        public static readonly string country = "country";
        public static readonly string currencyCode = "currencyCode";
        public static readonly string customerIp = "customerIp";
        public static readonly string customerNotificationEmail = "customerNotificationEmail";
        public static readonly string cvdVerification = "cvdVerification";
        public static readonly string cvv = "cvv";
        public static readonly string cvv2Result = "cvv2Result";
        public static readonly string cvvVerification = "cvvVerification";
        public static readonly string dateOfBirth = "dateOfBirth";
        public static readonly string dateTime = "dateTime";
        public static readonly string day = "day";
        public static readonly string defaultCardIndicator = "defaultCardIndicator";
        public static readonly string defaultShippingAddressIndicator = "defaultShippingAddressIndicator";
        public static readonly string delimiter = "delimiter";
        public static readonly string description = "description";
        public static readonly string details = "details";
        public static readonly string dueDate = "dueDate";
        public static readonly string dupCheck = "dupCheck";
        public static readonly string dynamicDescriptor = "dynamicDescriptor";
        public static readonly string eci = "eci";
        public static readonly string effectiveDate = "effectiveDate";
        public static readonly string email = "email";
        public static readonly string error = "error";
        public static readonly string errorCode = "errorCode";
        public static readonly string errorMessage = "errorMessage";
        public static readonly string expiry = "expiry";
        public static readonly string extendedOptions = "extendedOptions";
        public static readonly string field = "field";
        public static readonly string fieldErrors = "fieldErrors";
        public static readonly string financingType = "financingType";
        public static readonly string firstName = "firstName";
        public static readonly string format = "format";
        public static readonly string gender = "gender";
        public static readonly string gracePeriod = "gracePeriod";
        public static readonly string holderName = "holderName";
        public static readonly string houseNumberVerification = "houseNumberVerification";
        public static readonly string href = "href";
        public static readonly string id = "id";
        public static readonly string ip = "ip";
        public static readonly string key = "key";
        public static readonly string keywords = "keywords";
        public static readonly string lastDigits = "lastDigits";
        public static readonly string lastName = "lastName";
        public static readonly string lastUpdate = "lastUpdate";
        public static readonly string link = "link";
        public static readonly string links = "links";
        public static readonly string locale = "locale";
        public static readonly string masterCardAssignedId = "masterCardAssignedId";
        public static readonly string masterPass = "masterPass";
        public static readonly string merchantCustomerId = "merchantCustomerId";
        public static readonly string merchantDescriptor = "merchantDescriptor";
        public static readonly string merchantNotificationEmail = "merchantNotificationEmail";
        public static readonly string merchantRefNum = "merchantRefNum";
        public static readonly string message = "message";
        public static readonly string mid = "mid";
        public static readonly string middleName = "middleName";
        public static readonly string mode = "mode";
        public static readonly string month = "month";
        public static readonly string nationality = "nationality";
        public static readonly string nickName = "nickName";
        public static readonly string occurrence = "occurrence";
        public static readonly string occurrenceInitial = "INITIAL";
        public static readonly string occurrenceSubsequent = "SUBSEQUENT";
        public static readonly string orderId = "orderId";
        public static readonly string originalMerchantRefNum = "originalMerchantRefNum";
        public static readonly string paymentMethod = "paymentMethod";
        public static readonly string paymentToken = "paymentToken";
        public static readonly string paymentType = "paymentType";
        public static readonly string payPassWalletIndicator = "payPassWalletIndicator";
        public static readonly string phone = "phone";
        public static readonly string plan = "plan";
        public static readonly string profile = "profile";
        public static readonly string profileId = "profileId";
        public static readonly string quantity = "quantity";
        public static readonly string recipientAccountNumber = "recipientAccountNumber";
        public static readonly string recipientDateOfBirth = "recipientDateOfBirth";
        public static readonly string recipientLastName = "recipientLastName";
        public static readonly string recipientName = "recipientName";
        public static readonly string recipientZip = "recipientZip";
        public static readonly string recurring = "recurring";
        public static readonly string redirect = "redirect";
        public static readonly string reference = "reference";
        public static readonly string referenceNbr = "referenceNbr";
        public static readonly string refunded = "refunded";
        public static readonly string rel = "rel";
        public static readonly string requestId = "requestId";
        public static readonly string responseCode = "responseCode";
        public static readonly string responseId = "responseId";
        public static readonly string responseReasonCode = "responseReasonCode";
        public static readonly string retries = "retries";
        public static readonly string returnKeys = "returnKeys";
        public static readonly string reversed = "reversed";
        public static readonly string riskReasonCode = "riskReasonCode";
        public static readonly string seqNumber = "seqNumber";
        public static readonly string settled = "settled";
        public static readonly string settlementId = "settlementId";
        public static readonly string settlements = "settlements";
        public static readonly string settleWithAuth = "settleWithAuth";
        public static readonly string shipMethod = "shipMethod";
        public static readonly string shippingDetails = "shippingDetails";
        public static readonly string shoppingCart = "shoppingCart";
        public static readonly string signatureStatus = "signatureStatus";
        public static readonly string sku = "sku";
        public static readonly string state = "state";
        public static readonly string status = "status";
        public static readonly string storedCredential = "storedCredential";
        public static readonly string street = "street";
        public static readonly string street2 = "street2";
        public static readonly string synchronous = "synchronous";
        public static readonly string term = "term";
        public static readonly string terminalId = "terminalId";
        public static readonly string threeDEnrollment = "threeDEnrollment";
        public static readonly string threeDEnrolment = "threeDEnrolment";
        public static readonly string threeDResult = "threeDResult";
        public static readonly string totalAmount = "totalAmount";
        public static readonly string track1 = "track1";
        public static readonly string track2 = "track2";
        public static readonly string transaction = "transaction";
        public static readonly string txnDateTime = "txnDateTime";
        public static readonly string txnTime = "txnTime";
        public static readonly string type = "type";
        public static readonly string typeAdhoc = "ADHOC";
        public static readonly string typeTopup = "TOPUP";
        public static readonly string typeRecurring = "RECURRING";
        public static readonly string uri = "uri";
        public static readonly string useAsShippingAddress = "useAsShippingAddress";
        public static readonly string value = "value";
        public static readonly string visaAdditionalAuthData = "visaAdditionalAuthData";
        public static readonly string xid = "xid";
        public static readonly string year = "year";
        public static readonly string zip = "zip";
        public static readonly string zipVerification = "zipVerification";
        public static readonly string accountNumber = "accountNumber";
        public static readonly string accountHolderName = "accountHolderName";
        public static readonly string routingNumber = "routingNumber";
        public static readonly string accountType = "accountType"; 
        public static readonly string sortCode = "sortCode";
        public static readonly string mandates = "mandates";
        public static readonly string mandateReference = "mandateReference";
        public static readonly string ach = "ach";
        public static readonly string sepa = "sepa";
        public static readonly string bacs = "bacs";
        public static readonly string eft = "eft";
        public static readonly string payMethod = "payMethod";
        public static readonly string WEB = "WEB";
        public static readonly string TEL = "TEL";
        public static readonly string PPD = "PPD";
        public static readonly string CCD = "CCD";
        public static readonly string paymentDescriptor = "paymentDescriptor";
        public static readonly string iban = "iban";
        public static readonly string bic = "bic";
        public static readonly string transitNumber = "transitNumber";
        public static readonly string institutionId = "institutionId";
        public static readonly string bankAccountId = "bankAccountId";
        public static readonly string accountTypeChecking = "CHECKING";
        public static readonly string accountTypeLoan = "LOAN";
        public static readonly string accountTypeSavings = "SAVINGS";

        ///

        public static readonly string achBankAccounts = "achBankAccounts";
        public static readonly string bacsBankAccounts = "bacsBankAccounts";
        public static readonly string sepaBankAccounts = "sepaBankAccounts";
        public static readonly string eftBankAccounts = "eftBankAccounts";
        public static readonly string billingAddress = "billingAddress";
        public static readonly string enrollmentchecks = "enrollmentchecks";

        //////////// RESPONSE VALIDATON STRINGS ////////////
        public static readonly string authTypeAuth = "auth";
        public static readonly string authTypePurchase = "purchase";
        public static readonly string authTypeRefund = "refund";
        public static readonly string authTypeSettlement = "settlement";
        public static readonly string carrierAnpost = "APS";
        public static readonly string carrierAPC = "APC";
        public static readonly string carrierCanadaPost = "CAD";
        public static readonly string carrierCityLink = "CLK";
        public static readonly string carrierDHL = "DHL";
        public static readonly string carrierEMS = "EMS";
        public static readonly string carrierFedEx = "FEX";
        public static readonly string carrierNexWorldWide = "NEX";
        public static readonly string carrierOther = "OTHER";
        public static readonly string carrierRoyalMail = "RML";
        public static readonly string carrierUPS = "UPS";
        public static readonly string carrierUSPS = "USPS";
        public static readonly string financingDeferredPayment = "DEFERRED_PAYMENT";
        public static readonly string financingEqualPayment = "EQUAL_PAYMENT";
        public static readonly string formatFORM = "form-urlencoded";
        public static readonly string formatGET = "get";
        public static readonly string formatJSON = "json";
        public static readonly string formatXML = "xml";
        public static readonly string genderFemale = "F";
        public static readonly string genderMale = "M";
        public static readonly string localeEnGb = "en_GB";
        public static readonly string localeEnUs = "en_US";
        public static readonly string localeFrCa = "fr_CA";
        public static readonly string relCancelUrl = "cancel_url";
        public static readonly string relOnDecline = "on_decline";
        public static readonly string relOnError = "on_error";
        public static readonly string relOnHold = "on_hold";
        public static readonly string relOnSuccess = "on_success";
        public static readonly string relOnTimeout = "on_timeout";
        public static readonly string relResendCallback = "resend_callback";
        public static readonly string relReturnUrl = "return_url";
        public static readonly string relSelf = "self";
        public static readonly string shipMethodLowestCost = "C";
        public static readonly string shipMethodNextDay = "N";
        public static readonly string shipMethodOther = "O";
        public static readonly string shipMethodTwoDay = "T";
        public static readonly string statusActive = "ACTIVE";        
        public static readonly string statusInvalid = "INVALID";
        public static readonly string statusInactive = "INACTIVE";
        public static readonly string statusDeclined = "DECLINED";
        public static readonly string statusBatched = "BATCHED";
        public static readonly string statusRejected = "REJECTED";
        public static readonly string statusDisputed = "DISPUTED";
        public static readonly string statusReason = "REASON";
        public static readonly string statusChangeDate = "statusChangeDate";
        public static readonly string statusReasonCode = "statusReasonCode";
        public static readonly string statusCancelled = "CANCELLED";
        public static readonly string statusCompleted = "COMPLETED";
        public static readonly string statusFailed = "FAILED";
        public static readonly string statusInitial = "INITIAL";
        public static readonly string statusPending = "PENDING";
        public static readonly string statusProcessing = "PROCESSING";
        public static readonly string statusReceived = "RECEIVED";
        public static readonly string recurringInitial = "INITIAL";
        public static readonly string recurringRecurring = "RECURRING";
        public static readonly string validationHeld = "HELD";
        public static readonly string validationMatch = "MATCH";
        public static readonly string validationMatchAddressOnly = "MATCH_ADDRESS_ONLY";
        public static readonly string validationMatchZipOnly = "MATCH_ZIP_ONLY";
        public static readonly string validationNoMatch = "NO_MATCH";
        public static readonly string validationNotProcessed = "NOT_PROCESSED";
        public static readonly string validationUnknown = "UNKNOWN";
        public static readonly string singleUseToken = "singleUseToken";
        public static readonly string currency = "currency";
        public static readonly string userAgent = "userAgent";
        public static readonly string acceptHeader = "acceptHeader";
        public static readonly string merchantUrl = "merchantUrl";
        public static readonly string acsURL = "acsURL";
        public static readonly string paReq = "paReq";
        public static readonly string threeDEnrolled = "Y";
        public static readonly string threeDNotEnrolled = "N";
        public static readonly string threeDEnrollmentUnavailable = "U";
        public static readonly string paResp = "paRes";
        public static readonly string authenticated = "Y";
        public static readonly string authenticationAttempted = "A";
        public static readonly string authenticationFailed = "N";
        public static readonly string authenticationUnavailable = "U";
        public static readonly string authenticationError = "E";
        public static readonly string signatureSatisfied = "Y";
        public static readonly string signatureNotSatisfied = "N";
        public static readonly string enrollmentId = "enrollmentId";
        
        public static readonly string AM = "AM";
        public static readonly string DC = "DC";
        public static readonly string DI = "DI";
        public static readonly string JC = "JC";
        public static readonly string MC = "MC";
        public static readonly string MD = "MD";
        public static readonly string SF = "SF";
        public static readonly string SO = "SO";
        public static readonly string VI = "VI";
        public static readonly string VD = "VD";
        public static readonly string VE = "VE";
        
        public static readonly List<string> enumCarrier = new List<string>{
            carrierAPC,
            carrierAnpost,
            carrierCanadaPost,
            carrierDHL,
            carrierFedEx,
            carrierRoyalMail,
            carrierUPS,
            carrierUSPS,
            carrierCityLink,
            carrierEMS,
            carrierNexWorldWide,
            carrierOther
        };
        public static readonly List<string> enumGender = new List<string>() {
            genderMale,
            genderFemale
        };
        public static readonly List<string> enumLocale = new List<string>() {
            localeEnUs,
            localeFrCa,
            localeEnGb
        };
        public static readonly List<string> enumShipMethod = new List<string>() {
            shipMethodNextDay,
            shipMethodTwoDay,
            shipMethodLowestCost,
            shipMethodOther
        };
    }
}
