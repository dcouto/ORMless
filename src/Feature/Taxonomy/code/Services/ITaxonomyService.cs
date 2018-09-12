using Sitecore.Mvc.Presentation;

namespace Feature.Taxonomy.Services
{
    public interface ITaxonomyService
    {
        Models.Taxonomy GetTaxonomy(RenderingContext renderingContext);
    }
}
