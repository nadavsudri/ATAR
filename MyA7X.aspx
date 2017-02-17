<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyA7X.aspx.cs" Inherits="MyA7X" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="login">
        <form action="FindUS.aspx">
            <input id="usernamebox" type="text" placeholder="    Username"  tabindex="1" />
            <br />
            <input id="passwordbox" type="password" placeholder="    Password" tabindex="2" />
            <br />
            <button id="loginbut" onclick="regexcheck();" tabindex="3">Login</button>
            <a id="signupbut" href="Register_Page.aspx" tabindex="4">Sign Up</a>
        </form> 
         
    </div>
</asp:Content>

