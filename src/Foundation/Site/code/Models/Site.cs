using Foundation.BaseClasses.MVC;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Foundation.Site.Models
{
    public class Site : BaseModel
    {
        public Site(Item item) : base(item)
        {
            
        }

        public Item GetDefaultGlobalHeader()
        {
            var field = (LookupField)SitecoreItem.Fields[_Site_Constants.Default_Global_Header_FieldName];

            return field?.TargetItem;
        }
    }
}