using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Cliente
    {
        public int? IdCliente { get; set; }
        public Persona oPersona { get; set; }
        public int NroDocumento { get; set; }

        public Cliente()
        {
            oPersona = new Persona();
        }
        
    }
}
