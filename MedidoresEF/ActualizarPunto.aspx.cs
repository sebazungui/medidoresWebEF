using MedidoresDatos;
using MedidoresDatos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class ActualizarPunto : System.Web.UI.Page
    {
        PuntosCargaDAL puntosCargaDAL = new PuntosCargaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                String id = Request.QueryString["id"];
                idTxt.Text = id;
                int idBuscar = Convert.ToInt32(id);
                PuntoCarga pto = puntosCargaDAL.GetPunto(idBuscar);
                capacidadTxt.Text = pto.CapacidadMaxima.ToString();
                fechaTxt.Text = pto.FechaVencimiento;
                tipoRbl.SelectedValue = pto.Tipo.ToString();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
            Calendar1.Attributes.Add("style", "position:absolute");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            fechaTxt.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
            }
        }

        protected void actualizarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idTxt.Text.Trim());
                int tipo = Convert.ToInt32(tipoRbl.SelectedValue);
                int capacidad = Convert.ToInt32(capacidadTxt.Text.Trim());
                String fecha = fechaTxt.Text.Trim();

                PuntoCarga p = new PuntoCarga();
                p.Id = id;
                p.Tipo = tipo;
                p.CapacidadMaxima = capacidad;
                p.FechaVencimiento = fecha;

                new PuntosCargaDAL().Update(p);
                
                Response.Redirect("VerPunto.aspx");

            }
        }


    }
}