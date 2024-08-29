using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Validar_Click(object sender, EventArgs e)
        {
            string usuario= Txt_Usuario.Text.Trim();
            string clave = Txt_Clave.Text.Trim();
            //No voy a validar nada, proque un usuario y cntraseña puede llevar cualquier  tipo de letra, simbolo  

            //mi usuasrio :judith
            //contraseña: 1234.

            //vamos a comparar con eso
            if(usuario=="judith" && clave == "1234.")
            {
                Server.Transfer("Ejercicio4b.aspx");
            }
            else
            {
                //TENGO LA DUDA SI ESTA BIEN PONER  Server.Transfer("Ejercicio4c.aspx");, PORQUE YO NO ESTOY MANDANSO NADA EN SI , NINGUN DATO QUIERO LLEVAR A AESA PAGINA
               Response.Redirect("Ejercicio4c.aspx");//para redireccionar sin parametros!!!!!!!!!esponse.Redirect
            }
        }
    }
}