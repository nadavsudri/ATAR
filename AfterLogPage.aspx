<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AfterLogPage.aspx.cs" Inherits="AfterLogPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" Runat="Server">
    <header id="afheader" runat="server" ClientIDMode="Static" >Hello User <br /></header>
    <button runat="server" onserverclick="logoutbtn_ServerClick" ClientIDMode="Static" id="logoutbtn">Log Out</button>
    <p id="tnxp"> <strong>Thank you for using our website!</strong>  </p>
</asp:Content>

