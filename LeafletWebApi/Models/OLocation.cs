using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeafletWebApi.Models
{
    public class OLocation : PersistentObject
    {
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
    }
}
