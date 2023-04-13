using Subsidy.Application.Interface;
using Subsidy.Domain.DTO;
using Subsidy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Subsidy.infrastructure.Services
{
    public class ItemService : ItemRepositry
    {
        public static List<Item> items = new List<Item>()
        {
          new Item{Id =1 , BalePrice = 110 , BaleWeight = 15 , Fk_feedTypeId = 1 },
          new Item{Id =2 , BalePrice = 231 , BaleWeight = 15 , Fk_feedTypeId = 1 },
          new Item{Id =3 , BalePrice = 110 , BaleWeight = 5 , Fk_feedTypeId = 1 },
          new Item{Id =4 , BalePrice = 100 , BaleWeight = 5 , Fk_feedTypeId = 1 }

        };

        public Task<List<ItemDTO>> GetItems(int id)
        {
            var getItems = (from itm in items
                            join fty in FeedTypeService.feedTypes on itm.Fk_feedTypeId equals fty.Id
                            join res in FeedTypeService.resources on fty.Fk_resourceId equals res.Id
                            where fty.Id == id
                            select new ItemDTO
                            {
                                BalePrice = itm.BalePrice,
                                BaleWeight = itm.BaleWeight,
                                FeedTypeName = fty.NameFeedType,
                                ResourceName = res.Name,
                            }
                         );
            return Task.FromResult(getItems.ToList());
        }

        public Task<PurchaseItemsSummationDTO> InsertItems(List<ItemDTO> items)
        {
            try
            {
                int totalSummation = 0;
                PurchaseItemsSummationDTO purchaseItemsDTO = new PurchaseItemsSummationDTO();
                List<PurchaseItemsDTO> purchaseItems = new List<PurchaseItemsDTO>();
                foreach (ItemDTO item in items)
                {
                    if (item.Total > 0)
                    {
                        PurchaseItemsDTO purchase = new PurchaseItemsDTO()
                        {
                            FeedCategory = item.FeedTypeName,
                            ResourceName = item.ResourceName,
                            Total = item.Total,
                            Price = item.BalePrice,
                            TotalQuantity = item.Total * item.BalePrice
                        };
                        totalSummation += purchase.TotalQuantity;
                        purchaseItems.Add(purchase);
                        purchaseItemsDTO.PurchaseItem = purchaseItems;
                    }

                }

                purchaseItemsDTO.TotalSummation = totalSummation;
                return Task.FromResult(purchaseItemsDTO);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }


}
