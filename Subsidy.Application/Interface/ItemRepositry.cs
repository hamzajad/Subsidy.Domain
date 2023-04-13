using Subsidy.Domain.DTO;
using Subsidy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Application.Interface
{
    public interface ItemRepositry
    {
        Task<List<ItemDTO>> GetItems(int Id);
        Task<PurchaseItemsSummationDTO> InsertItems(List<ItemDTO> item);
    }
}
