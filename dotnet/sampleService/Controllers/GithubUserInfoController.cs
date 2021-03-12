using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sampleService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GithubUserInfoController : ControllerBase
    {
        private static readonly string URL = "https://api.github.com/users/";
        static HttpClient client = new HttpClient();

        private readonly ILogger<GithubUserInfoController> _logger;

        public GithubUserInfoController(ILogger<GithubUserInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<GithubUserInfo> Get(string name)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Saisyam", "1.0"));
            try
            {
                return await client.GetFromJsonAsync<GithubUserInfo>(URL+name);
            }

            catch (HttpRequestException) // Non success
            {
                Console.WriteLine("An error occurred.");
            }
            catch (NotSupportedException) // When content type is not valid
            {
                Console.WriteLine("The content type is not supported.");
            }
            catch (JsonException) // Invalid JSON
            {
                Console.WriteLine("Invalid JSON.");
            }
            return null;
        }
    }
}
