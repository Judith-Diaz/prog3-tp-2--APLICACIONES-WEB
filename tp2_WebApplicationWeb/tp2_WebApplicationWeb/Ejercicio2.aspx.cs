using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;


namespace tp2_WebApplicationWeb
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected bool ValidoIsLetter(string texto)
        {
            return texto.All(char.IsLetter);    
        }
        protected bool EspacioVacio(string texto) {

            return texto.Trim().Length > 0; //en este caso si *NO* HAY ESPACIOS EN BLANCO devuelve true, si hay esapcios en blanco seria =0 y devuelve false //, si era == 0 ; quiero decir que  si hay espacio en blanco entonces me va a devolver true
        }
        protected bool SeleccionItem(int item )//lo que estoy buscabdo es que el desplegable combobox, tenga alguna opcion seleccionada, si no esta nada selecionado devuelve -1(ua que empieza desde cero su lista), use la misma funcion para el cheklist, osea las opciones para selelcionar , es elm ismo  metodo
        {
            if (item == -1){
                return false;
            }
            else{ 
                return true; 
            }
        }  


        protected void Btn_Resumen_Click(object sender, EventArgs e)
        {
            string nombre=Txt_Nombre.Text.Trim();
            string apellido=Txt_Apellido.Text.Trim();
         int listDesplegable = Ddl_Ciudad.SelectedIndex;
            int temasCheclist= Cb_Items.SelectedIndex;
            if (ValidoIsLetter(nombre) && EspacioVacio(nombre) && ValidoIsLetter(apellido) && EspacioVacio(apellido)&& SeleccionItem(listDesplegable) && SeleccionItem(temasCheclist))//me mande altas validaciones aca
            {
                nombre = " ";
                apellido = " ";

                //  Response.Redirect("Ejercicio2b.aspx?nom=" + Txt_Nombre.Text + "&ape=" + Txt_Apellido.Text);
                Server.Transfer("Ejercicio2b.aspx");

            }
            else {
                Lbl_Error.Text = ("<span style ='color: purple;'> Campos incorrecto </span>");
            }
            
        }
    }
}