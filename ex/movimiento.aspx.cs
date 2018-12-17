using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ex
{
    public partial class movimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Cconsulta c = new Cconsulta();
        protected void Button1_Click(object sender, EventArgs e)
        {
        
            string dnis = txtDni.Text;

            DataSet ds = new DataSet(dnis);
            ds = c.verificarDni(dnis);

            if (ds.Tables["dni"].Rows.Count == 1)
            {
                //la carrera existe
                txtNumeroCuenta.Text = ds.Tables["dni"].Rows[0]["NroCuenta"].ToString();               
            }
            else
            {
                //la carerra no  existe
                Label2.Text = "dni usuario no existe";
            }


           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
    

            Label3.Text = c.retirar(txtNumeroCuenta.Text, txtRetiroo.Text);


            tretiro.DataSource = c.verificMonto(txtDni.Text).Tables["dnis"];
            tretiro.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Cconsulta c = new Cconsulta();

            lmonto.Text =c.depositar(txtNumeroCuenta.Text,Texmonto.Text);


            tdeposito.DataSource = c.verificMonto(txtDni.Text).Tables["dnis"];
            tdeposito.DataBind();
        }
    }
}