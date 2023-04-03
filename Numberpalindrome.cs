using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class Swapping
    {
        [FunctionName("Swapping")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route =null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int a=10;
            int b=20;
            a=a+b;
            b=a-b;
            a=a-b;
            var message = String.Format($" The numbers are swapped a: {a}, b: {b}");
            //string responseMessage = "The numbers are swapped {a},{b}";
            return new OkObjectResult(message);
        }
    }
}
