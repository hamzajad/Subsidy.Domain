using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.DTO
{
    public class PurchaseItemsDTO
    {
        public string? FeedCategory { get; set; }
        public string? ResourceName { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public int TotalQuantity { get; set; }

    }
}
