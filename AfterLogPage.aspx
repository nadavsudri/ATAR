<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AfterLogPage.aspx.cs" Inherits="AfterLogPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="ImageDiv" onclick="document.getElementById('FileUpload').click();">
        <img src="http://www.propertybaazaar.com/images/noprofile.png" id="ProfilePic" />
        <input type="text" id="urlbox" />
        <button runat="server" id="uploadbutton" clientidmode="Static">Upload</button>
    </div>
    <header id="afheader" runat="server" clientidmode="Static">
        Hello User
        <br />
    </header>
    <button runat="server" onserverclick="logoutbtn_ServerClick" clientidmode="Static" id="logoutbtn">Log Out</button>
    <p id="tnxp"><strong>Thank you for using our website!</strong>  </p>
</asp:Content>

