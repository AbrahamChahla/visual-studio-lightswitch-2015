﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CreateIssue.aspx.vb" Inherits="HelpDeskPortalVB.CreateIssue" %>


<%--You can use and redistribute the code from this book (and sample application) for non-commercial and 
most commercial purposes as long as you acknowledge the source and authorship. 
You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
The acknowledgment should include author, title, publisher, and ISBN. 
An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".--%>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Raise a New HelpDesk Issue</h2>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Service Endpoint URL" /><br />
    <asp:TextBox ID="ServiceEndPointURL" runat="server" Text="http://localhost:1157/ApplicationData.svc/" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Issue Subject" /><br />
    <asp:TextBox ID="IssueSubject" runat="server" Width="400px" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Please enter your problem description" /><br />
    <asp:TextBox ID="IssueDescription" runat="server" TextMode="MultiLine" Width="400px" Height="160px" />
    <br />
    <asp:Button ID="Button1" Text="Add Issue" runat="server" OnClick="AddIssue_Click" />
    <br />
    <asp:Label ID="ConfirmLabel" runat="server" />
</asp:Content>
