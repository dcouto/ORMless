using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using Foundation.Extensions;

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

        /// <summary>
        /// Returns the DataSource from the renderingContext object if it's set and it's template matches the expectedTemplateId.
        /// Otherwise, returns the contextItem if it's set and it's template matches the expectedTemplateId.
        /// </summary>
        /// <param name="renderingContext"></param>
        /// <param name="contextItem"></param>
        /// <param name="expectedTemplateId"></param>
        /// <returns></returns>
        protected Item GetDatasource(RenderingContext renderingContext, Item contextItem, Guid expectedTemplateId)
        {
            var mvcRendering = GetSitecoreMvcRendering(renderingContext);

            var datasourceId = mvcRendering.DataSource;

            if (!string.IsNullOrWhiteSpace(datasourceId))
            {
                var datasource = Sitecore.Context.Database.GetItem(datasourceId);

                if (datasource != null && datasource.TemplateID.Guid == expectedTemplateId)
                {
                    return datasource;
                }
            }
            else if(contextItem.IsOrInherits(expectedTemplateId))
            {
                return contextItem;
            }

            return null;
        }

        protected RenderingParameters GetRenderingParameters(RenderingContext renderingContext)
        {
            var parameters = GetSitecoreMvcRendering(renderingContext).Parameters;

            return parameters ?? throw new Exception("renderingContext.Rendering.Parameters is null.");
        }
    }
}