using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subsidy.Domain.DTO;
using Subsidy.Domain.Model;

namespace Subsidy.Application.Interface
{
    public interface IFeedTypeRepositry
    {
        Task<List<FeedTypeDto>> GetFeedType();
    }
}
