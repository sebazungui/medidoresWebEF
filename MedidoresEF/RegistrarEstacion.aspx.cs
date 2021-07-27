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
    public partial class RegistrarEstacion : System.Web.UI.Page
    {
        EstacionesServicioDAL estacionServicioDAL = new EstacionesServicioDAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idTxt.Text.Trim());
                int capacidadMaxima = Convert.ToInt32(capacidadTxt.Text.Trim());
                String direccion = direccionTxt.Text.Trim();
                String ciudad = ciudadTxt.Text.Trim();

                EstacionServicio es = new EstacionServicio();
                es.Id = id;
                es.CapacidadMaxima = capacidadMaxima;
                es.Direccion = direccion;
                es.Ciudad = ciudad;

                new EstacionesServicioDAL().Add(es);
                mensajeLbl.Text = "Estación agregada con éxito";
                limpiar();

            }
            else
            {

            }
        }

        private void limpiar()
        {
            idTxt.Text = "";
            capacidadTxt.Text = "";
            direccionTxt.Text = "";
            ciudadTxt.Text = "";
        }

        protected void idCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String id = idTxt.Text.Trim();

            if (id == string.Empty)
            {
                idCV.ErrorMessage = "Debe ingresar id";
                args.IsValid = false;
            }
            else
            {
                if (estacionServicioDAL.GetEstacion(Convert.ToInt32(id)) != null)
                {
                    idCV.ErrorMessage = "Id ya existe en el sistema";
                    args.IsValid = false;
                }
                else
                {
                    args.IsValid = true;
                }

            }


        }
    }
}