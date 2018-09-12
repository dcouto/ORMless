using Sitecore.Mvc.Presentation;
using Sitecore.Data.Items;

namespace Feature.GlobalHeader.Services
{
    public interface IGlobalHeaderService
    {
        Models.GlobalHeader GetGlobalHeader(RenderingContext renderingContext, Item contextItem);
    }
}
