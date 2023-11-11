
using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models
{
    public class DemoContext: DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
