<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginSignup.aspx.cs" Inherits="TheCraftyCraft.LoginSignup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login / Sign Up</h2>
    
    <div>
        <div>
            <label for="username">Username:</label>
            <input type="text" id="username" runat="server" />
        </div>
        <div>
            <label for="password">Password:</label>
            <input type="password" id="password" runat="server" />
        </div>
        <div>
            <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
            <asp:Button ID="signupButton" runat="server" Text="Sign Up" OnClick="SignupButton_Click" />
        </div>
    </div>
</asp:Content>
