﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelpDeskPortalCS._Default" %>

<%--You can use and redistribute the code from this book (and sample application) for non-commercial and 
most commercial purposes as long as you acknowledge the source and authorship. 
You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
The acknowledgment should include author, title, publisher, and ISBN. 
An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2015 by Tim Leung, published by Apress, ISBN 978-1-4842-0767-3".--%>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>This the home page for the HelpDesk portal web site.</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Chapter 15 - LightSwitch OData demonstration:</h3>
    <ol class="round">
        <li class="one">
            <h5>Creating a new record</h5>
            <a href="CreateIssue.aspx">Click here</a> to open the web page that adds a new record into your LightSwitch application.
        </li>
        <li class="two">
            <h5>Viewing records</h5>
            <a href="ViewIssues.aspx">Click here</a> to view the HelpDesk issues in a new web page.
        </li>
    </ol>
</asp:Content>
