using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    public partial class Ejercicio4c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           //ACA NO ENVIE NINGUN DATO DE LA OTRA PAGINA PORQUE  NO LOS VOY A USAR

            Lbl_Invalido.Text = "USUARIO INVALIDO INGRESO NO PERMITDO";
        }
    }
}