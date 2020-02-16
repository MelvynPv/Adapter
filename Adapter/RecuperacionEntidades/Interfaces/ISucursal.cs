namespace Adapter.RecuperacionEntidades.Interfaces
{
    public interface ISucursal
    {
        string Id { get; set; }

        string Nombre { get; set; }

        int TotalVentas { get; set; }
    }
}
