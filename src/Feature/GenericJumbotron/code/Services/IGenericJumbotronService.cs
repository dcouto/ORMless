using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.GenericJumbotron.Services
{
    public interface IGenericJumbotronService
    {
        Models.GenericJumbotron GetGenericJumbotron(RenderingContext renderingContext, Item contextItem);
    }
}
