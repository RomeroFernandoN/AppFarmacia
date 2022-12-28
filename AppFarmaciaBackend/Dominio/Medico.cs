using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Medico
    {
        public Persona oPersona { get; set; }
        public int Matricula { get; set; }

        public Medico()
        {
             oPersona = new Persona();
        }
    }
}
