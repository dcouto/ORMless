using Foundation.BaseClasses.MVC;
using Sitecore.Data.Items;
using System.Collections.Generic;

namespace Feature.Events.Models
{
    public class EventsListing : BaseModel
    {
        public List<Item> UpcomingEvents { get; set; }

        public EventsListing(Item item) : base(item)
        {
        }
    }
}