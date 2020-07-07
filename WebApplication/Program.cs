using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(WebApplication.Program))]
namespace WebApplication
{
    public class Program : FunctionsStartup
    {
        
        public override void Configure(IFunctionsHostBuilder builder)
		{
			var hostingEnvironment = new HostingEnvironment
			{
				ContentRootPath = Directory.GetCurrentDirectory(),
				ApplicationName = "Operation Functions",
				EnvironmentName = "dev"
			};

			builder.Services.Add(new ServiceDescriptor(typeof(IHostEnvironment), hostingEnvironment));

			
		}
        
        
    }
}