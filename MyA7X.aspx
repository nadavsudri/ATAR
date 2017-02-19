<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyA7X.aspx.cs" Inherits="MyA7X" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="login">
            <input id="usernamebox" type="text" placeholder="    Username" runat="server" tabindex="1" ClientIDMode="Static" />
            <br />
            <input id="passwordbox" type="password" runat="server" placeholder="    Password" tabindex="2" ClientIDMode="Static" />
            <br />
            <button id="loginbut" onserverclick="loginbut_ServerClick" runat="server" tabindex="3" ClientIDMode="Static" >Login</button>
            <button id="signupbut" href="Register_Page.aspx" runat="server" tabindex="4" ClientIDMode="Static" >Sign Up</button>         
    </div>
</asp:Content>

