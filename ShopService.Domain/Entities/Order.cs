using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public Guid CustomerId { get; set; }
        public User Customer { get; set; } = null!;

        public List<OrderProducts> OrderItems { get; set; } = new();
    }
}
