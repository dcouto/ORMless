using Foundation.Publications.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Foundation.Publications
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPublicationsService, PublicationsService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}