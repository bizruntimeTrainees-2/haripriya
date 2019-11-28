<script runat="server">

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Response.Write(Label1.Text + "</br>")
        Response.Write(ListBox1.SelectedItem.Text + "</br>")
        Label1.Visible = False
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 516px">
    <form id="form1" runat="server">
        <div id="ID">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="114px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </div>
            <asp:ListBox ID="ListBox1" runat="server" Height="76px" Width="192px">
            <asp:ListItem>BIZ RUNTIME</asp:ListItem>
            <asp:ListItem>Company</asp:ListItem>
            <asp:ListItem>Employee</asp:ListItem>
            </asp:ListBox>
            <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged">Submit</asp:TextBox>
            </p>
    </form>
            <%Response.Write("Response object in ASP.Net is used to send information back to the user ") %></br>
            <%Response.Write("Method Write Response obj to Write the text") %></br>
            <%Response.Write(" % and % markers are used to add asp.net specific code") %></br>
            <%Response.Write("------------------------") %></br>
            <%Response.Write("The label control is used to display a text or a message to the user on the form") %></br>

        
</body>
</html>