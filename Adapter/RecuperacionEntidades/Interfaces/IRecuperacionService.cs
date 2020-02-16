using Adapter.RecuperacionEntidades.Entidades;
using System.Collections.Generic;

namespace Adapter.RecuperacionEntidades.Interfaces
{
    public interface IRecuperacionService
    {
        List<Sucursal> RecuperarSucursales();
    }
}
