<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="direct-debit-standalonecredits-ACHAccount.aspx.cs" Inherits="SampleApp.direct_debit_standalonecredits_ACHAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchase With ACHAccount</title>
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
            <legend>Direct Debit StandAloneCredits</legend>
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
                    CustomerIp: 
						<input type="text" name="customer_ip" value="<%Response.Write("192.0.126.111"); %>" />
                </label>
            </div>
            </fieldset>

            <fieldset>
            <legend>ACH Account</legend>
            <div>
                <label>
                    Account Holder Name: 
						<input type="text" name="account_holder_name" value="<% Response.Write(Request.Form["acc_holder_name"]); %>" />
                </label>
            </div>
            <div>
                <label>
                    Account Number: 
						<input type="text" name="account_number" value="<% Response.Write("6455576858"); %>" />
                </label>
            </div>
            <div>
                <label>
                    Account Type: 
						<input type="text" name="account_type" value="<% Response.Write("CHECKING"); %>" />
                </label>
            </div>
            <div>
                <label>
                    Routing Number: 
						<input type="text" name="routing_number" value="<% Response.Write("211589828"); %>" />
                </label>
            </div>
            <div>
                <label>
                    Pay Method: 
						<input type="text" name="pay_method" value="<%Response.Write("WEB"); %>" />
                </label>
            </div>           
            </fieldset>
        <fieldset>
            <legend>Profile</legend>
             <div>
                <label>
                    First Name: 
						<input type="text" name="first_name" value="<% Response.Write(Request.Form["first_name"]); %>" />
                </label>
            </div>
            <div>
                <label>
                    Last Name: 
						<input type="text" name="last_name" value="<% Response.Write(Request.Form["last_name"]); %>" />
                </label>
            </div>
            <div>
                <label>
                    Email: 
						<input type="text" name="email" value="<%
                            if (Request.Form["email"] == null)
                            {
                                Response.Write("test@test.com");
                            }
                            else
                            {
                                Response.Write(Request.Form["email"]);
                            }
						%>" />
                </label>
            </div>
        </fieldset>
        <fieldset>
            <legend>Billing Details</legend>
            <div>
                <label>
                    Street: 
						<input type="text" name="street" value="<% Response.Write(Request.Form["100 Queen Street West"]); %>" />
                </label>
            </div>
            <div>
                <label>
                    City: 
						<input type="text" name="city" value="<% Response.Write(Request.Form["Los Angeles"]); %>" />
                </label>
            </div>
            <div>
                <label>
                    State/Province: 
						<input type="text" name="state" value="<%
                            if (Request.Form["state"] == null)
                            {
                                Response.Write("ON");
                            }
                            else
                            {
                                Response.Write(Request.Form["state"]);
                            }
						%>" />
                </label>
            </div>
            <div>
                <label>
                    Country: 
						<select name="country">
                            <option value="CA" <%
                                if (Request.Form["country"] == null
                                    || Request.Form["country"].Equals("CA"))
                                {
                                    Response.Write(" selected");
                                }
							%>>Canada</option>
                            <option value="US" <%
                                if (Request.Form["country"] != null
                                    && Request.Form["country"].Equals("US"))
                                {
                                    Response.Write(" selected");
                                }
							%>>USA</option>
                        </select>
                </label>
            </div>
            <div>
                <label>
                    Zip/Postal Code: 
						<input type="text" name="zip" value="<%
                            if (Request.Form["zip"] == null)
                            {
                                Response.Write("M5H 2N2");
                            }
                            else
                            {
                                Response.Write(Request.Form["zip"]);
                            }
						%>" />
                </label>
            </div> 
           <div>
                <label>
                    Phone: 
						<input type="text" name="phone" value="<%
                            if (Request.Form["phone"] == null)
                            {
                                Response.Write("3102649010");
                            }
                            else
                            {
                                Response.Write(Request.Form["phone"]);
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