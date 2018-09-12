using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Foundation.SharedContent.Services
{
    public class SharedContentService : BaseService, ISharedContentService
    {
        public Models.SharedContent GetSharedContent(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.SharedContent(GetDatasource(renderingContext, contextItem, Shared_Content_Folder_Constants.TemplateId));

            return model;
        }
    }
}