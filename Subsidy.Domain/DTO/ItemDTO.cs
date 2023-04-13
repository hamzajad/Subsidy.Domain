using AutoMapper;
using Subsidy.Domain.Mapping;
using Subsidy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.DTO
{
    public class ItemDTO:IMappingForm<Item>,IMappingForm<FeedType>
    {
        public string FeedTypeName { get; set; }
        public string? ResourceName { get; set; }
        public int BaleWeight { get; set; }
        public int BalePrice { get; set; }
        public int Total { get; set; }
        public int Amount { get; set; }

        public void Mapping(Profile profile)
        {
            // if the proparty is deffrence 
            profile.CreateMap<FeedType, ItemDTO>()
                .ForMember(d => d.FeedTypeName, opt => opt.MapFrom(s => s.NameFeedType));
        }
    }
}
