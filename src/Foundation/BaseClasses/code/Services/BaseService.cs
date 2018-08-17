using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;

namespace Foundation.BaseClasses.Services
{
    public class BaseService
    {
        private Rendering _sitecoreMvcRendering;
        private Rendering GetSitecoreMvcRendering(RenderingContext renderingContext)
        {
            if(_sitecoreMvcRendering == null)
            {
                if (renderingContext == null)
                {
                    throw new ArgumentNullException("renderingContext");
                }

                _sitecoreMvcRendering = renderingContext.Rendering;

                if (_sitecoreMvcRendering == null)
                {
                    throw new Exception("renderingContext.Rendering is null.");
                }
            }

            return _sitecoreMvcRendering;
        }

        protected Item GetDatasource(RenderingContext renderingContext, Guid expectedTemplateId)
        {
            var datasourceId = GetSitecoreMvcRendering(renderingContext).DataSource;

            if (string.IsNullOrWhiteSpace(datasourceId))
            {
                throw new Exception("rendering.DataSource is null.");
            }

            var datasource = Sitecore.Context.Database.GetItem(datasourceId);

            if (datasource == null)
            {
                throw new Exception(string.Format("Unable to find item with ID {0}.", datasourceId));
            }

            if (datasource.TemplateID.Guid != expectedTemplateId)
            {
                throw new Exception("Item template does not match expectedTemplateId.");
            }

            return datasource;
        }

        protected RenderingParameters GetRenderingParameters(RenderingContext renderingContext)
        {
            var parameters = GetSitecoreMvcRendering(renderingContext).Parameters;

            return parameters ?? throw new Exception("renderingContext.Rendering.Parameters is null.");
        }
    }
}