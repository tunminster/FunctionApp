using System.IO;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;

//[assembly: FunctionsStartup(typeof(FunctionApp1.Program))]

namespace FunctionApp1
{
    public class Program 
    {
        // public override void Configure(IFunctionsHostBuilder builder)
		// {
		// 	var hostingEnvironment = new HostingEnvironment
		// 	{
		// 		ContentRootPath = Directory.GetCurrentDirectory(),
		// 		ApplicationName = "Operation Functions",
		// 		EnvironmentName = "Ring0"
		// 	};

		// 	builder.Services.Add(new ServiceDescriptor(typeof(IHostEnvironment), hostingEnvironment));	
		// }
    }
}