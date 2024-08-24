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
        protected string GuardarSeleccion(ListItemCollection items) //EXPLICACION  "ListItemCollection items" :  representa una colección de elementos (ítems) que provienen, por ejemplo, de un control como un CheckBoxList, ListBox o ComboBox
        { 
           
            string guardado = " ";//aca es donde se me van  gguardan todos eso items que voy a concatenar, empieza con " " vacias pq asi empieza la concatenacion, sino me da error por todos lados
            foreach (ListItem varItem in items)// recorre cada elemento ListItem en la coleccion items
            {

                if (varItem.Selected)//loq ue hace es verificar si el elemnto actual varItem esta seleccionado, y si lo esta  se guarda y empeiza la concatenacion en guardar
                {
                    guardado += varItem.Text + "<br/>";//le agregge un salto de linea ,porque si no me mostraba uno arlado del otro , y yo lo queria en forma de lista
                }
            }
            return guardado;//le voy a enviar toda una cadena de string con los items seleccionados
        }

        protected void Btn_Resumen_Click(object sender, EventArgs e)
        {
            string nombre=Txt_Nombre.Text.Trim();
            string apellido=Txt_Apellido.Text.Trim();
            int listDesplegable = Ddl_Ciudad.SelectedIndex;
            int temasCheclist= Cb_Items.SelectedIndex;
            if (ValidoIsLetter(nombre) && EspacioVacio(nombre) && ValidoIsLetter(apellido) && EspacioVacio(apellido)&& SeleccionItem(listDesplegable) && SeleccionItem(temasCheclist))//me mande altas validaciones aca
            {
                string seleccionTemas;
                seleccionTemas = GuardarSeleccion(Cb_Items.Items);//en la funcion que hice envio los items que seleecione para ser evaluaados adentro de foreach y me los va a contener, ay que retorna el guardar de la funcion
                Session["seleccionTemas"]=seleccionTemas;//session es un obj  qeu permite almacenar (request),¨{osea para ejerccio2b.aspx} entonces loq q se hace aca es crear una Session con la palabra clave ["seleccionTemas"], que al avez esta va a contener Todos los items selecionados que contiene la variable seleccionarItems
              
                 //Response.Redirect("Ejercicio2b.aspx?nom=" + nombre + "&ape=" + apellido );NO LO USO..
                Server.Transfer("Ejercicio2b.aspx");//MANDA TODO PARA LA OTRA PAGINA
                
            }
            else 
            {
                Lbl_Error.Text = ("<span style ='color: purple;'> Campos incorrecto </span>");
            }
        
        }
    }
}