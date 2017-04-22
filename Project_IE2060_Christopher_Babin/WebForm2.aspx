<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Project_IE2060_Christopher_Babin.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 91px;
            left: 10px;
        }
        .auto-style3 {
            position: absolute;
            top: 152px;
            left: 10px;
            z-index: 1;
            height: 28px;
            width: 73px;
        }
        .auto-style4 {
            position: absolute;
            top: 15px;
            left: 10px;
        }
        .auto-style5 {
            position: absolute;
            top: 67px;
            left: 10px;
            z-index: 1;
            height: 15px;
        }
        .auto-style6 {
            position: absolute;
            top: 111px;
            left: 183px;
            z-index: 1;
            width: 122px;
            height: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" style="z-index: 1" Text="Username"></asp:Label>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" style="z-index: 1"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" style="z-index: 1"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2" style="z-index: 1"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" Text="Sign Up" />
        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="auto-style6" Text="Employee" />
    </form>
</body>
</html>
