<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyA7X.aspx.cs" Inherits="MyA7X" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="login">
        <form action="FindUS.aspx">
            <input id="usernamebox" type="text" placeholder="    Username" onclick="garry" tabindex="0" />
            <br />
            <input id="passwordbox" type="password" placeholder="    Password" tabindex="1" />
            <br />
            <button id="loginbut" onclick="loginclick" tabindex="2">Login</button>
            <a id="signupbut" href="Register_Page.aspx" tabindex="3">Sign Up</a>
        </form>
         
    </div>
</asp:Content>

