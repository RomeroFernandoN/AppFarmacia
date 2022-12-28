using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class ObraSocial
    {
        public ObraSocial(int idObraSocial, string nombre)
        {
            IdObraSocial = idObraSocial;
            Nombre = nombre;
        }

        public int IdObraSocial { get; set; }
        public string Nombre { get; set; }

    }
}
