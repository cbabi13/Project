<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Project_IE2060_Christopher_Babin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 93px;
            left: 173px;
            z-index: 1;
            height: 20px;
            width: 38px;
        }
    </style>
</head>
<body>
    <a href="WebForms/WebForms/">WebForms/</a><form id="form1" runat="server">

  
    &nbsp;</div><p>
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        </p>
            <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="119px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 31px" Width="127px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Height="20px" style="margin-left: 139px; margin-top: 0px" Text="Login" />
        </p>
        <asp:Button ID="Button3" runat="server" style="margin-left: 37px" Text="Register" Width="89px" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style1" Text="Password"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
