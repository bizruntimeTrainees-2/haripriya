<%@ Page Language="C#" %>

<!DOCTYPE html>
<script runat="server"><!--Inline-->
    protected void Button1_Click(object sender,EventArgs e)
    {
        Response.Write("Button is clicked by the user.");
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Click Me" ForeColor="Red"/>
        </div>
    </form>
</body>
</html>
<!--
    <%Response.Write("My Web page") %>
    -->