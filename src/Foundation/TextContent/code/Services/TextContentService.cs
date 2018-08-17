using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Foundation.TextContent.Services
{
    public class TextContentService : BaseService, ITextContentService
    {
        public Models.TextContent GetTextContent(RenderingContext renderingContext)
        {
            var model = new Models.TextContent(GetDatasource(renderingContext, Text_Content_Constants.TemplateId));

            return model;
        }
    }
}