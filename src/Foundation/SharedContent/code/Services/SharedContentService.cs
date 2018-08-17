using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.SharedContent.Services
{
    public class SharedContentService : BaseService, ISharedContentService
    {
        public Models.SharedContent GetSharedContent(RenderingContext renderingContext)
        {
            var model = new Models.SharedContent(GetDatasource(renderingContext, Shared_Content_Folder_Constants.TemplateId));

            return model;
        }
    }
}