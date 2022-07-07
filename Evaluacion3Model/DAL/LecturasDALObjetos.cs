using Evaluacion3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion3Model.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public void Eliminar(string numero)
        {
            Lectura eliminado = lecturas.Find(c => c.Numero == numero);
            lecturas.Remove(eliminado);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return new List<Lectura>()
            {
                new Lectura()
                {
                    Numero="Analogo",
                    Consumo="FP-01",
                    

                },
                new Lectura()
                {
                    Numero="Digital",
                    Consumo="CF-01"
                },
                new Lectura()
                {
                    Numero="Te Chai",
                    Consumo="TE-01"
                },
                new Lectura
                {
                    Numero="Te del Dia",
                    Consumo="TE-02"
                }
            };
        }
    }
}
