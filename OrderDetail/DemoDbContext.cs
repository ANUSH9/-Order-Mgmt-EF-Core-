using Microsoft.EntityFrameworkCore;
using OrderDetail.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetail
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Items> items { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DemoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog=OrderDetails;Integrated Security=True");

        }
    }
}
