using Subsidy.Domain.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidy.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public int BaleWeight { get; set; }
        public int BalePrice { get; set; }
        public int Amount { get; set; }
        public int? Fk_feedTypeId { get; set; }
        public virtual FeedType? FkFeedType { get; set; }


    }
}
