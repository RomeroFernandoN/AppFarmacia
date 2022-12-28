using AppFarmaciaBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Datos.Interfaz
{
    public interface IEntregaDao
    {
        int ObtenerProximaEntrega();
        bool CrearEntrega(Entrega oEntrega);
        List<Entrega> ObtenerEntregas(List<Parámetro> lstParametros);
        bool EliminarEntrega(int id);
        List<DetalleEntrega> ObtenerDetallesEntrega(int idEntrega);
        Entrega ObtenerEntrega(int idEntrega);
        bool ActualizarEntrega(Entrega oEntrega);
    }
}
