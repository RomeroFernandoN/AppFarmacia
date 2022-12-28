using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Barrio { get; set; }
        public List<Empleado>? Empleados { get; set; }

        public Sucursal()
        {
            Empleados = new List<Empleado>();   
        }

        public Sucursal(int idSucursal, string nombre, int telefono, string barrio)
        {
            IdSucursal = idSucursal;
            Nombre = nombre;
            Telefono = telefono;
            Barrio = barrio;
        }

        public void AgregarEmpleado(Empleado oEmpleado)
        {
            Empleados.Add(oEmpleado);
        }
    }
}
