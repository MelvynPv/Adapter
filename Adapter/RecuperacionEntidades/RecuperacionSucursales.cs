using Adapter.RecuperacionEntidades.Entidades;
using Adapter.RecuperacionEntidades.Interfaces;
using System.Collections.Generic;

namespace Adapter.RecuperacionEntidades
{
    public class RecuperacionSucursales
    {
        private readonly IRecuperacionService recuperacionService;

        public RecuperacionSucursales(IRecuperacionService recuperacionService)
        {
            this.recuperacionService = recuperacionService;
        }

        public List<Sucursal> ObtenerSucursale()
        {
            return recuperacionService.RecuperarSucursales();
        }
    }
}
