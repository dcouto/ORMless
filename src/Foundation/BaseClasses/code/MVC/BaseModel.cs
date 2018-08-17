using Sitecore.Data.Items;

namespace Foundation.BaseClasses.MVC
{
    public class BaseModel
    {
        public Item SitecoreItem { get; private set; }

        public BaseModel(Item item)
        {
            SitecoreItem = item;
        }
    }
}