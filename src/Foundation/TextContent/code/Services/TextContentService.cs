using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;

namespace Foundation.TextContent.Services
{
    public class TextContentService : BaseService, ITextContentService
    {
        public Models.TextContent GetTextContent(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.TextContent(GetDatasource(renderingContext, contextItem, Guid.Empty));

            return model;
        }
    }
}