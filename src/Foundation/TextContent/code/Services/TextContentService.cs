using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;
using System;

namespace Foundation.TextContent.Services
{
    public class TextContentService : BaseService, ITextContentService
    {
        public Models.TextContent GetTextContent(RenderingContext renderingContext)
        {
            var model = new Models.TextContent(GetDatasource(renderingContext, Guid.Empty));

            return model;
        }
    }
}