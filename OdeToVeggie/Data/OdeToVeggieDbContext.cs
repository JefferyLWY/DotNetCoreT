using Microsoft.EntityFrameworkCore;
using OdeToVeggie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToVeggie.Data
{
    public class OdeToVeggieDbContext : DbContext
    {
        public OdeToVeggieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
