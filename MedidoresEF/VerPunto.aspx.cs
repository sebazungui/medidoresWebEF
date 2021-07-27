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
    public partial class VerPunto : System.Web.UI.Page
    {
        PuntosCargaDAL puntosCargaDAL = new PuntosCargaDAL();
        private void CargarTabla(List<PuntoCarga> puntos)
        {
            puntosGrid.DataSource = puntos;
            puntosGrid.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(puntosCargaDAL.GetAll());
            }

        }

        protected void puntosGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                Int32 idEliminar = Convert.ToInt32(e.CommandArgument);
                puntosCargaDAL.Remove(idEliminar);
                CargarTabla(puntosCargaDAL.GetAll());
            }

            if (e.CommandName == "editar")
            {
                String id = (e.CommandArgument).ToString();
                PuntoCarga pto = new PuntoCarga();
                Session["Data"] = pto;
                Response.Redirect(string.Format("ActualizarPunto.aspx?id={0}", id));

            }
        }

        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            int tipoSel = Convert.ToInt32(tipoDdl.SelectedValue);
            List<PuntoCarga> filtrada = puntosCargaDAL.GetAll(tipoSel);
            CargarTabla(filtrada);
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            tipoDdl.Enabled = !todosChx.Checked;
            if (todosChx.Checked)
            {
                CargarTabla(puntosCargaDAL.GetAll());
            }
        }
    }
}