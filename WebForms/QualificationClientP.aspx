<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageClientP.master" AutoEventWireup="true" CodeFile="QualificationClientP.aspx.cs" Inherits="WebForms_QualificationClientP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="MarginClass">
         <h1  >Calificarile Mele:</h1>

     <asp:Table ID="Clasament" runat="server">
         <asp:TableHeaderRow BackColor=Aqua>
             <asp:TableHeaderCell>Numar</asp:TableHeaderCell>   
             <asp:TableHeaderCell>Calificare</asp:TableHeaderCell>    
             <asp:TableHeaderCell>Id Calificare</asp:TableHeaderCell>                                                    
         </asp:TableHeaderRow>
      </asp:Table>
        
        <asp:Button ID="ButtonAdd" runat="server" Text="Adauga Calificare" OnClick="ButtonAdd_Click" />
        <asp:Button ID="ButtonDell" runat="server" Text="Stergere Calificare" OnClick="ButtonDell_Click" />
      
    </div>
   
</asp:Content>

