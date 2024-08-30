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
        protected Decimal acumuladorAccesorios() {
            Decimal acu = 0;
           foreach(ListItem item in Cbox_Accesorios.Items)
            {
                if (item.Selected)
                {
                    acu += Decimal.Parse(item.Value);
                }
            }
            return acu;
        }

        protected void Btn_CalcularPRecio_Click(object sender, EventArgs e)
        {
            //primero agarro el precio de GB, y a partir de eso, iré acumulando
            /* float Acumularprecio = 0;
             Acumularprecio = float.Parse(Ddl_Memoria.SelectedValue);
             //Recorrer cada item y su valor del combito 
             foreach(ListItem itemSeleccion in Cbox_Accesorios.Items)
             {
                 if (itemSeleccion.Selected)
                 {
                 Acumularprecio += float.Parse(itemSeleccion.Value);

                 }
             }*/
            Decimal PrecioFinalApagarJudi = 0;
            PrecioFinalApagarJudi = Decimal.Parse(Ddl_Memoria.SelectedValue);
         //   Lbl_Precio.Text = "El precio Fianl es de :" + Acumularprecio.ToString();

             int selecion= Cbox_Accesorios.SelectedIndex;
            int memoria= Ddl_Memoria.SelectedIndex;
            if (SeleccionItem(selecion)==true && SeleccionItem(memoria)==true) 
            {
                try
                {//  Double seleccion_= Double.Parse(Cbox_Accesorios.SelectedValue);    
                    
                    Decimal acumulador = Decimal.Parse(Cbox_Accesorios.SelectedValue);

                    Decimal JudiPaga = acumuladorAccesorios();

                    Decimal memoria_ = Decimal.Parse(Ddl_Memoria.SelectedValue);
                   
                    PrecioFinalApagarJudi = (JudiPaga + memoria_);
                    
                    Lbl_Precio.Text = "El precio Fianl es de :" + PrecioFinalApagarJudi+" en $$";
                }catch(Exception ex)
                {
                    lbl_error.Text = ex.Message;
                }
             

            }else
            {
                lbl_error.Text = "Seleccione algun item!";
            } 
        }
    }
}