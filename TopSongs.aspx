<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TopSongs.aspx.cs" Inherits="TopsSongs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" Runat="Server">
    <div id="songlist" style="">
    <ul style="list-style: none;">
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s10">#10 : "Buried Alive" (Nightmare/2010)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s9">#9 : "Hail to the King" (Hail to the King/2013)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s8">#8 : "Critical Acclaim" (Avenged Sevenfold/2007)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s7">#7 : "Beast and the Harlot" (City of Evil/2005)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s6">#6 : "A Little Piece of Heaven" (Avenged Sevenfold/2007)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s5">#5 : "Seize the Day" (City of Evil/2005)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s4">#4 : "Bat Country" (City of Evil/2005)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s3">#3 : "Almost Easy" (Avenged Sevenfold/2007)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s2">#2 : "Nightmare" (Nightmare/2010)</button></li>
    <li><button runat="server" onServerClick="songclick" class="songbtn" id="s1">#1 : "Afterlife" (Avenged Sevenfold/2007)</button></li>

    </ul>
    <iframe class="FindVideo2" id="FindVideo2" runat="server" src="" width="0" height="0"></iframe><button runat="server" onServerClick="nullify" class="songbtn" style="font-size:15px;">Click th song to play it, click here to stop it</button> 
    </div>
</asp:Content>

