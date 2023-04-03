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
    public static class HttpTrigger1
    {
    [FunctionName("HttpTrigger1")]
        public static IActionResult Run(
       [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "products/{category:alpha}/{id:int?}")] HttpRequest req,
       string category, int? id, ILogger log)
      {
    log.LogInformation("C# HTTP trigger function processed a request.");

    var message = String.Format($"Category: {category}, ID: {id}");
    return (ActionResult)new OkObjectResult(message);
    }
        
    }
}
