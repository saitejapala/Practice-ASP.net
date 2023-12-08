<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cources"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Dotnet" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Java" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Python" />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Php" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Output"></asp:Label>
        </div>
    </form>
</body>
</html>
