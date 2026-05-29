using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SPMS_
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=SPMES.Properties.Settings.SPMESDbConnectionString")
        {
        }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Sellers> Sellers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
    
    
}
