<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReserveAgora.aspx.cs" Inherits="ReserveAgora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    

     <main class="container">
            <div class="row">

                <div class="col-12">
                    <h2>Cadastro</h2>
                </div>


                <div class="col-6 mt-5">
                    <label>Nome:</label>
                    <asp:TextBox placeholder="Digite seu nome..." ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-6 mt-5">
                    <label>Sobrenome:</label>
                    <asp:TextBox placeholder="Digite seu sobrenome..." ID="txtSobrenome" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
          
                <div class="col-6 mt-5">
                    <label>Quantidades de Adultos:</label>
                    <asp:TextBox type="number" min="0" MaxLength="10" ID="txtAdultos" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-6 mt-5">
                    <label>Quantidades de Crianças:</label>
                    <asp:TextBox type="number" min="0" MaxLength="10" ID="txtCriancas" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

            
                <div class="col-12 mt-5">
                    <label>Data:</label>
                   <asp:TextBox  Type="datetime-local" ID="txtData" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
        </div>
        
            <div class="col-12 mt-3">

                <asp:Button runat="server" Text="Reservar" ID="btnReserva" CssClass="btn btn-danger" OnClick="btnReserva_Click" />
            </div>

    </main>

</asp:Content>

