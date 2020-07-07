using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.Kernel
{
    public static class ApplicationServicesExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			serviceCollection.AddLogging();
			serviceCollection.AddHttpClient();
			serviceCollection.AddSingleton(configuration);
			
			

			return serviceCollection;
		}
	}
}