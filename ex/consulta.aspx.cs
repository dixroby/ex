using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ex
{
    public partial class consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string f1 = finicio.Text;
            string f2 = ffin.Text;

           // Cconsulta consulta = new Cconsulta();
            // = consulta.Cfechas(f1,f2).Tables["cfecha"];
            //GridView1.DataBind();

        }
    }
}