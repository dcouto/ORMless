using Foundation.DatedContent.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Foundation.DatedContent
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDatedContentService, DatedContentService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}