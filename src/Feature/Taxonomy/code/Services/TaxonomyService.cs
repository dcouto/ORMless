using Foundation.BaseClasses.Services;
using Sitecore.Mvc.Presentation;

namespace Feature.Taxonomy.Services
{
    public class TaxonomyService : BaseService, ITaxonomyService
    {
        public Models.Taxonomy GetTaxonomy(RenderingContext renderingContext)
        {
            var model = new Models.Taxonomy(GetDatasource(renderingContext, Taxonomy_Constants.TemplateId));

            return model;
        }
    }
}