<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageClientP.master" AutoEventWireup="true" CodeFile="HomeClientP.aspx.cs" Inherits="WebForms_HomeClientP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <!-- <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label> -->
        <table class="MarginClass2">
            <tr>
                <td>Mail</td>
                <td>
                    <asp:Label ID="Label50" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Nume</td>
                <td>
                    <asp:Label ID="Label2" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Telefon</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Obiectiv</td>
                <td>
                    <asp:TextBox runat="server" ID="MyBox" TextMode="MultiLine" Rows="10" Columns="60" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>

        </table>
    

</asp:Content>

