<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="SeeAllClients.aspx.cs" Inherits="WebForms_SeeAllClients" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="MarginClass">
         <h1 > Toti Clientii Inscrisi la Oferta: </h1>

        <!-- <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> -->

     <asp:Table ID="Clasament" runat="server">
         <asp:TableHeaderRow BackColor=Aqua>
             <asp:TableHeaderCell>Numar</asp:TableHeaderCell>   
             <asp:TableHeaderCell>Client Nume</asp:TableHeaderCell>
             <asp:TableHeaderCell>Client Telefon</asp:TableHeaderCell>        
             <asp:TableHeaderCell>Id Client</asp:TableHeaderCell>                                                    
         </asp:TableHeaderRow>
      </asp:Table>
        <asp:Button ID="ButtonInapoi" runat="server" Text="Inapoi" OnClick="ButtonInapoi_Click"  />
    </div>
</asp:Content>

