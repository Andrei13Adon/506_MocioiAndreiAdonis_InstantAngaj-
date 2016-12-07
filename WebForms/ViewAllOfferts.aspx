<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="ViewAllOfferts.aspx.cs" Inherits="WebForms_ViewAllOfferts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="MarginClass">
         <h1 > Toate Ofertele Create: </h1>

        <!-- <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> -->

     <asp:Table ID="Clasament" runat="server">
         <asp:TableHeaderRow BackColor=Aqua>
             <asp:TableHeaderCell>Numar</asp:TableHeaderCell>   
             <asp:TableHeaderCell>Oferta </asp:TableHeaderCell> 
             <asp:TableHeaderCell>Valabila </asp:TableHeaderCell>     
             <asp:TableHeaderCell>Id Oferta</asp:TableHeaderCell>                                                    
         </asp:TableHeaderRow>
      </asp:Table>
    </div>
</asp:Content>

