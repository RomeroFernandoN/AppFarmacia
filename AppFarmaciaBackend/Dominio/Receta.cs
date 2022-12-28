using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Receta
    {
        public int IdReceta { get; set; }
        public Medico oMedico { get; set; }
        public string Diagnostico { get; set; }
        public Insumo oInsumo { get; set; }

        public Receta()
        {
            oMedico = new Medico();
        }
    }
}
