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
            string producto=txt_proodcuto1.Text;
            string producto2=txt_prodcuto2.Text;
            int cantidad = int.Parse(txt_cantidad1.Text);
            int cantidad2 = int.Parse(txt_cantidad2.Text);
            int suma = (cantidad + cantidad2);
            
            string tabla = "<table border = '1'>";
            tabla = "<tr> <td> Prodcuto </td><td>Cantidad </td></tr>";
            
                tabla += "<tr>";
                tabla += "<td>" + producto + "</td>";
                tabla += "<td>" + cantidad + "</td>";
                tabla += "</tr>";

            tabla += "<tr>";
            tabla += "<td>" + producto2 + "</td>";
            tabla += "<td>" + cantidad2 + "</td>";
            tabla += "</tr>";


            tabla += "<tr>";
            tabla += "<td>" + "Total" + "</td>";
            tabla += "<td>"+suma+  "</td>";
            tabla += "</tr>";
            tabla += "</table>";
            lbl_tabla.Text = tabla;
        }

        
    }
}