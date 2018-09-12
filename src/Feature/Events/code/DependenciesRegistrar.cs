using Feature.Events.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Feature.Events
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEventsService, EventsService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}