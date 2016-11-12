<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageClientP.master" AutoEventWireup="true" CodeFile="DetaliOfertaDisP.aspx.cs" Inherits="WebForms_DetaliOfertaDisP" %>

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
                <td>Firma</td>
                <td>
                    <asp:Label ID="LabelFirma" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td> </td>
                <td>
                    <asp:Label ID="LabelAccept" runat="server" ForeColor="Green"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="ButtonBack" runat="server" Text="Inapoi" OnClick="ButtonBack_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonAppOf" runat="server" Text="Aplica Oferta" OnClick="ButtonAppOf_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

