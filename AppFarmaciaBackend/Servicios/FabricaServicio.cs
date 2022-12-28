using AppFarmaciaBackend.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Servicios
{
    public abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
