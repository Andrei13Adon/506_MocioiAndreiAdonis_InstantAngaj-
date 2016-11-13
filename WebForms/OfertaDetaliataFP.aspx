<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="OfertaDetaliataFP.aspx.cs" Inherits="WebForms_OfertaDetaliataFP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="MarginClass2">
            <tr>
                <td>ID Oferta</td>
                <td>
                    <asp:Label ID="LabelIdOferta" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Nume</td>
                <td>
                    <asp:Label ID="LabelNume" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Descriere</td>
                <td>
                    <asp:Label ID="LabelDescriere" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Valabila</td>
                <td>
                    <asp:Label ID="LabelValabila" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="ButtonVezCl" runat="server" Text="Vezi Clenti Interesati" OnClick="ButtonVezCl_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonVal" runat="server" Text="Valideaza" OnClick="ButtonVal_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonInVal" runat="server" Text="Invalideaza" OnClick="ButtonInVal_Click" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="ButtonBack" runat="server" Text="Inapoi" OnClick="ButtonBack_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonModifica" runat="server" Text="Modifica" OnClick="ButtonModifica_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

