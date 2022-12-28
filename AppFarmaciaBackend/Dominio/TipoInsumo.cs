using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class TipoInsumo
    {
        public int IdTipoInsumo { get; set; }
        public string? Nombre { get; set; }

        public TipoInsumo(int tipoInsumo)
        {
            IdTipoInsumo = tipoInsumo;
        }

        public TipoInsumo()
        {
        }
    }
}
