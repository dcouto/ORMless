using Foundation.SharedContent.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Foundation.SharedContent
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISharedContentService, SharedContentService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}