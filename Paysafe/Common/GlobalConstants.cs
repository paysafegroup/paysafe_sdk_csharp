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
        public static readonly string initialTransactionId = "initialTransactionId";
        public static readonly string externalInitialTransactionId = "externalInitialTransactionId";
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
        public static readonly string threeDSecureVersion = "threeDSecureVersion";
        public static readonly string directoryServerTransactionId = "directoryServerTransactionId";
        public static readonly string sku = "sku";
        public static readonly string state = "state";
        public static readonly string storedCredential = "storedCredential";
        public static readonly string status = "status";
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
        public static readonly string phoneNumber = "phoneNumber";
        public static readonly string passengerCode = "passengerCode";
        public static readonly string passenger1 = "passenger1";
        public static readonly string passenger2 = "passenger2";
        public static readonly string passenger3 = "passenger3";
        public static readonly string passenger4 = "passenger4";
        public static readonly string passenger5 = "passenger5";
        public static readonly string passenger6 = "passenger6";
        public static readonly string passenger7 = "passenger7";
        public static readonly string passenger8 = "passenger8";
        public static readonly string passenger9 = "passenger9";
        public static readonly string passenger10 = "passenger10";



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
        public static readonly string genderOther = "O";
        public static readonly string genderNotSpecified = "N";
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
        public static readonly string shipMethodSameDay = "S";

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
        public static readonly string threeDResultY = "Y";
        public static readonly string threeDResultA = "A";
        public static readonly string threeDResultN = "N";
        public static readonly string threeDResultU = "U";
        public static readonly string threeDResultE = "E";
        public static readonly string threeDResultR = "R";
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
        public static readonly string authenticationChallenge = "C";
        public static readonly string authenticationRejected = "R";
        public static readonly string authenticationError = "E";
        public static readonly string signatureSatisfied = "Y";
        public static readonly string signatureNotSatisfied = "N";
        public static readonly string enrollmentId = "enrollmentId";
        public static readonly string deviceFingerprintingId = "deviceFingerprintingId";
        public static readonly string payload = "payload";
        public static readonly string sdkChallengePayload = "sdkChallengePayload";
        public static readonly string maxAuthorizationsForInstalmentPayment = "maxAuthorizationsForInstalmentPayment";

        public static readonly string transactionIntent = "transactionIntent";
        public static readonly string transactionGoodsOrServicePurchase = "GOODS_OR_SERVICE_PURCHASE";
        public static readonly string transactionCheckAcceptance = "CHECK_ACCEPTANCE";
        public static readonly string transactionAccountfunding = "ACCOUNT_FUNDING";
        public static readonly string transactionQuasiCashTransaction = "QUASI_CASH_TRANSACTION";
        public static readonly string transactionPrepaidActivation = "PREPAID_ACTIVATION";

        public static readonly string authenticationPurpose = "authenticationPurpose";
        public static readonly string authPurposePaymentTransaction = "PAYMENT_TRANSACTION";
        public static readonly string authPurposeRecurringTransaction = "RECURRING_TRANSACTION";
        public static readonly string authPurposeInstalmentTransaction = "INSTALMENT_TRANSACTION";
        public static readonly string authPurposeAddCard = "ADD_CARD";
        public static readonly string authPurposeMaintainCard = "MAINTAIN_CARD";
        public static readonly string authPurposeEMVTokenVerification = "EMV_TOKEN_VERIFICATION";

        public static readonly string deviceChannel = "deviceChannel";
        public static readonly string deviceChannelBrowser = "BROWSER";
        public static readonly string deviceChannelSDK = "SDK";
        public static readonly string deviceChannel3RI = "3RI";

        public static readonly string messageCategory = "messageCategory";
        public static readonly string messageCategoryPayment = "PAYMENT";
        public static readonly string messageCategoryNonPayment = "NON_PAYMENT";

        public static readonly string initialPurchaseTime = "initialPurchaseTime";

        public static readonly string requestorChallengePreference = "requestorChallengePreference";
        public static readonly string reqChallengeNoPref = "NO_PREFERENCE";
        public static readonly string reqChallengeChallengeReq = "CHALLENGE_REQUESTED";
        public static readonly string reqChallengeChallengeMandate = "CHALLENGE_MANDATED";

        public static readonly string isElectronicDelivery = "isElectronicDelivery";
        public static readonly string electronicDelivery = "electronicDelivery";

        public static readonly string preOrderItemAvailabilityDate = "preOrderItemAvailabilityDate";

        public static readonly string preOrderPurchaseIndicator = "preOrderPurchaseIndicator";
        public static readonly string preOrderPurchaseMerchandiseAvailable = "MERCHANDISE_AVAILABLE";
        public static readonly string preOrderPurchaseFutureAvailable = "FUTURE_AVAILABILITY";

        public static readonly string reorderItemsIndicator = "reorderItemsIndicator";
        public static readonly string reorderIndicatorFirstTimeOrder = "FIRST_TIME_ORDER";
        public static readonly string reorderIndicatorReorder = "REORDER";

        public static readonly string shippingIndicator = "shippingIndicator";
        public static readonly string shippingToBillingAddress = "SHIP_TO_BILLING_ADDRESS";
        public static readonly string shippingToVerifiedAddress = "SHIP_TO_VERIFIED_ADDRESS";
        public static readonly string shippingToDifferentaddress = "SHIP_TO_DIFFERENT_ADDRESS";
        public static readonly string shippingToStore = "SHIP_TO_STORE";
        public static readonly string shippingDigitalGoods = "DIGITAL_GOODS";
        public static readonly string shippingTravelAndEvent = "TRAVEL_AND_EVENT_TICKETS";
        public static readonly string shippingOther = "OTHER";

        public static readonly string orderItemDetails = "orderItemDetails";
        public static readonly string purchasedGiftCardDetails = "purchasedGiftCardDetails";
        public static readonly string count = "count";
        public static readonly string billingCycle = "billingCycle";
        public static readonly string endDate = "endDate";
        public static readonly string frequency = "frequency";
        public static readonly string browserDetails = "browserDetails";
        public static readonly string colorDepthBits = "colorDepthBits";
        public static readonly string javaEnabled = "javaEnabled";
        public static readonly string javascriptEnabled = "javascriptEnabled";
        public static readonly string language = "language";
        public static readonly string screenHeight = "screenHeight";
        public static readonly string screenWidth = "screenWidth";
        public static readonly string timezoneOffset = "timezoneOffset";
        public static readonly string userAccountDetails = "userAccountDetails";
        public static readonly string addCardAttemptsForLastDay = "addCardAttemptsForLastDay";
        public static readonly string changedDate = "changedDate";
        public static readonly string createdDate = "createdDate";
        public static readonly string passwordChangedDate = "passwordChangedDate";
        public static readonly string paymentAccountDetails = "paymentAccountDetails";
        public static readonly string priorThreeDSAuthentication = "priorThreeDSAuthentication";
        public static readonly string data = "data";
        public static readonly string time = "time";
        public static readonly string shippingDetailsUsage = "shippingDetailsUsage";
        public static readonly string cardHolderNameMatch = "cardHolderNameMatch";
        public static readonly string initialUsageDate = "initialUsageDate";
        public static readonly string suspiciousAccountActivity = "suspiciousAccountActivity";
        public static readonly string totalPurchasesSixMonthCount = "totalPurchasesSixMonthCount";
        public static readonly string transactionCountForPreviousDay = "transactionCountForPreviousDay";
        public static readonly string transactionCountForPreviousYear = "transactionCountForPreviousYear";
        public static readonly string travelDetails = "travelDetails";
        public static readonly string isAirTravel = "isAirTravel";
        public static readonly string airlineCarrier = "airlineCarrier";
        public static readonly string departureDate = "departureDate";
        public static readonly string destination = "destination";
        public static readonly string origin = "origin";
        public static readonly string passengerFirstName = "passengerFirstName";
        public static readonly string passengerLastName = "passengerLastName";
        public static readonly string userLogin = "userLogin";
        
        public static readonly string initialUsageRange = "initialUsageRange";
        public static readonly string currentTransaction = "CURRENT_TRANSACTION";
        
        public static readonly string method = "method";
        public static readonly string frictionlessAuthentiocation = "FRICTIONLESS_AUTHENTICATION";
        public static readonly string acsChallenge = "ACS_CHALLENGE";
        public static readonly string avsVerified = "AVS_VERIFIED";
        public static readonly string otherIssuerMethod = "OTHER_ISSUER_METHOD";

        public static readonly string noLogin = "NO_LOGIN";
        public static readonly string internalCredentials = "INTERNAL_CREDENTIALS";
        public static readonly string federatedId = "FEDERATED_ID";
        public static readonly string issuerCredentials = "ISSUER_CREDENTIALS";
        public static readonly string thirdPartyAuthentication = "THIRD_PARTY_AUTHENTICATION";
        public static readonly string fidoAuthenticator = "FIDO_AUTHENTICATOR";

        public static readonly string changedRange = "changedRange";
        public static readonly string duringTransaction = "DURING_TRANSACTION";
        public static readonly string lessThanThirtyDays = "LESS_THAN_THIRTY_DAYS";
        public static readonly string thirtyToSixtyDays = "THIRTY_TO_SIXTY_DAYS";
        public static readonly string moreThanSixtyDays = "MORE_THAN_SIXTY_DAYS";

        public static readonly string createdRange = "createdRange";
        public static readonly string noAccount = "NO_ACCOUNT";
        
        public static readonly string passwordChangedRange = "passwordChangedRange";
        public static readonly string noChange = "NO_CHANGE";

        public static readonly string satisfiedSignatureStatus = "Y";
        public static readonly string failedSignatureStatus = "N";

        public static readonly string threeDSecureServerTransactionId = "threeDSecureServerTransactionId";
        public static readonly string mcc = "mcc";
        public static readonly string merchantName = "merchantName";

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

        public static readonly string airlineTravelDetails = "airlineTravelDetails";
        public static readonly string passengerName = "passengerName";
        public static readonly string ticket = "ticket";
        public static readonly string ticketNumber = "ticketNumber";
        public static readonly string computerizedReservationSystem = "computerizedReservationSystem";
        public static readonly string customerReferenceNumber = "customerReferenceNumber";
        public static readonly string isRestrictedTicket = "isRestrictedTicket";
        public static readonly string name = "name";
        public static readonly string travelAgency = "travelAgency";
        public static readonly string travelAgencyAddress = "travelAgencyAddress";
        public static readonly string passengers = "passengers";
        public static readonly string leg1 = "leg1";
        public static readonly string leg2 = "leg2";
        public static readonly string leg3 = "leg3";
        public static readonly string leg4 = "leg4";
        public static readonly string carrierCode = "carrierCode";
        public static readonly string flightNumber = "flightNumber";
        public static readonly string flight = "flight";
        public static readonly string serviceClass = "serviceClass";
        public static readonly string isStopOverAllowed = "isStopOverAllowed";
        public static readonly string fareBasis = "fareBasis";
        public static readonly string tripLegs = "tripLegs";
        public static readonly string passengerNameRecord = "passengerNameRecord";
        public static readonly string additionalBookingReference = "additionalBookingReference";
        public static readonly string totalFare = "totalFare";
        public static readonly string totalFee = "totalFee";
        public static readonly string totalTaxes = "totalTaxes";

        public static readonly List<string> enumComputerizedReservationSystem = new List<string>
        {
            "BLAN",
            "DALA",
            "DATS",
            "DERD",
            "PARS",
            "SABR",
            "STRT",
            "TUID"
        };

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
        public static readonly List<string> enumGenderPassenger = new List<string>()
        {
            genderMale,
            genderFemale,
            genderOther,
            genderNotSpecified
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
        public static readonly List<string> enumCountry = new List<string>()
        {
            "AD", "AE", "AF", "AG", "AI",
            "AL", "AM", "AO", "AQ", "AR",
            "AS", "AT", "AU", "AW", "AX",
            "AZ", "BA", "BB", "BD", "BE",
            "BF", "BG", "BH", "BI", "BJ",
            "BL", "BM", "BN", "BO", "BQ",
            "BR", "BS", "BT", "BV", "BW",
            "BY", "BZ", "CA", "CC", "CD",
            "CF", "CG", "CH", "CI", "CK",
            "CL", "CM", "CN", "CO", "CR",
            "CU", "CV", "CW", "CX", "CY",
            "CZ", "DE", "DJ", "DK", "DM",
            "DO", "DZ", "EC", "EE", "EG",
            "EH", "ER", "ES", "ET", "FI",
            "FJ", "FK", "FM", "FO", "FR",
            "GA", "GB", "GD", "GE", "GF",
            "GG", "GH", "GI", "GL", "GM",
            "GN", "GP", "GQ", "GR", "GS",
            "GT", "GU", "GW", "GY", "HK",
            "HM", "HN", "HR", "HT", "HU",
            "ID", "IE", "IL", "IM", "IN",
            "IO", "IQ", "IR", "IS", "IT",
            "JE", "JM", "JO", "JP", "KE",
            "KG", "KH", "KI", "KM", "KN",
            "KP", "KR", "KW", "KY", "KZ",
            "LA", "LB", "LC", "LI", "LK",
            "LR", "LS", "LT", "LU", "LV",
            "LY", "MA", "MC", "MD", "ME",
            "MF", "MG", "MH", "MK", "ML",
            "MM", "MN", "MO", "MP", "MQ",
            "MR", "MS", "MT", "MU", "MV",
            "MW", "MX", "MY", "MZ", "NA",
            "NC", "NE", "NF", "NG", "NI",
            "NL", "NO", "NP", "NR", "NU",
            "NZ", "OM", "PA", "PE", "PF",
            "PG", "PH", "PK", "PL", "PM",
            "PN", "PR", "PS", "PT", "PW",
            "PY", "QA", "RE", "RO", "RS",
            "RU", "RW", "SA", "SB", "SC",
            "SD", "SE", "SG", "SH", "SI",
            "SJ", "SK", "SL", "SM", "SN",
            "SO", "SR", "SS", "ST", "SV",
            "SX", "SY", "SZ", "TC", "TD",
            "TF", "TG", "TH", "TJ", "TK",
            "TL", "TM", "TN", "TO", "TR",
            "TT", "TV", "TW", "TZ", "UA",
            "UG", "UM", "US", "UY", "UZ",
            "VA", "VC", "VE", "VG", "VI",
            "VN", "VU", "WF", "WS", "YE",
            "YT", "ZA", "ZM", "ZW"
        };
        public static readonly List<string> enumColorDepthBits = new List<string>()
        {
            "1", "4", "8", "15", "16", "24", "32", "48"
        };
    }
}
