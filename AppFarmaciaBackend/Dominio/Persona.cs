using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona()
        {
        }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }
    }
}
