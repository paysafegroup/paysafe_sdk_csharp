<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThreeDSecure.aspx.cs" Inherits="SampleApp.ThreeDSecure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Three D Secure EnrollmentChecks Request</title>
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
        
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </form>
    <% } %>
</body>
</html>
