using Feature.Breadcrumb.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.Breadcrumb
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBreadcrumbService, BreadcrumbService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}