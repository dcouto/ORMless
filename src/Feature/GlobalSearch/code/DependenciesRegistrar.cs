using Feature.GlobalSearch.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.GlobalSearch
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGlobalSearchService, GlobalSearchService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}