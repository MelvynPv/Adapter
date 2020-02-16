using Adapter.RecuperacionEntidades.Interfaces;

namespace Adapter.RecuperacionEntidades.Entidades
{
    public class Sucursal : ISucursal
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int TotalVentas { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1}, Ventas: {2}",Id,Nombre,TotalVentas);
        }
    }
}
