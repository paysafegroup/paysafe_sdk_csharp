<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="direct-debit-purchase-SEPAAccount.aspx.cs" Inherits="SampleApp.direct_debit_purchase_SEPAAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchase With SEPAAccount</title>
</head>
 <% if (payment_id != null)
       { %>
    <h1>Payment Successful! ID: <% Response.Write(payment_id); %></h1>
    <% }
       else
       { %>
    <form runat="server">
        <fieldset>
            <legend>Direct Debit Purchase</legend>
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
            <legend>SEPA Account</legend>
            <div>
                <label>
                    Account Holder Name: 
						<input type="text" name="account_holder_name" value="<% Response.Write(Request.Form["acc_holder_name"]); %>" >
                </label>
            </div>          
            <div>
                <label>
                    IBAN: 
						<input type="text" name="iban" value="<% Response.Write(Request.Form["iban"]); %>" />
                </label>
            </div>
             <div>
                <label>
                    Mandate Reference: 
						<input type="text" name="mandate_Reference" value="<% Response.Write(Request.Form["mandate_reference"]); %>" />
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
						<input type="text" name="street" value="<% Response.Write("Hoofdstraat 101"); %>" />
                </label>
            </div>
            <div>
                <label>
                    City: 
						<input type="text" name="city" value="<% Response.Write("Heeswijk-Dinther"); %>" />
                </label>
            </div>           
            <div>
                <label>
                    Country: 
						<input type="text" name="country" value="<% Response.Write("NL"); %>" />
                </label>
            </div>
            <div>
                <label>
                    Zip/Postal Code: 
						<input type="text" name="zip" value="<%
                            if (Request.Form["zip"] == null)
                            {
                                Response.Write("5233 HG");
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
                                Response.Write("06-12304567");
                            }
                            else
                            {
                                Response.Write(Request.Form["phone"]);
                            }
						%>" id="txt_phone" />
                </label>
            </div>
        </fieldset>
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </form>
    <% } %></body>
</html>
