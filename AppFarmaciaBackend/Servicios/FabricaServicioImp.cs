using AppFarmaciaBackend.Servicios.Implementación;
using AppFarmaciaBackend.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Servicios
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
