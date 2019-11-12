<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThreeDSecureV2_Authentication.aspx.cs" Inherits="SampleApp.ThreeDSecureV2_Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Three D Secure V2 Authentications Request</title>
</head>
<body>
    <% if (payment_id != null)
       { %>
            <h1>Payment Successful: <% Response.Write(payment_id);%> </h1><br/>
    <% }
       else
       { %>
    <form runat="server">
   <fieldset>
            <legend>Authentications Request</legend>
            <div>
                <label>
                    Merchant Customer Id: 
						<input type="text" name="merchant_customer_id" value="<%
                            if (Request.Form["merchant_customer_id"] == null)
                            {
                                Response.Write(System.Guid.NewGuid().ToString());
                            }
                            else
                            {
                                Response.Write(Request.Form["merchant_customer_id"]);
                            }
						%>" />
                </label>
            </div> 
       <div>
                <label>
                    Amount: 
						<input type="text" name="amount" value="<%
                            if (Request.Form["amount"] == null)
                            {
                                Response.Write("9999999");
                            }
                            else
                            {
                                Response.Write(Request.Form["amount"]);
                            }
						%>" />
                </label>
            </div>
         <div>
                <label>
                    Currency: 
						<input type="text" name="currency" value="<%
                            if (Request.Form["currency"] == null)
                            {
                                Response.Write("USD");
                            }
                            else
                            {
                                Response.Write(Request.Form["currency"]);
                            }
						%>" />
                </label>
            </div>
       
         <div>
                <label>
                    DeviceFingerprintingId: 
						<input type="text" name="deviceFingerprintingId" value="<%
                            if (Request.Form["deviceFingerprintingId"] == null)
                            {
                                Response.Write("3bf74a2a-8668-4f14-b2bf-fd8e07ae2100");
                            }
                            else
                            {
                                Response.Write(Request.Form["deviceFingerprintingId"]);
                            }
						%>" />
                </label>
            </div>
       
       <div>
                <label>
                    Card Number: 
						<input type="text" autocomplete="off" name="card_number" value="<%
                            if (Request.Form["card_number"] == null)
                            {
                                Response.Write("4444333322221111");
                            }
                            else
                            {
                                Response.Write(Request.Form["card_number"]);
                            }
						%>" />
                </label>
            </div>    

            <div>
                <label>
                   Holder Name: 
						<input type="text" autocomplete="off" name="holderName" value="<%
                            if (Request.Form["holderName"] == null)
                            {
                                Response.Write("john");
                            }
                            else
                            {
                                Response.Write(Request.Form["holderName"]);
                            }
						%>" />
                </label>
            </div>    
          <div>
                <label>
                    Card Expiry: 
                    <asp:DropDownList ID="card_expiry_month" runat="server" />
                </label>
            </div>
            <div>
                <label>
                    Card Expiry: 
                    <asp:DropDownList ID="card_expiry_year" runat="server" />
                </label>
            </div>
        <div>
                <label>
                 Merchant Url :
						<input type="text" autocomplete="off" name="merchantUrl" value="<%
                            if (Request.Form["merchantUrl"] == null)
                            {
                                Response.Write(@"https://mysite.com");
                            }
                            else
                            {
                                Response.Write(Request.Form["merchantUrl"]);
                            }
						%>" />
                </label>
            </div>    

         <div>
                <label>
                 Authentication Purpose :
						<input type="text" autocomplete="off" name="authenticationPurpose" value="<%
                            if (Request.Form["authenticationPurpose"] == null)
                            {
                                Response.Write("PAYMENT_TRANSACTION");
                            }
                            else
                            {
                                Response.Write(Request.Form["authenticationPurpose"]);
                            }
						%>" />
                </label>
            </div>    

         <div>
                <label>
                Device Channel :
						<input type="text" autocomplete="off" name="deviceChannel" value="<%
                            if (Request.Form["deviceChannel"] == null)
                            {
                                Response.Write("BROWSER");
                            }
                            else
                            {
                                Response.Write(Request.Form["deviceChannel"]);
                            }
						%>" />
                </label>
            </div>    

        <div>
                <label>
               Message Category :
						<input type="text" autocomplete="off" name="messageCategory" value="<%
                            if (Request.Form["messageCategory"] == null)
                            {
                                Response.Write("PAYMENT");
                            }
                            else
                            {
                                Response.Write(Request.Form["messageCategory"]);
                            }
						%>" />
                </label>
            </div>    
       
             
            </fieldset>
        
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </form>
    <% } %>
</body>
</html>