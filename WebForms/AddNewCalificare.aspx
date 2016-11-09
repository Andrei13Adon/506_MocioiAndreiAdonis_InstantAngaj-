<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="AddNewCalificare.aspx.cs" Inherits="WebForms_AddNewCalificare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label> 
        <table class="MarginClass2">
            <h1 > Noua Calificarile </h1>
            <tr>
                <td>Nume</td>
                <td>
                    <asp:TextBox ID="TextBoxNume" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonCrNew" runat="server" Text="Creaza" OnClick="ButtonCrNew_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonRenunta" runat="server" Text="Renunta" OnClick="ButtonRenunta_Click" />
                </td>
            </tr>
        </table>
</asp:Content>

