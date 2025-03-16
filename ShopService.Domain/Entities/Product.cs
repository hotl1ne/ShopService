using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Article { get; set; }
        public double Price { get; set; }

        public List<OrderProducts> OrderItems { get; set; } = new();
    }
}
