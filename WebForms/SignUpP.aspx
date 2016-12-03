<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageP.master" AutoEventWireup="true" CodeFile="SignUpP.aspx.cs" Inherits="WebForms_SignUpP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <table class="MarginClass2">
        <tr>
            <td>Mail</td>
            <td>
                <asp:TextBox ID="TextBoxMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Telefon</td>
            <td>
                <asp:TextBox ID="TextBoxTelefon" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nume</td>
            <td>
                <asp:TextBox ID="TextBoxNume" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Parola</td>
            <td>
                <asp:TextBox ID="TextBoxParola" runat="server" TextMode="password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxParola" ControlToValidate="TextBoxConParola" ErrorMessage="Parolele nu se potrivesc"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Confirmare Parola</td>
            <td>
                <asp:TextBox ID="TextBoxConParola" runat="server" TextMode="password"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>Firma</td>
            <td>
                <asp:CheckBox ID="CheckBoxFirma" runat="server" />
            </td>

        </tr>
        <tr>
            <td>
                <asp:Button ID="ButtonSingUp" runat="server" Text="Sign Up" OnClick="ButtonSingUp_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

