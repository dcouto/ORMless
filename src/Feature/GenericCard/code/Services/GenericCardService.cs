using Foundation.BaseClasses.Services;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.GenericCard.Services
{
    public class GenericCardService : BaseService, IGenericCardService
    {
        public Models.GenericCard GetGenericCard(RenderingContext renderingContext, Item contextItem)
        {
            var model = new Models.GenericCard(GetDatasource(renderingContext, contextItem, Generic_Card_Constants.TemplateId));

            model.BackgroundColor = GetRenderingParameters(renderingContext)[Generic_Card_Rendering_Parameters_Constants.Background_Color_FieldName];

            return model;
        }
    }
}