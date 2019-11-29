<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerControl1.5.aspx.cs" Inherits="WebApplication4.ServerControl1__5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>Login Form</caption>
                <tr>
                    <td>Enter User Name:</td>
                    <td><asp:TextBox ID="txtName" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Password:</td>
                    <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="100px"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td align="right"><asp:Button ID="btnLogin" runat="server" Text="Login" PostBackUrl="~/Validate.aspx" /> </td>
                    <td><asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
                </tr>
            </table>         
        </div>
    </form>
</body>
</html>
