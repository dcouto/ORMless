using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.DatedContent.Services
{
    public class DatedContentService : BaseService, IDatedContentService
    {
        public Models.DatedContent GetDatedContent(RenderingContext renderingContext)
        {
            var model = new Models.DatedContent(GetDatasource(renderingContext, Dated_Content_Constants.TemplateId));

            return model;
        }
    }
}