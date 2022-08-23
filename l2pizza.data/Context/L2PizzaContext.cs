using l2pizza.data.Entity;
using Microsoft.EntityFrameworkCore;

namespace l2pizza.data.Context
{
    public class L2PizzaContext : DbContext, IL2PizzaContext
    {
        public DbSet<Production> Productions { get; set; }

        public L2PizzaContext(DbContextOptions<L2PizzaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductionConfiguration());
        }
    }
}
