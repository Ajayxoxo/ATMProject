<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ATMProject.LoginPage" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>ATM Login</h2>

            <asp:Label ID="lblPin" runat="server" Text="Enter PIN:" />
            <asp:TextBox ID="txtPin" runat="server" TextMode="Password" />

            
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
