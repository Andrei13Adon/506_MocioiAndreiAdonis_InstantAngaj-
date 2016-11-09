<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="AddOfertaP.aspx.cs" Inherits="WebForms_AddOfertaP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label> 
        <table class="MarginClass2">
            <tr>
                <td>Numele Ofertei</td>
                <td>
                    <asp:TextBox ID="TextBoxNume" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Descrierea Ofertei</td>
                <td>
                    <asp:TextBox ID="TextBoxDesc" runat="server" TextMode="MultiLine" Rows="10" Columns="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonAddCal" runat="server" Text="Adauga Calificari" OnClick="ButtonAddCal_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonDelCal" runat="server" Text="Sterge Calificari" OnClick="ButtonDelCal_Click" />
                </td>
            </tr>
            <tr>
                <td>Calificari Necesare</td>
                <td>
                    <asp:Label ID="LabelCal" runat="server" Text="Nici Una"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonConOferta" runat="server" Text="Confirma Oferta" OnClick="ButtonConOferta_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonNullOferta" runat="server" Text="Anuleaza Oferta" OnClick="ButtonNullOferta_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

