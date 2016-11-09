<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageFirmatP.master" AutoEventWireup="true" CodeFile="AddCalificariOfertaP.aspx.cs" Inherits="WebForms_AddCalificariOfertaP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="MarginClass">
         <h1 > Toate Calificarile Disponibile: </h1>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> 

     <asp:Table ID="Clasament" runat="server">
         <asp:TableHeaderRow BackColor=Aqua>
             <asp:TableHeaderCell>Numar</asp:TableHeaderCell>   
             <asp:TableHeaderCell>Calificare</asp:TableHeaderCell>    
             <asp:TableHeaderCell>Id Calificare</asp:TableHeaderCell>                                                    
         </asp:TableHeaderRow>
      </asp:Table>
        <asp:Button ID="ButtonCalN" runat="server" Text="Calificare Noua" OnClick="ButtonCalN_Click" />
        <asp:Button ID="ButtonRenunta" runat="server" Text="Renunta" OnClick="ButtonRenunta_Click" />
    </div>
</asp:Content>

