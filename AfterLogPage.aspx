<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AfterLogPage.aspx.cs" Inherits="AfterLogPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">
    <div id="ImageDiv" onmouseout="hidetext();" onmouseover="showtext();" onclick="document.getElementById('FileUpload').click();">
        <h2 id="imagehovertext">Hover To Edit</h2>
        <img runat="server" clientidmode="Static" src="http://www.propertybaazaar.com/images/noprofile.png" id="ProfilePic" />
        <div id="uploaddiv" clientidmode="Static" runat="server" >
            <input runat="server" clientidmode="Static" type="text" id="urlbox" />
            <br />
            <button runat="server" id="cancelbutton" ClientIDMode="Static" onserverclick="cancelbutton_ServerClick">Cancel</button>
            <button runat="server" id="uploadbutton" ClientIDMode="Static" onserverclick="uploadbutton_ServerClick">Upload</button>
        </div>
    </div>
    <header id="afheader" runat="server" clientidmode="Static">
        Hello User
        <br />
    </header>
    <button runat="server" onserverclick="logoutbtn_ServerClick" clientidmode="Static" id="logoutbtn">Log Out</button>
    <p id="tnxp"><strong>Thank you for using our website!</strong>  </p>
</asp:Content>

