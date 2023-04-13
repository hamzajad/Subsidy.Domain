using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subsidy.Domain.Model;

namespace Subsidy.Application.Interface
{
    public interface IFeedTypeRepositry
    {
        Task<List<FeedType>> GetFeedType();
    }
}
