<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="visualizar.aspx.cs" Inherits="Exercicios.visualizar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formContent">
    <div class="groupRadio">
        <h2>Cookie</h2>
        <label for="">Nome</label>
         <asp:Label CssClass="lbl" Text="" ID="lblNome" runat="server" />
        <label for="">CPF/CNPJ</label>
         <asp:Label CssClass="lbl"  Text="" ID="lblCPFCNPJ" runat="server" />
        <label for="">Rua</label>
         <asp:Label CssClass="lbl"  Text="" ID="lblRua" runat="server" />
        <label for="">Número</label>
         <asp:Label CssClass="lbl" Text="" ID="lblNumero" runat="server" />
        <label for="">Tipo</label>
         <asp:Label CssClass="lbl" Text="" ID="lblTipo" runat="server" />
        <asp:Button ID="btnEditarCookie" CssClass="btn btn-editar" runat="server" Text="Editar" OnClick="btnEditarCookie_Click" />
    </div>
    <div class="groupRadio">
        <h2>Session</h2>
        <label for="">Nome</label>
         <asp:Label CssClass="lbl" Text="" ID="lblNomeSession" runat="server" />
        <label for="">CPF/CNPJ</label>
         <asp:Label CssClass="lbl"  Text="" ID="lblCPFSession" runat="server" />
        <label for="">Rua</label>
         <asp:Label CssClass="lbl"  Text="" ID="lblRuaSession" runat="server" />
        <label for="">Número</label>
         <asp:Label CssClass="lbl" Text="" ID="lblNumeroSession" runat="server" />
        <label for="">Tipo</label>
         <asp:Label CssClass="lbl" Text="" ID="lblTipoSession" runat="server" />
        <asp:Button ID="btnEditarSession" CssClass="btn btn-editar" runat="server" Text="Editar" OnClick="btnEditarSession_Click1" />
        </div>
    <div class="groupRadio">
        <h2>Database</h2>
            <asp:GridView ID="GridView1" OnRowEditing="GridView1_RowEditing" OnPageIndexChanging="GridView1_PageIndexChanging"  AllowPaging="True" PageSize="4"   AlternatingRowStyle-BackColor="#8CBEB2" CssClass="grid" runat="server">
<AlternatingRowStyle BackColor="#8CBEB2"></AlternatingRowStyle>
            </asp:GridView>
            <asp:GridView ID="GridView2" OnRowEditing="GridView2_RowEditing" OnPageIndexChanging="GridView2_PageIndexChanging" AllowPaging="True" PageSize="4" CssClass="grid" AlternatingRowStyle-BackColor="#8CBEB2" runat="server">
<AlternatingRowStyle BackColor="#8CBEB2"></AlternatingRowStyle>
            </asp:GridView>
      
        
    </div>
        </div>
</asp:Content>
