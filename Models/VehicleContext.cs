using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VehicleApi.Models
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options)
        : base(options)
        {

        }
        public DbSet<Makes> Makes { get; set; }

        public DbSet<Models> Models { get; set; }
    }
}
