using Sitecore.Data.Items;
using System.Collections.Generic;

namespace ORMless.Feature.GenericCarousel.Models
{
    public class GenericCarousel
    {
        public IEnumerable<Item> CarouselSlides { get; set; }
    }
}