using Feature.GlobalHeader.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.GlobalHeader
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGlobalHeaderService, GlobalHeaderService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}