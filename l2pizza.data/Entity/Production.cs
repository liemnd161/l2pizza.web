using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2pizza.data.Entity
{
    public class Production : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
