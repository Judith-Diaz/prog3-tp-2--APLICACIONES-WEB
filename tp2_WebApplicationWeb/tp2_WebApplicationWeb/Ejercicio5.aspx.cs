using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cbox_Monitor_SelectedIndexChanged(object sender, EventArgs e)//!! no que carajo es esto, o como lo llegue a poner m,e da mierso hacer cagada si lo borro
        {

        }

        protected bool SeleccionItem(int item)//lo que estoy buscabdo es que el desplegable combobox, tenga alguna opcion seleccionada, si no esta nada selecionado devuelve -1(ua que empieza desde cero su lista), use la misma funcion para el cheklist, osea las opciones para selelcionar , es elm ismo  metodo
        {
            if (item == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected float acumuladorAccesorios() {
            float acumuladorDePrecios = 0;
           foreach(ListItem itemSeleccionados in Cbox_Accesorios.Items)
            {
                if (itemSeleccionados.Selected)
                {
                    acumuladorDePrecios += float.Parse(itemSeleccionados.Value);
                }
            }
            return acumuladorDePrecios;
        }

        protected void Btn_CalcularPRecio_Click(object sender, EventArgs e)
        {
         
              float PrecioFinal = 0;
  

              int selecion= Cbox_Accesorios.SelectedIndex;
              int memoria= Ddl_Memoria.SelectedIndex;
            if (SeleccionItem(selecion)==true && SeleccionItem(memoria)==true) 
            {
    
                    float PrecioAccesoriosAcumulados = acumuladorAccesorios();
                    float PreciosMemoria = float.Parse(Ddl_Memoria.SelectedValue);
                  

                    PrecioFinal = (PreciosMemoria + PrecioAccesoriosAcumulados);

                    Lbl_Precio.Text = "El precio Fianl es de : " + PrecioFinal+" $";

                }else
                   {
                lbl_error.Text = "Seleccione algun item!";
                   } 
        }
    }
}