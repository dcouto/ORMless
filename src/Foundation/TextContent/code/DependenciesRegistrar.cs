using Foundation.TextContent.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace Foundation.TextContent
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ITextContentService, TextContentService>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}