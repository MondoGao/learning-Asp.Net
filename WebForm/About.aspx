<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource">
        <ItemTemplate>
            name:
            <asp:Label Text='<%# Eval("name") %>' runat="server" ID="nameLabel" /><br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource runat="server" ID="SqlDataSource" ConnectionString='<%$ ConnectionStrings:testConnectionString %>' SelectCommand="Select * from test"></asp:SqlDataSource>
</asp:Content>
