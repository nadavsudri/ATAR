<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyA7X.aspx.cs" Inherits="MyA7X" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" Runat="Server">
    <form action="FindUS.aspx">
        <input id ="usernamebox"  type="text" placeholder="Username" onclick="garry" />
        <input id="passwordbox" type="password" placeholder="Password" />
        <button id="loginbut" onclick="loginclick" >Login</button>
        </form>
</asp:Content>

