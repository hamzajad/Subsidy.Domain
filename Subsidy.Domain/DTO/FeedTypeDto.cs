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
    public class FeedTypeDto : IMappingForm<FeedType>
    {
        public int Id { get; set; }
        public string? NameFeedType { get; set; }
        public void Mapping(Profile profile)
        {
            // if the proparty is deffrence 
            profile.CreateMap<FeedType, FeedTypeDto>().ReverseMap();
        }
    }
}
