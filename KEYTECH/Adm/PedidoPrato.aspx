<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/AdmMasterPage.master" AutoEventWireup="true" CodeFile="PedidoPrato.aspx.cs" Inherits="Adm_PedidoPrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <table class="table table-hover">
        <tr class="bg-dark text-white">
            <td>Prato</td>
            <td>Rua</td>
            <td>Numero</td>
            <td>Bairro</td>
        </tr>
          <asp:Literal runat="server" ID="ltlPedido"></asp:Literal>
    </table>
</asp:Content>

