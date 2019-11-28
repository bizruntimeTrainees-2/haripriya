<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"/>
            <asp:Button ID="Button1" runat="server" Text="Click me"/>
            <br/>
            <input type="text" name="TextBox2"/>
            <input type="submit" id="Submit1" value="Click me"/>
            
        </div>
    </form>
</body>
</html>

/*
protected void Button1 Click(object sender,EventArgs e)
{
    string str=TextBox1.Text; 
    //Text-value of text box
    Response.Write(str);
    //html content we can't use directly in asp.net
    str2=Request.Form["TextBox2"];//value
    Response.Write(str2);
}