using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeafletWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LeafletWebApi.Infrastructure
{
    public class MainDbContext : DbContext
    {
        public DbSet<OEquipment> Equipments { get; set; }
        public DbSet<OLocation> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite();
        }


    }
}
