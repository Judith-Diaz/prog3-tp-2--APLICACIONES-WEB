using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Lbtn_Rojo_Click(object sender, EventArgs e)
        {
            Lbl_Texto.Text = ("<span style='color: red;'> Texto coloreado </span>");
        }

        protected void lbtn_Azul_Click(object sender, EventArgs e)
        {
            Lbl_Texto.Text =("<span style='color: blue;'> Texto coloreado </span>");
           
        }

        protected void Lbtn_Verde_Click(object sender, EventArgs e)
        {
            Lbl_Texto.Text = ("<span style='color:green;'> Texto coloreado </span>");
        }
    }
    
}