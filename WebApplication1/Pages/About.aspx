<%@ Page Title="Начална страница" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section id="sp-main-body">
        <div class="container">
            <div itemprop="articleBody">
                <div class="row" id="korupcia">
                    <div class="col-md-6 korup">
                        <p>За подаване на сигнали за корупция и/или конфликт на интереси можете за използвате един от следните начини:</p>
                        <p>Сигналите, които са анонимни, и тези, които се отнасят до нарушения, извършени преди повече от 2 (две) години се считат за недопустими и не подлежат на разглеждане. За анонимни се считат сигналите, в които не са посочени три имена и адрес за кореспонденция, включително и електронен адрес, и от съдържанието на сигнала не могат да бъдат установени.</p>
                    </div>
                    <div class="col-md-6">
                        <form method="post" id="form">
                            <div class="field_form">
                                <asp:Label ID="Label1" runat="server" Text="* Вашето Име"></asp:Label>
                                <br />
                                <asp:TextBox ID="name" runat="server" ></asp:TextBox>
                            </div>
                            <div class="field_form">
                                <asp:Label ID="Label2" runat="server" Text="* Вашия емейл"></asp:Label>
                                <br />
                                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                            </div>
                            <div class="field_form">
                               <asp:Label ID="Label3" runat="server" Text="* Местожителство"></asp:Label>
                                <br />
                               <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                            </div>
                            <div class="field_form">
                               <asp:Label ID="Label4" runat="server" Text="* Текст"></asp:Label>
                                <br />
                               <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Columns="50" Rows="10"></asp:TextBox>
                            </div>
                            <div class="error">
                            </div>
                            <br /><br />
                            <asp:Button ID="Button1" runat="server" Text="Изпрати" />
                        </form>
                    </div>
                </div>
            </div>
            <div class="article-footer-wrap">
                <div class="article-footer-top">
                </div>
            </div>
        </div>
    </section>
</asp:Content>
