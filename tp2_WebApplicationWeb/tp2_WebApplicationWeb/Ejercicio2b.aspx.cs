using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_WebApplicationWeb
{
    /*        
    nombre = Request.QueryString["nom"];
    apellido = Request.QueryString["ape"];                          
    
    tema = Request["Cb_Items"].;
   nombre = Request.QueryString["nom"];  */
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string nombre_;
          string apellido;
           string zona;
          

          nombre_ = Request["Txt_Nombre"].ToString();
            apellido = Request["Txt_APellido"].ToString();
          zona = Request["Ddl_Ciudad"];
             string tema_;
             
           
            if (Session["seleccionTemas"] != null )//|| nombre_!=null || apellido !=null || zona !=null)
            {
                tema_ = Session["seleccionTemas"].ToString();

                Lbl_Resumen.Text = " Nombre : " + "<b>" + nombre_ +"</b>" + "<br/>"+
                                  " Apellido : " + "<b>" +  apellido +"</b>" +"<br/>" +
                                  " Zona : " + "<b>" +  zona + "</b>" +"<br/> " + " <br/>";


                lb_CbItems.Text = tema_;
            }
            else
            {
                Lbl_Resumen.Text = "no ahy texto";
            }
         
        } 
    }
}