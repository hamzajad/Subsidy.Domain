using Microsoft.AspNetCore.Mvc;
using Subsidy.Application.Interface;
using Subsidy.Domain.DTO;
using Subsidy.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subsidy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private ItemRepositry _item;
        public ItemController(ItemRepositry item)
        {
            this._item = item;
        }
        // GET: api/<ItemController>
        [HttpGet("{id}")]
        public async Task<List<ItemDTO>> Get(int id)
        {
            return await _item.GetItems(id);
        }

        // POST api/<ItemController>
        [HttpPost]
        public async Task<PurchaseItemsSummationDTO> Post([FromBody] List<ItemDTO> item)
        {
            return await _item.InsertItems(item);
        }

    }
}
