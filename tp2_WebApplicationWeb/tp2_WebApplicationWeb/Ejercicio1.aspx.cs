using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_generarTabla_Click(object sender, EventArgs e)
        {
            string tabla = "<tabla borde = '1'>";
            tabla += "<tr> <td>productos<td><td>cantidad</td></tr>";
        }
    }
}