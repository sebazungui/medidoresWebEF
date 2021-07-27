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
    public partial class VerEstacion : System.Web.UI.Page
    {
        EstacionesServicioDAL estacionesServicioDAL = new EstacionesServicioDAL();
        private void CargarTabla(List<EstacionServicio> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind(); 
        }
            
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estacionesServicioDAL.GetAll());
            }
        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                Int32 idEliminar = Convert.ToInt32(e.CommandArgument);
                estacionesServicioDAL.Remove(idEliminar);
                CargarTabla(estacionesServicioDAL.GetAll());
            }
        }
    }
}