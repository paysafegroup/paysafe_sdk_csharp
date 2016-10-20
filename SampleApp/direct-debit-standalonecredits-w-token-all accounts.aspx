<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="direct-debit-standalonecredits-w-token-all accounts.aspx.cs" Inherits="SampleApp.direct_debit_standalonecredits_w_token_all_accounts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchase with Payment Token All Accounts</title>
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
            <legend>Direct Debit StandaloneCredits With Token</legend>                            
                <h3>Select Account</h3>
            <div>
            <asp:RadioButtonList ID="radio" runat="server" 
                RepeatDirection="Horizontal" RepeatLayout="Table">
                <asp:ListItem Text="ACH" Value="ACH"></asp:ListItem>
                <asp:ListItem Text="BACS" Value="BACS"></asp:ListItem>
                <asp:ListItem Text="EFT" Value="EFT"></asp:ListItem>                               
            </asp:RadioButtonList>            
            </div>
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
                    Payment Token: 
						<input type="text" name="payment_token" value="<%Response.Write(Request.Form["payment_token"]); %>" />
                </label>
            </div>            
            </fieldset>
           <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </form>
    <% } %>
</body>
</html>
