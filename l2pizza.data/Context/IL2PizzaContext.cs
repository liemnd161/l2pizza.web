using l2pizza.data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2pizza.data.Context
{
    public interface IL2PizzaContext : IDisposable
    {
        DbSet<Production> Productions { get; set; }
    }
}
