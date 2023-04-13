using Subsidy.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subsidy.Domain.Model;
using AutoMapper;
using Subsidy.Domain.DTO;
using Subsidy.Domain.Mapping;

namespace Subsidy.infrastructure.Services
{
    public class FeedTypeService : IFeedTypeRepositry
    {
        public static List<Resource> resources = new List<Resource>()
        {
            new Resource{Id = 1, Name = "الوطنية للانتاج وتسويق الاعلاف"}
        };
        public static List<FeedType> feedTypes = new List<FeedType>()
        {
            new FeedType{Id = 1 , NameFeedType = "وافي تسمين" ,Fk_resourceId = 1 },
            new FeedType{Id = 2 , NameFeedType = "شعير",Fk_resourceId = 1},
            new FeedType{Id = 3 , NameFeedType = "ذرة مجروشه", Fk_resourceId = 1},
            new FeedType{Id = 4 , NameFeedType = "حبوب خاصة", Fk_resourceId = 1},
            new FeedType{Id = 5 , NameFeedType = "خلطات مركزة", Fk_resourceId = 1},

        };
        public Task<List<FeedTypeDto>> GetFeedType()
        {
            var mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()).CreateMapper();
            var itemDTOs = mapper.Map<List<FeedTypeDto>>(feedTypes);
            return Task.FromResult(itemDTOs);
        }

    }
}
