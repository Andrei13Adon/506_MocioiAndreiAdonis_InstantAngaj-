<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="SeeDetaliuClientP.aspx.cs" Inherits="WebForms_SeeDetaliuClientP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <asp:Label ID="Label1" runat="server" ForeColor="Red" ></asp:Label> 
        <table class="MarginClass2">
            <tr>
                <td>ID</td>
                <td>
                    <asp:Label ID="LabelId" runat="server" ></asp:Label>
                </td>
            </tr>
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
                    <asp:Label ID="LabelTelefon" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Obiectiv</td>
                <td>
                    <asp:Label ID="LabelObiectiv" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonInapoi" runat="server" Text="Inapoi" OnClick="ButtonInapoi_Click"/>
                </td>
            </tr>

        </table>
    

</asp:Content>

