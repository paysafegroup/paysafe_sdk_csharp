<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customervault-w-EFTAccount.aspx.cs" Inherits="SampleApp.customervault_w_EFTAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server">
    <title>Paysafe SDK - CardPayment With Customer Vault</title>
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
            <legend>EFT Bank Account Details</legend>
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
                    Transit Number: 
						<input type="text" name="transit_number" value="<%Response.Write("11224"); %>" />
                </label>
            </div>
             <div>
                <label>
                    Institution ID: 
						<input type="text" name="institution_id" value="<%Response.Write("123"); %>" />
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
                    Merchant Ref Num: 
						<input type="text" name="merchant_ref_num" value="<%
                            if (Request.Form["merchant_ref_num"] == null)
                            {
                                Response.Write(System.Guid.NewGuid().ToString());
                            }
                            else
                            {
                                Response.Write(Request.Form["merchant_ref_num"]);
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

