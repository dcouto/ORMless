using ORMless.Feature.GenericCallout.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using ORMless.Foundation.DependencyInjection;

namespace ORMless.Feature.GenericCallout
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGenericCalloutService, GenericCalloutService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}