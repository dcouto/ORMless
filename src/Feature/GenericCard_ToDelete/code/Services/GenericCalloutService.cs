using Sitecore.Mvc.Presentation;

namespace ORMless.Feature.GenericCallout.Services
{
    public class GenericCalloutService : IGenericCalloutService
    {
        public Models.GenericCallout GetGenericCallout(RenderingContext renderingContext)
        {
            if(renderingContext == null)
            {
                return null;
            }

            var rendering = renderingContext.Rendering;

            if (rendering == null)
            {
                return null;
            }

            var datasourceId = rendering.DataSource;

            if (string.IsNullOrWhiteSpace(datasourceId))
            {
                return null;
            }

            var datasource = Sitecore.Context.Database.GetItem(datasourceId);

            if (datasource.TemplateID.Guid != Generic_Callout_Constants.TemplateId)
            {
                return null;
            }

            var gc = new Models.GenericCallout(datasource);

            var parameters = rendering.Parameters;

            if (parameters != null)
            {
                gc.BackgroundColor = parameters[Generic_Callout_Rendering_Parameters_Constants.Background_Color_FieldName];
            }

            return gc;
        }
    }
}