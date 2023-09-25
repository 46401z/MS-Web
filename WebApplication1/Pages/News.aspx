<%@ Page Title="Новини" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="WebApplication1.News" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <table cellpadding="5">
            <% 
              foreach (var e in list)
              { 
            %>
            <tr>
                <td valign="top" hspace="5" vspace="5" ><img src="content/1.jpg" width="150" height="150"  /></td>
                <td valign="top">
                    <b><%= e.Title %></b>
                    <br><i style="font-size:10px"><%= e.DateTime %></i>
                    <br><%= e.Article %>
                    <br><br>
                </td>
            </tr>
            <% } %>
        </table>
    </main>
</asp:Content>
