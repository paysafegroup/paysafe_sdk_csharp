using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paysafe.Common;

namespace Paysafe.ThreeDsecureV2
{

    class ThreeDSecureV2Constants : GlobalConstants
    {
        public static readonly List<string> enumStatus = new List<string>() {   
            statusCompleted,    //Authentication status is completed
            statusFailed,       //Authentication staus is failed 
            statusPending       //Authentication status is pending
        };
        public static readonly List<string> enumType = new List<string>() {
            AM ,                // American Express
            MC ,                //MasterCard
            VI ,                // Visa
        };
        public static readonly List<string> enumThreeDEnrollment = new List<string>() {
            threeDEnrolled,             //Cardholder authentication available 
            threeDNotEnrolled,          // Cardholder not enrolled in authentication
            threeDEnrollmentUnavailable //Cardholder authentication unavailable
        };
        public static readonly List<string> enumThreeDResult = new List<string>() {
            authenticated,              //Cardholder authentication available 
            authenticationAttempted,    //Cardholder authentication attempted
            authenticationFailed,       //Cardholder authentication Failed
            authenticationUnavailable,  //Cardholder authentication Unavailable
            authenticationChallenge,     //cardholder authentication challnege required
            authenticationRejected      //Cardholder authentication Rejected 
        };
        public static readonly List<string> enumTransactionIntent = new List<string>()
        {
            transactionGoodsOrServicePurchase,  //Transaction for goods or service purchase
            transactionCheckAcceptance,         //Transaction for check acceptance 
            transactionAccountfunding,          //Transaction for account funding
            transactionQuasiCashTransaction,    //Transaction for quasi cash transaction
            transactionPrepaidActivation        //transaction for prepaid activation
        };

        public static readonly List<string> enumAuthenticationPurpose = new List<string>()
        {
            authPurposePaymentTransaction,      //Auth purpose of Payment Transaction
            authPurposeRecurringTransaction,    //Auth purpose of recurring transaction    
            authPurposeInstalmentTransaction,   //Auth purpose of Instalment Transaction
            authPurposeAddCard,                 //Auth purpose of adding card
            authPurposeMaintainCard,            //Auth purpose of maintaining card
            authPurposeEMVTokenVerification     //Auth purpose of emv token verification
        };

        public static readonly List<string> enumDeviceChannel = new List<string>()
        {
            deviceChannelBrowser,           //Browser 
            deviceChannelSDK,               //SDK
            deviceChannel3RI                //3RI
        };

        public static readonly List<string> enumMessageCategory = new List<string>()
        {
            messageCategoryPayment,         //Payment
            messageCategoryNonPayment       // non_payment
        };

        public static readonly List<string> enumRequestorChallengePreference = new List<string>()
        {
            reqChallengeNoPref,             //Requestor challenge with no preference
            reqChallengeChallengeReq,       //Requestor challenge with challenge request  
            reqChallengeChallengeMandate    //Requestor challenge with challenge mandates 
        };

        public static readonly List<string> enumPreOrderPurchaseIndicator = new List<string>()
        {
            preOrderPurchaseMerchandiseAvailable, //merchandise availabality 
            preOrderPurchaseFutureAvailable       //future availablability
        };

        public static readonly List<string> enumReorderItemsIndicator = new List<string>()
        {
            reorderIndicatorFirstTimeOrder,     //first time order
            reorderIndicatorReorder             //reorder
        };

        public static readonly List<string> enumShippingIndicator = new List<string>()
        {
            shippingToBillingAddress,       //ship to billing address
            shippingToVerifiedAddress,      //ship to verified address
            shippingToDifferentaddress,     //ship to different address
            shippingToStore,                //ship to store
            shippingDigitalGoods,           //Digital goods
            shippingTravelAndEvent,         //travel and event tickets
            shippingOther                   //other
        };
        public static readonly List<string> enumShipMethod = new List<string>()
        {
            shipMethodNextDay,      //Next day
            shipMethodTwoDay,       //Two days
            shipMethodLowestCost,   //Lowest cose
            shipMethodOther,        //Other 
            shipMethodSameDay       //Same day 
        };
        public static readonly List<string> enumChangedRange = new List<string>()
        {
            duringTransaction,  //During transaction
            lessThanThirtyDays, //Less than thirty days
            thirtyToSixtyDays,  //thirty to sixty days 
            moreThanSixtyDays    //more than sixty days 
        };
        public static readonly List<string> enumCreatedRange = new List<string>()
        {
            noAccount, //no account
            duringTransaction,  //During transaction
            lessThanThirtyDays, //Less than thirty days
            thirtyToSixtyDays,  //thirty to sixty days 
            moreThanSixtyDays    //more than sixty days 

        };
        public static readonly List<string> enumPasswordChangedRange = new List<string>()
        {               
            noChange, // no change
            duringTransaction,  //During transaction
            lessThanThirtyDays, //Less than thirty days
            thirtyToSixtyDays,  //thirty to sixty days 
            moreThanSixtyDays    //more than sixty days 
        };

        public static readonly List<string> enumMethod = new List<string>()
       {
           frictionlessAuthentiocation, //frictionless authentication Method 
           acsChallenge,                //ACS challenge Method 
           avsVerified,                 //Avs verified Method 
           otherIssuerMethod            //Other issuer Method 
       };

        public static readonly List<string> enumInitialUsageRange = new List<string>()
        {
            currentTransaction,     //Current Transaction range 
            lessThanThirtyDays,     //less than thirty days  
            thirtyToSixtyDays,      //thirty to sixty days  
            moreThanSixtyDays       //more than sixty days 
        };

        public static readonly List<string> enumAuthenticationMethod = new List<string>()
        {
            noLogin,                    // No login Authentication Method 
            internalCredentials,        //Internal Credentials  Authentication Method 
            federatedId,                //federated ID Authentication Method 
            issuerCredentials,          //Issuer Credentials Authentication Method        
            thirdPartyAuthentication,   //Third Party Authentication Method 
            fidoAuthenticator           //Fido Authenticator method  

        };

        public static readonly List<string> enumSignatureStatus = new List<string>()
        {
            satisfiedSignatureStatus,   // Satsfied
            failedSignatureStatus       //failed

        };
    }
}
