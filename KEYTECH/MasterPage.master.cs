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
}
