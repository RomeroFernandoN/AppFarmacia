using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public Persona oPersona { get; set; }
        public Empleado()
        {
            oPersona = new Persona();
        }

        public Empleado(int idEmpleado, Persona oPersona)
        {
            IdEmpleado = idEmpleado;
            this.oPersona = oPersona;
        }

        public override string ToString()
        {
            return oPersona.Nombre + ", " + oPersona.Apellido;
        }
    }
}
