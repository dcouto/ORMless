using Feature.GenericJumbotron.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.GenericJumbotron
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGenericJumbotronService, GenericJumbotronService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}