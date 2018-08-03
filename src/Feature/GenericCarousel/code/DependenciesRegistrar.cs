using ORMless.Feature.GenericCarousel.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using ORMless.Foundation.DependencyInjection;

namespace ORMless.Feature.GenericCarousel
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGenericCarouselService, GenericCarouselService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}