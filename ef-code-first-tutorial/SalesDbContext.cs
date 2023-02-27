using ef_code_first_tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_tutorial {
    public class SalesDbContext : DbContext {

        //Tables accessible to EF
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        //Non-web app requires 2 contstructors
        public SalesDbContext() { }
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

        //bc non-web app method need to pass in connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connStr = "server=localhost\\sqlexpress;" +
                            "database=SalesDB2;" +
                            "trusted_connection=true;" +
                            "trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }

    }
}
