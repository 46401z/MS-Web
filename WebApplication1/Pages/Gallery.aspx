<%@ Page Title="Галерия" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gallery.aspx.cs" Inherits="WebApplication1.Gallery" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <asp:GridView ID="GridView1" BorderWidth="0" runat="server" AutoGenerateColumns="false" ShowHeader="false" CellPadding="10" Width="100%">
            <Columns >
                <asp:ImageField DataImageUrlField="Value" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300" ItemStyle-Height="300"/>
            </Columns>
        </asp:GridView>
    </main>
</asp:Content>