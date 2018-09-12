using Foundation.BaseClasses.MVC;
using Sitecore.Data.Items;
using System.Collections.Generic;

namespace Feature.GlobalSearch.Models
{
    public class GlobalSearch : BaseModel
    {
        public List<Item> Results { get; set; }

        public string SearchBoxPlaceholderText { get; set; }

        public GlobalSearch(Item item) : base(item)
        {
        }
    }
}