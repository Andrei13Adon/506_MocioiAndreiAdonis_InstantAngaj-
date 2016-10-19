<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageP.master" AutoEventWireup="true" CodeFile="LogInP.aspx.cs" Inherits="WebForms_LogInP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="MarginClass2">
            <tr>
                <td>Nume</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Parola</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="password"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server"  Text="Log In" />
                </td>
            </tr>
        </table>
</asp:Content>

