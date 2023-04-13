using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.DTO
{
    public class PurchaseItemsSummationDTO
    {
        public int TotalSummation { get; set; }

        public List<PurchaseItemsDTO> PurchaseItem { get; set; }
    }
}
