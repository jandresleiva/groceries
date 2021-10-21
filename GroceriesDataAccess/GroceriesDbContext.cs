using Groceries.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Groceries.Models.Purchase;

namespace Groceries.Data
{
    public class GroceriesDbContext : DbContext
    {
        public DbSet<Market> Market { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Detail> Detail { get; set; }


        public GroceriesDbContext(DbContextOptions<GroceriesDbContext> options) : base(options)
        {
        }

    }
}
