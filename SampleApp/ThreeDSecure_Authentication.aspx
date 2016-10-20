<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThreeDSecure_Authentication.aspx.cs" Inherits="SampleApp.ThreeDSecure_Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Three D Secure Authentications Request</title>
</head>
<body>
    <% if (response != null)
       { %>
            <h1>Payment Successful:</h1><br/> <% Response.Write(response); %>
    <% }
       else
       { %>
    <form runat="server">
        <fieldset>
            <legend>EnrollmentChecks Request</legend>
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
						<input type="text" name="amount" value="<% Response.Write("10098"); %>" />
                </label>
            </div>
            <div>
                <label>
                    Currency: 
						<input type="text" name="currency" value="<%Response.Write("USD"); %>" />
                </label>
            </div>

             <div>
                <label>
                    CustomerIp: 
						<input type="text" name="customerIp" value="<%Response.Write("204.91.0.12"); %>" />
                </label>
            </div>

            <div>
                <label>
                    userAgent: 
						<input type="text" name="userAgent" value="<%Response.Write("Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.125 Safari/537.36"); %>" />
                </label>
            </div>

            <div>
                <label>
                    acceptHeader: 
						<input type="text" name="acceptHeader" value="<%Response.Write("text/html,application/xhtml+xml,application/xml;q\u003d0.9,image/webp,*/*;q\u003d0.8"); %>" />
                </label>
            </div>

            <div>
                <label>
                    merchantUrl: 
						<input type="text" name="merchantUrl" value="<%Response.Write("https://www.google.com"); %>" />
                </label>
            </div>


            </fieldset>

            <fieldset>
            <legend>Card</legend>
            <div>
                <label>
                    cardNum: 
						<input type="text" name="cardNum" value="<% Response.Write(Request.Form["cardNum"]); %>" />
                </label>
            </div>
            <div>
                <label>
                    month: 
						<input type="text" name="month" value="<% Response.Write("10"); %>" />
                </label>
            </div>
            <div>
                <label>
                    year: 
						<input type="text" name="year" value="<% Response.Write("2018"); %>" />
                </label>
            </div>
                      
            </fieldset>

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
                    paResp: 
						<input type="text" name="paResp" value="<% Response.Write("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"); %>" />
                </label>
            </div>
            <div>
                <label>
                    enrollmentId: 
						<input type="text" name="enrollmentId" value="<% Response.Write("1346db4c-817e-47bb-9752-3a59f3e350f2"); %>"/>
                </label>
            </div>

             
            </fieldset>
        
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </form>
    <% } %>
</body>
</html>