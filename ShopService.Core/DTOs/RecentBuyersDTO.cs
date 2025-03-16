using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Application.DTOs
{
    public class RecentBuyersDTO
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime LastPurchaseDate { get; set; }
    }
}
