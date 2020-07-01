using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPedido_Click(object sender, EventArgs e)


    { 


        Pedido p = new Pedido (ddlPrato.SelectedItem.Text, txtRua.Text, Convert.ToInt32(txtNumero.Text), txtBairro.Text, Convert.ToInt32(txtQtd.Text), Convert.ToDouble(ddlPrato.SelectedValue));
        PedidoBD.Insert(p);

        txtQtd.Text = "";
        ddlPrato.SelectedValue = "";
        txtRua.Text = "";
        txtNumero.Text = "";
        txtBairro.Text = "";
        
        


 
    }

    
}