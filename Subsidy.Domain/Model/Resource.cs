using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.Model
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FeedType> Items { get; } = new List<FeedType>();

    }
}
