using Adapter.RecuperacionEntidades.Entidades;
using Adapter.RecuperacionEntidades.Interfaces;
using System.Collections.Generic;

namespace Adapter.RecuperacionEntidades
{
    public class RecuperarEntidades : IRecuperacionService
    {
        public List<Sucursal> RecuperarSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>()
            {
                new Sucursal(){ Id = "N1", Nombre = "Norte", TotalVentas = 10 },
                new Sucursal(){ Id = "S1", Nombre = "Sur", TotalVentas = 2 },
                new Sucursal(){ Id = "SE1", Nombre = "SurEste", TotalVentas = 23 },
                new Sucursal(){ Id = "NE1", Nombre = "NorEste", TotalVentas = 5 }
            };

            return sucursales;
        }
    }
}
