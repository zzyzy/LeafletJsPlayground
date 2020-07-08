using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeafletWebApi.Models
{
    public class OEquipment : PersistentObject
    {
        public OLocation Location { get; set; }

        public Dictionary<string, object> ToGeoJsonObject()
        {
            var map = new Dictionary<string, object>
            {
                ["type"] = "Feature",
                ["properties"] = new object(),
                ["geometry"] = new Dictionary<string, object>
                {
                    {"type", "Point"}, 
                    {"coordinates", new[] {Location.Latitude, Location.Longtitude}}
                }
            };

            return map;
        }
    }
}
