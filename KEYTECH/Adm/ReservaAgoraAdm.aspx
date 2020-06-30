<%@ Page Title="" Language="C#" MasterPageFile="~/Adm/AdmMasterPage.master" AutoEventWireup="true" CodeFile="ReservaAgoraAdm.aspx.cs" Inherits="Adm_ReservaAgoraAdm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div align="center"> <h3 >CONSULTAR RESERVAS</h3></div>
   <section>
    <table class="table table-dark table-listrado">
        <tr class="bg-dark text-white">
            <td>Nome</td>
            <td>Sobrenome</td>
            <td>Quantidade de Adultos</td>
            <td>Quantidade de Crianças</td>
            <td>Data / Hora</td>
        </tr>
          <asp:Literal runat="server" ID="ltlReserva"></asp:Literal>
    </table>
       </section>
</asp:Content>

