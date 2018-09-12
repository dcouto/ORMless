using Foundation.BaseClasses.MVC;
using Sitecore.Data.Items;
using System.Collections.Generic;

namespace Feature.GlobalHeader.Models
{
    public class GlobalHeader : BaseModel
    {
        public IEnumerable<Item> NavigationLinks { get; set; }

        public GlobalHeader(Item item) : base(item)
        {
        }
    }
}