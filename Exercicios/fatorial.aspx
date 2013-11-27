<%@ Page Title="Fatorial" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="fatorial.aspx.cs" Inherits="Exercicios.fatorial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formContent">
    <div>
    
        Num:
        <asp:TextBox ID="txtFat" runat="server" Width="37px"></asp:TextBox>
        <asp:Button ID="btnFatorial" CssClass="btn btnFatorial" runat="server" OnClick="btnFatorial_Click" Text="Ok" />
    
    </div>
        <p>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </p>
        </div>

</asp:Content>
