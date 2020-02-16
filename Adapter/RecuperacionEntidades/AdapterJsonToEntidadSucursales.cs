using Adapter.RecuperacionEntidades.Entidades;
using Adapter.RecuperacionEntidades.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Adapter.RecuperacionEntidades
{
    public class AdapterJsonToEntidadSucursales : IRecuperacionService
    {
        private readonly IRecuperarJson recuperarJson;

        public AdapterJsonToEntidadSucursales(IRecuperarJson recuperarJson)
        {
            this.recuperarJson = recuperarJson;
        }

        public List<Sucursal> RecuperarSucursales()
        {
            string sucursalesJson = recuperarJson.RecuperarJsonSucursales();

            JObject convert = JObject.Parse(sucursalesJson);

            return JsonConvert.DeserializeObject<List<Sucursal>>(convert["sucursales"].ToString());
        }
    }
}
