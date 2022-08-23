using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2pizza.data.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public Guid? LastUpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
