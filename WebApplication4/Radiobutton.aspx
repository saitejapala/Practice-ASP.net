<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radiobutton.aspx.cs" Inherits="WebApplication4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin='100px'">
            <asp:Label Text="Username" runat="server" ID="Label1" />
            <asp:TextBox ID="TextBox1" runat="server" /><br />
            <asp:Label Text="Gender" runat="server" id="Label2"/>

            <asp:RadioButton ID="RadioButton1" runat="server" text="Male" GroupName="rbgender"/>
            <asp:RadioButton ID="RadioButton2" runat="server" text="Female" GroupName="rbgender"/>

            <br />
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
            <asp:Button Text="Submit" runat="server" OnClick="Unnamed1_Click" /><br />
            <asp:Label Text="Output" runat="server" id="Label3"/>
        </div>
    </form>
</body>
</html>
