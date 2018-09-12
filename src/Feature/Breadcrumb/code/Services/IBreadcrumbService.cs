using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Feature.Breadcrumb.Services
{
    public interface IBreadcrumbService
    {
        Models.Breadcrumb GetBreadcrumb(RenderingContext renderingContext, Item contextItem);
    }
}
