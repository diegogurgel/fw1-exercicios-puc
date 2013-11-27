<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="CadastroPF.aspx.cs" Inherits="Exercicios.CadastroPF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="title" runat="server" id="lblCad">Cadastro de Pessoa Física</h1>
    <div class="formContent">
        <label for="listaPersistencia">Salvar em</label>

        <div class="groupRadio">
           
        <asp:RadioButtonList ID="listaPersistencia" name="listaPersistencia" runat="server" Width="101px">
            <asp:ListItem Selected="True">Cookie</asp:ListItem>
            <asp:ListItem>Session</asp:ListItem>
            <asp:ListItem>Database</asp:ListItem>

        </asp:RadioButtonList>
           
        </div>
     <label for="tbxNome">Nome</label>

&nbsp;<asp:TextBox ID="tbxNome" name="txbNome" runat="server"></asp:TextBox>
    <label for="tbxCPFCNPJ" id="lblCPFCNPJ" runat="server">CPF</label>
    <asp:TextBox ID="tbxCPFCNPJ" name="tbxCPF" runat="server"></asp:TextBox>
        <label for="tbxRua">Rua</label>
    <asp:TextBox ID="tbxRua" name="tbxRua" runat="server"></asp:TextBox>
        <label for="tbxNumero">Número</label>
    <asp:TextBox ID="tbxNumero" name="tbxNumero" runat="server"></asp:TextBox>
        <label for="ddwTipo">Tipo</label>
        <asp:DropDownList ID="ddwTipo" CssClass="select" name="ddwTipo" runat="server" OnSelectedIndexChanged="ddwTipo_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>Residencial</asp:ListItem>
            <asp:ListItem>Cobrança</asp:ListItem>
            <asp:ListItem>Comercial</asp:ListItem>
        </asp:DropDownList>
    <label for="tbxRef" runat="server" id="lblRef" >Referencia</label>
    <asp:TextBox ID="tbxRef" name="tbxRef" runat="server"></asp:TextBox>
    <asp:Button Text="Salvar" CssClass="btn" runat="server" ID="btnSalvar" OnClick="Unnamed2_Click" />
    <asp:Button Text="Limpar" CssClass="btn" runat="server" ID="btnLimpar" OnClick="btnLimpar_Click" />
    
        </div>
</asp:Content>
