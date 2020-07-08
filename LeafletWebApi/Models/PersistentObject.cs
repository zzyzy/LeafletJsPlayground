using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeafletWebApi.Models
{
    public abstract class PersistentObject
    {
        public Guid ObjectID { get; set; }
        public string ObjectName { get; set; }
        public string ObjectNumber { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset ModifiedDateTime { get; set; }
        public int VersionNumber { get; set; }
        public bool IsDeleted { get; set; }
    }
}
