using System.Collections.Generic;
using LeafletWebApi.Extensions;
using LeafletWebApi.Helpers;
using LeafletWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeafletWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipmentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OEquipment> GetEquipments()
        {
            var generator = new EquipmentGenerator();
            return generator.GenerateEquipments();
        }

        [HttpGet]
        public string GetGeoJsonCollection()
        {
            var generator = new EquipmentGenerator();
            var equipments = generator.GenerateEquipments();
            return equipments.ToGeoJsonString();
        }
    }
}
