using Feature.Taxonomy.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.Taxonomy
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITaxonomyService, TaxonomyService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}