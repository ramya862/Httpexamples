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
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];
            string s1= name;
            string rev="";
            for(int i=s1.Length-1;i>=0;i--)
            {
             rev=rev+s1[i];
            }
            if(rev==s1)
            {
                string message="yes palindrome";
                return new OkObjectResult(message); 
            }
            else{
                string message1="not a palindrome";
                return new OkObjectResult(message1);
            }

          
        }
    }
}
