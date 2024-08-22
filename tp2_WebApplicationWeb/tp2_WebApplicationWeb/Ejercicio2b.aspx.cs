using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            string apellido;


            /* nombre = Request.QueryString["nom"];
             apellido = Request.QueryString["ape"];
             Lbl_Resumen.Text = nombre+ " "+ apellido;

             */
            nombre = Request["Txt_Nombre"].ToString();
            apellido = Request["Txt_APellido"].ToString();
            Lbl_Resumen.Text = nombre + " " + apellido;

        }
    }
}