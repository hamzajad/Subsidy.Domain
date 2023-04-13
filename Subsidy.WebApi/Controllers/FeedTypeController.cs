using Microsoft.AspNetCore.Mvc;
using Subsidy.Application.Interface;
using Subsidy.Domain.DTO;
using Subsidy.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subsidy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedTypeController : ControllerBase
    {
        private IFeedTypeRepositry _feedTypeRepositry;
        public FeedTypeController(IFeedTypeRepositry feedTypeRepositry)
        {
            this._feedTypeRepositry = feedTypeRepositry;
        }
        // GET: api/<FeedTypeController>
        [HttpGet]
        public async Task<List<FeedTypeDto>> Get()
        {
            return await _feedTypeRepositry.GetFeedType();
        }
    }
}
