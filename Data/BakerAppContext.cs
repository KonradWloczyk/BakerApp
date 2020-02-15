using Microsoft.EntityFrameworkCore;
using BakerApp.Models;

namespace BakerApp.Data
{
    public class BakerAppContext : DbContext
    {
        public BakerAppContext(DbContextOptions<BakerAppContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client{ get; set; }
        public DbSet<Order> Order { get; set; }
    }
}