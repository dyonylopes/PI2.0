using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        {
            Log lAdm = new Log("adm@sabordovale.com.br", "123456");
            string senha = txtSenha.Text;
            string email = txtEmail.Text;
            if (senha == lAdm.Senha && email == lAdm.Email)
            {
                Response.Redirect("Adm/Default.aspx");
            }
            else
            {
                Response.Redirect("PaginaErro.aspx");
            }

            txtEmail.Text = "";
            txtSenha.Text = "";
        }

    }



    protected void btnResrva_Click(object sender, EventArgs e)
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
