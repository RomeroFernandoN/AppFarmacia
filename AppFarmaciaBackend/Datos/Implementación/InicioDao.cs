using AppFarmaciaBackend.Datos.Interfaz;
using AppFarmaciaBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Datos.Implementación
{
    public class InicioDao : IInicioDao
    {
        public int ObtenerUsuario(Usuario oUsuario)
        {
            List < Parámetro > lstParametros =new List<Parámetro>();
            Parámetro parametroCargo = new Parámetro("@Cargo", oUsuario.Cargo);
            Parámetro parametroUsuario = new Parámetro("@Usuario", oUsuario.Nombre);
            Parámetro parametroContraseña = new Parámetro("@Contraseña", oUsuario.Contraseña);
            lstParametros.Add(parametroCargo);
            lstParametros.Add(parametroUsuario);
            lstParametros.Add(parametroContraseña);
            return HelperDB.ObtenerInstancia().ConsultaEscalarConParametros("SP_INICIO_SESION","@Resultado",lstParametros);
        }
    }
}
