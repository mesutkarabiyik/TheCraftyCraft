<%@ Page Title="ProductList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="TheCraftyCraft.ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<asp:ListView ID="ListView1" runat="server">            <ItemTemplate>                <div class="col-md-4">                    <div class="product-card">                        <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' style="width:500px;height:500px;" />                        <h3><%# Eval("Name") %></h3>                        <p>Price: $<%# Eval("Price") %></p>                        <p>Description: <%# Eval("StockAmount") %></p>                    </div>                </div>            </ItemTemplate> </asp:ListView>

</asp:Content>
