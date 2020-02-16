using Adapter.RecuperacionEntidades;
using Adapter.RecuperacionEntidades.Interfaces;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IRecuperacionService recuperacionService = new RecuperarEntidades();
            RecuperacionSucursales recuperacionSucursales = new RecuperacionSucursales(recuperacionService);

            Console.WriteLine("Servicio de entidades");
            foreach (var sucursal in recuperacionSucursales.ObtenerSucursale())
            {
                Console.WriteLine(sucursal.ToString());
            }

            RecuperarJson recuperarJson = new RecuperarJson();
            Console.WriteLine("Servicio de Json");
            Console.WriteLine(recuperarJson.RecuperarJsonSucursales());

            Console.WriteLine("Adaptación");
            recuperacionSucursales = new RecuperacionSucursales(new AdapterJsonToEntidadSucursales(recuperarJson));
            foreach (var sucursal in recuperacionSucursales.ObtenerSucursale())
            {
                Console.WriteLine(sucursal.ToString());
            }


        }
    }
}
