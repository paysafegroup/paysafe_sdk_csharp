<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customervault-w-BACSAccount.aspx.cs" Inherits="SampleApp.customervault_w_BACSAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server">
    <title>Customer Vault with Accounts</title>
</head>
<body>
    <% if (response != null)
       { %>
            <h1>Payment Successful ID:</h1><br/> <% Response.Write(response); %>
    <% }
       else
       { %>
    <form runat="server">
        <fieldset>
            <legend>BACS Bank Account Details</legend>
             <div>
                <label>
                    Nick Name: 
						<input type="text" name="nick_name" value="<%Response.Write(Request.Form["nick_name"]); %>" />
                </label>
            </div> 
            <div>
                <label>
                    Account Number: 
						<input type="text" name="account_number" value="<%Response.Write(Request.Form["account_number"]); %>" />
                </label>
            </div>            
            <div>
                <label>
                     Account Holder Name: 
						<input type="text" name="account_holder_name" value="<% Response.Write(Request.Form["account_holder_name"]); %>" />
                </label>
            </div>  
            <div>
                <label>
                       Sort Code: 
						<input type="text" name="sort_code" value="<% Response.Write(Request.Form["sort_code"]); %>" />
                </label>
            </div>                      
           </fieldset>
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
    </form>
    <% } %>
</body>
</html>
