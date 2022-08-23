using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using l2pizza.data.Context;

namespace l2pizza.data.Entity
{
    public class DesignTimeL2PizzaContextFactory : IDesignTimeDbContextFactory<L2PizzaContext>
    {
        public L2PizzaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<L2PizzaContext>();
            // pass your design time connection string here
            optionsBuilder.UseSqlServer("Server=DESKTOP-S8PMC72\\SQLEXPRESS;Database=l2pizza;Trusted_Connection=True;");
            return new L2PizzaContext(optionsBuilder.Options);
        }
    }
}
