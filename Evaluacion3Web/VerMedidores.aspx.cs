using Evaluacion3Model.DAL;
using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion3Web
{
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Medidor> medidores = medidoresDAL.Obtener();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }

        private void cargaGrilla(List<Medidor> filtrada)
        {
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }

        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar
                //por tanto, tengo que eliminar el cliente
                string numero = Convert.ToString(e.CommandArgument);
                medidoresDAL.Eliminar(numero);
                cargaGrilla();
            }
        }

        protected void tipoDb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDb1.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.tipoDb1.SelectedItem.Value);
                //filtrar por nivel
                List<Medidor> filtrada = medidoresDAL.Filtrar(tipo);
                cargaGrilla(filtrada);
            }
        }
    }
}