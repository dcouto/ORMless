using Feature.Site.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.Site
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISiteService, SiteService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}