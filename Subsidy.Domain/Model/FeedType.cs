using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.Model
{
    public class FeedType
    {
        public int Id { get; set; }
        public string? NameFeedType { get; set; }
        public int? Fk_resourceId { get; set; }
        public virtual Resource? Resource { get; set; }
        public virtual ICollection<Item> Items { get; } = new List<Item>();
    }
}
