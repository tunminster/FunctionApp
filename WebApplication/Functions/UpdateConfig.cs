using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace WebApplication.Functions
{
    public class UpdateConfig
    {
        [FunctionName("UpdateConfig")]
        public async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger logger)
        {
            logger.LogInformation($"UpdateConfig function triggered at {DateTimeOffset.UtcNow}");

            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var response = "OK";

            return new OkObjectResult(new { response });
        }
    }
}