<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageClientP.master" AutoEventWireup="true" CodeFile="DellQualificationP.aspx.cs" Inherits="WebForms_DellQualificationP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <div class="MarginClass">
         <h1  >Calificarile Mele de Sters:</h1>

     <asp:Table ID="Clasament" runat="server">
         <asp:TableHeaderRow BackColor=Aqua>
             <asp:TableHeaderCell>Numar</asp:TableHeaderCell>   
             <asp:TableHeaderCell>Calificare</asp:TableHeaderCell>    
             <asp:TableHeaderCell>Id Calificare</asp:TableHeaderCell>                                                    
         </asp:TableHeaderRow>
      </asp:Table>
    </div>
</asp:Content>

