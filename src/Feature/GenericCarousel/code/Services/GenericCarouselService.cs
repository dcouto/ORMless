using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.Linq;

namespace ORMless.Feature.GenericCarousel.Services
{
    public class GenericCarouselService : IGenericCarouselService
    {
        public IEnumerable<Item> GetGenericCarouselSlides(RenderingContext renderingContext)
        {
            var rendering = renderingContext?.Rendering;

            var datasourceId = rendering?.DataSource;

            if (string.IsNullOrWhiteSpace(datasourceId))
            {
                return null;
            }

            var datasource = Sitecore.Context.Database.GetItem(datasourceId);

            if (datasource.TemplateID.Guid != Generic_Carousel_Constants.TemplateId)
            {
                return null;
            }

            return datasource.Children.Where(i => i.TemplateID.Guid == Generic_Carousel_Slide_Constants.TemplateId);
        }
    }
}