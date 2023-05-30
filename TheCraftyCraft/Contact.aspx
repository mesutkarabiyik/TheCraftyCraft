<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TheCraftyCraft.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your shopping cart is empty.</h3>
       

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@crafty.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@crafty.com</a>
        </address>
    </main>
</asp:Content>
