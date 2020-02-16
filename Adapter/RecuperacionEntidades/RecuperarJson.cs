using Adapter.RecuperacionEntidades.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.RecuperacionEntidades
{
    public class RecuperarJson: IRecuperarJson
    {
        public string RecuperarJsonSucursales()
        {
            JObject rss =
             new JObject(
                 new JProperty("sucursales",
                   new JArray(
                     new JObject(
                         new JProperty("Id", "O1"),
                         new JProperty("Nombre", "Oeste"),
                         new JProperty("TotalVentas", "52")),
                      new JObject(
                         new JProperty("Id", "E1"),
                         new JProperty("Nombre", "Este"),
                         new JProperty("TotalVentas", "1")),
                       new JObject(
                         new JProperty("Id", "E2"),
                         new JProperty("Nombre", "Este2"),
                         new JProperty("TotalVentas", "10")),
                        new JObject(
                         new JProperty("Id", "NE2"),
                         new JProperty("Nombre", "NorEste2"),
                         new JProperty("TotalVentas", "7"))
                     )));

            return rss.ToString();
        }
    }
}
