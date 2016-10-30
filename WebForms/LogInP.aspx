<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageP.master" AutoEventWireup="true" CodeFile="LogInP.aspx.cs" Inherits="WebForms_LogInP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label>
        <table class="MarginClass2">
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Parola</td>
                <td>
                    <asp:TextBox ID="TextBoxParola" runat="server" TextMode="password"></asp:TextBox>
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
                    <asp:Button ID="ButtonLogIn" runat="server"  Text="Log In" OnClick="ButtonLogIn_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

