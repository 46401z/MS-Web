<%@ Page Title="Документи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Documents.aspx.cs" Inherits="WebApplication1.Documents" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowHeader="false" CellPadding="10" Width="100%">
            <Columns>
                <asp:HyperLinkField  DataTextField="Text" DataNavigateUrlFields="Value" />
            </Columns>
        </asp:GridView>
    </main>
</asp:Content>