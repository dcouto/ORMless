using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;

namespace Feature.GenericCarousel.Services
{
    public interface IGenericCarouselService
    {
        IEnumerable<Item> GetGenericCarouselSlides(RenderingContext renderingContext);
    }
}
