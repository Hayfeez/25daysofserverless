using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace ServerlessDreidel
{
    public static class SpinDreidel
    {
        [FunctionName("SpinDreidel")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            //log.Info("C# HTTP trigger function processed a request.");

            // נ (Nun), ג (Gimmel), ה (Hay), or ש (Shin)
            string[] options = { "נ", "ג", "ה", "ש" }; //new string[4];
            var rnd = new Random().Next(4);

            return req.CreateResponse(HttpStatusCode.OK, options[rnd]);
        }
    }
}
