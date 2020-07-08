using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeafletWebApi.Models;
using Newtonsoft.Json;

namespace LeafletWebApi.Extensions
{
    public static class EquipmentExtensions
    {
        public static string ToGeoJsonString(this List<OEquipment> equipments)
        {
            var features = equipments.Select(i => i.ToGeoJsonObject());
            var map = new Dictionary<string, object>
            {
                {"type", "FeatureCollection"},
                {"features", features}
            };

            return JsonConvert.SerializeObject(map);
        }
    }
}
