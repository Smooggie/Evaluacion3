using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DAL
{
    public class MedidoresDALObjetos : IMedidoresDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void Agregar(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void Eliminar(string numero)
        {
            Medidor eliminado = medidores.Find(c => c.Numero == numero);
            medidores.Remove(eliminado);
        }

        public List<Medidor> Filtrar(int tipo)
        {
            return medidores.FindAll(c => c.Tipo == tipo);
        }

        public List<Medidor> Obtener()
        {
            return medidores;
        }
    }
}
