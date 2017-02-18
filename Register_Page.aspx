<%@ Page Title="Register" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register_Page.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="register">
        <input id="userbox" type="text" placeholder="Username" runat="server"/>
        <br />
        <input id="passbox" type="password" placeholder="Password" runat="server" title="A password requires, at least one uppercase letter, a lowercase letter, and a digit" pattern="(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[0-9a-zA-Z!-+]{8,}" />
        <br />
        <input id="passboxcon" type="password" placeholder="Confirm Password" runat="server" />
        <br />
      <input id="subbut" type="submit" value="Register" runat="server" onserverclick="subbut_ServerClick" />
    </div>
</asp:Content> 

