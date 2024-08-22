using System;
using System.Collections.Generic;
using System.Configuration;
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

    
        protected bool validoProducIsLetter(string CualquiProducto)
        {
            foreach (char letra in CualquiProducto)
            {
                if (char.IsLetter(letra) == false) //verifica qeu solo se puedan ingresar letras en los productos , sino devulve false
                {
                    return false;
                }

            }
            return true;
        }
        protected bool validoCantidadIsDigit(string CualquiCantidad)
        {
            foreach (char numeros in CualquiCantidad)
            {
                if (char.IsDigit(numeros) == false) // verifica qeu solo se puedan ingresar numeros deo 0-9 en las cantidades, sino devulve false
                {
                    return false;
                }
            }

            return true;
        }          
    

        protected void btn_GenerarTabla_Click(object sender, EventArgs e)
        {

            //validaciones de los texbox
           
            //que no se ingresen  letras en losproductos y numeros en la cantidad vacios

            string producto1=txt_producto1.Text.Trim();
            string producto2=txt_producto2.Text.Trim();
            // int cantidad1 = int.Parse(txt_cantidad1.Text); E·STO NO LO PUEDO PARCEAR ACA PORQEU PARA PODER USAR LA VALIDACIONDE QUE SOLO DSE INGRESEN NUMERO, TIENEN QUE ESTAR SI O SI EN STRING, Y SI LO SPARCEO ANTES NO ME ANDA LA VALIDACION
            //int cantidad2 = int.Parse(txt_cantidad2.Text);
            //int suma = (cantidad1 + cantidad2);
            string cantidad1 = (txt_cantidad1.Text.Trim());
             string cantidad2 =(txt_cantidad2.Text.Trim());

            if(validoProducIsLetter(producto1) && producto1 != " " && validoProducIsLetter(producto2) && producto2 != " " && validoCantidadIsDigit(cantidad1) && cantidad1 != " " && validoCantidadIsDigit(cantidad2) && cantidad2 != " ")
            {
                lbl_error.Text = " ";
                

                int cant1 = int.Parse(cantidad1);
                int cant2 = int.Parse(cantidad2);
                int suma = (cant1 + cant2);

                string tabla = "<table >";
                tabla = "<tr> <td> Prodcuto </td><td>Cantidad </td></tr>";

                tabla += "<tr>";
                tabla += "<td>" + producto1 + "</td>";
                tabla += "<td>" + cant1 + "</td>";
                tabla += "</tr>";

                tabla += "<tr>";
                tabla += "<td>" + producto2 + "</td>";
                tabla += "<td>" + cant2 + "</td>";
                tabla += "</tr>";


                tabla += "<tr>";
                tabla += "<td>" + "Total" + "</td>";
                tabla += "<td>" + suma + "</td>";
                tabla += "</tr>";
                tabla += "</table>";

                lbl_tabla.Text = tabla;

                txt_producto1.Text = " ";
                txt_producto2.Text = " ";
                txt_cantidad1.Text = " ";
                txt_cantidad2.Text = " ";

            }
            else
            {
                lbl_error.Text = ("<span style='color: red;'> El producto ingresado no es valido, verificar que no este vacio y que no contenga signos ni numeros </span>");//CA HACEMOS QUE EN LABEL ME APAREZCA EL TEXTO Y ADEMAS DE COLOR ROJO
                 lbl_tabla.Text = " ";//ES MAS NO AGREAGE QUE SE BORREN LOS TEX_BOX PARA ASI SE VE DONDE ESTA EL ERROR
                
                //lbl_error.Text="El producto ingresado no es valido, verificar que no este vacio y que no contenga signos ni numeros";
                // Response.Write("<span stylr='color: red;'>erroro</span>"); //PARA HACER CARTELES TAMBIEN PODRIA USAR ESTE
               
             
            }


        }

        
    }
}