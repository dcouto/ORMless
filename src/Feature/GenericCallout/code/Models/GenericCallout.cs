using Sitecore.Data.Items;

namespace ORMless.Feature.GenericCallout.Models
{
    public class GenericCallout
    {
        public Item InnerItem { get; private set; }
        public string BackgroundColor { get; set; }

        public GenericCallout(Item innerItem)
        {
            InnerItem = innerItem;
        }
    }
}