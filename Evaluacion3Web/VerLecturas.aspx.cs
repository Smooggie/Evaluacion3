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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }

        private void cargaGrilla()
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        

        protected void grillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar
                //por tanto, tengo que eliminar el cliente
                string numero = Convert.ToString(e.CommandArgument);
                lecturasDAL.Eliminar(numero);
                cargaGrilla();
            }
        }
    }
}