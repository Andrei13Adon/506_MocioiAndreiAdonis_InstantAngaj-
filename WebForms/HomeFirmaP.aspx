<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="HomeFirmaP.aspx.cs" Inherits="WebForms_HomeFirmaP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label> 
        <table class="MarginClass2">
            <tr>
                <td>Mail</td>
                <td>
                    <asp:Label ID="LabelMail" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Nume</td>
                <td>
                    <asp:Label ID="LabelNume" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Telefon</td>
                <td>
                    <asp:TextBox ID="TextBoxTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nume Firma</td>
                <td>
                    <asp:TextBox ID="TextBoxNumeFirma" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Adresa</td>
                <td>
                    <asp:TextBox ID="TextBoxAdresa" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Descriere</td>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxObiectiv" TextMode="MultiLine" Rows="10" Columns="50" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonModify" runat="server" Text="Modify" OnClick="ButtonModify_Click" />
                </td>
            </tr>

        </table>
    

</asp:Content>

