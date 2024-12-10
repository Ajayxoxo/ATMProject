<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ATMProject.Default" %>
<!DOCTYPE html>
<html>
<head>
    <title>ATM Menu</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome to ATM</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
            <asp:Button ID="btnCheckBalance" runat="server" Text="Check Balance" OnClick="btnCheckBalance_Click" /><br />
            <asp:Button ID="btnDeposit" runat="server" Text="Deposit" OnClick="btnDeposit_Click" /><br />
            <asp:Button ID="btnWithdraw" runat="server" Text="Withdraw" OnClick="btnWithdraw_Click" /><br />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" /><br />
        </div>

        <asp:Panel ID="pnlTransaction" runat="server" Visible="false">
            <h3>Enter Amount</h3>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
        </asp:Panel>
    </form>
</body>
</html>
