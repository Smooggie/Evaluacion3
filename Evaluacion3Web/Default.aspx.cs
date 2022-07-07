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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Este Metodo se ejecuta cuando se carga el form puede ser:
            //- cuando es una peticion GET (!PostBack)
            //- cuando es una peticion POST (PostBack)
            if (!IsPostBack)
            {
                //aqui cargar la lista del dropdown
                List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
                this.lecturaDd1.DataSource = lecturas;
                this.lecturaDd1.DataTextField = "Numero";
                this.lecturaDd1.DataValueField = "Consumo";
                this.lecturaDd1.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. obtener los datos del formulario
            string numero = this.numeroTxt.Text.Trim();
            //string fecha = DateTime.Now.ToString("yyyy-MM-dd" + " " + "HH:mm:ss");
            //string consumo = this.consumoTxt.Text.Trim();
            //eso obtiene el valor del dropdown
            string lecturaValor = this.lecturaDd1.SelectedValue;
            //eso obtiene el texto
            string lecturaTexto = this.lecturaDd1.SelectedItem.Text;
            int tipo = Convert.ToInt32(this.tipoRb1.SelectedItem.Value);

            //2. construir el objeto de tipo medidor
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            Lectura lectura = lecturas.Find(b => b.Numero == this.lecturaDd1.SelectedItem.Value);

            Medidor medidor = new Medidor()
            {
                Numero = numero,
                //Fecha = fecha,
                // Consumo = consumo,
                Tipo = tipo,
                //BebidaFavorita = bebida
            };
            //3. Llamar al DAL
            medidoresDAL.Agregar(medidor);
            //4. Mostrar mensaje de exito
            this.mensajeLb1.Text = "Medidor Ingresado";
            Response.Redirect("VerMedidores.aspx");
        }





    }
}