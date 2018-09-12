using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using Sitecore.Data.Items;

namespace Feature.Breadcrumb.Services
{
    public class BreadcrumbService : BaseService, IBreadcrumbService
    {
        public Models.Breadcrumb GetBreadcrumb(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.Breadcrumb();

            model.Items = new List<Item>();

            while(contextItem.Paths.Path != Sitecore.Context.Site.RootPath)
            {
                model.Items.Add(contextItem);

                contextItem = contextItem.Parent;
            }

            model.Items.Reverse();

            return model;
        }
    }
}