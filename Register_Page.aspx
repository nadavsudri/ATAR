<%@ Page Title="Register" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register_Page.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="register">
        <input id="userbox" type="text" placeholder="Username" />
        <br />
        <input id="passbox" type="password" placeholder="Password" />
        <br />
        <input id="passboxcon" type="password" placeholder="Confirm Password" />
        <br />
        <input id="subbut" type="submit" value="Register" />
    </div>
</asp:Content> 

