using Foundation.NavigationLink.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Foundation.NavigationLink
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<INavigationLinkService, NavigationLinkService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}