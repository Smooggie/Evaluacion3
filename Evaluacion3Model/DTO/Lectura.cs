using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DTO
{
    public class Lectura
    {
        private string numero;
        private string fecha;
        private string consumo;
        

        public string Numero { get => numero; set => numero = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Consumo { get => consumo; set => consumo = value; }
    }
}
