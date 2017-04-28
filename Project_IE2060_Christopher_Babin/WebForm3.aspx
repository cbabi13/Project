<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="Project_IE2060_Christopher_Babin.WebForm3" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 668px; margin-top: 0px">
    <p style="text-align:right">
        <asp:Button ID="Button1" runat="server" Height="34px" Text="Cart" Width="74px" />
        
    </p>
        <asp:ListBox ID="ListBox1" runat="server" Height="500px" Width="500px" DataSourceID="SqlDataSource1"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [Gender], [Price], [JerseyName] FROM [Table3]"></asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="1218px">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Label ID="JerseyNameLabel" runat="server" Text='<%# Eval("JerseyName") %>' />
                <br />
                Gender:
                <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                <br />
                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                <br />
                <asp:Button ID="Button2" runat="server" Height="34px" Text="Add to Cart" Width="80px" />
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SelectedItemTemplate>
                <span style="color: rgb(17, 17, 17); font-family: &quot;Segoe UI&quot;, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&lt;asp:Button ID=&quot;getDetails&quot; runat =&quot;server&quot; Text =&quot;Add To Cart&quot; CommandName =&quot;SendEnquiry&quot; Font-Names =&quot;verdana&quot; Font-Size =&quot;8pt&quot; Height =&quot;20px&quot; Width =&quot;90px&quot; /&gt;</span>
            </SelectedItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
