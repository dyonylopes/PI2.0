<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/AdmMasterPage.master" AutoEventWireup="true" CodeFile="PedidoPrato.aspx.cs" Inherits="Adm_PedidoPrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div align="center"> <h3 >CONSULTAR PEDIDOS</h3></div>
   <section>
    <table class="table table-dark table-listrado">
        <tr class="bg-dark text-white">
            <td>Prato</td>
            <td>Quantidade</td>
            <td>Rua</td>
            <td>Número</td>
            <td>Bairro</td>
            <td>Valor</td>
     
        </tr>
          <asp:Literal runat="server" ID="ltlPedido"></asp:Literal>
    </table>
       </section>
</asp:Content>

