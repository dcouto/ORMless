using {{layer}}.{{name}}.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection;

namespace {{layer}}.{{name}}
{
    public class DependenciesRegistrar : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<I{{name}}Service, {{name}}Service>();

            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}