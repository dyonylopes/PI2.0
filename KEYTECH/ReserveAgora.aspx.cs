using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReserveAgora : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnReserva_Click(object sender, EventArgs e)
    {
        Reserva r = new Reserva(txtNome.Text, txtSobrenome.Text, Convert.ToInt32(txtAdultos.Text), Convert.ToInt32(txtCriancas.Text), Convert.ToDouble(txtData.Text));
        ReservaBD.Insert(r);
        txtNome.Text = "";
        txtSobrenome.Text = "";
        txtAdultos.Text = "";
        txtCriancas.Text = "";
        txtData.Text = "";

    }
}