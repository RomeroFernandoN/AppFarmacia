using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Usuario
    {
        public int Cargo { get; set; }
        public string Nombre { get; set; }    
        public string Contraseña { get; set; }

        public Usuario(int cargo, string nombre, string contraseña)
        {
            this.Nombre = nombre;
            this.Cargo = cargo;
            this.Contraseña = contraseña;
        }
    }
}
