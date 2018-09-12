using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Data.Managers;
using Sitecore.Links;
using System;

namespace Foundation.Extensions
{
    public static class ItemExtensions
    {
        public static bool IsOrInherits(this Item item, Guid templateGuid)
        {
            var templateId = ID.Parse(templateGuid);

            if(item.TemplateID == templateId)
            {
                return true;
            }

            var templateItem = TemplateManager.GetTemplate(item);

            if (templateItem == null)
            {
                return false;
            }

            return templateItem.DescendsFrom(templateId);
        }

        public static string GetUrl(this Item item, UrlOptions options = null)
        {
            if(options != null)
            {
                return LinkManager.GetItemUrl(item, options);
            }

            return LinkManager.GetItemUrl(item);
        }
    }
}