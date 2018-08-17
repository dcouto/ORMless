using Feature.GenericCard.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.GenericCard
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGenericCardService, GenericCardService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}