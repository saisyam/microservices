using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sampleService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GithubUserInfoController : ControllerBase
    {
        //private static readonly string URL = "https://api.github.com/users/saisyam";
    

        private readonly ILogger<GithubUserInfoController> _logger;

        public GithubUserInfoController(ILogger<GithubUserInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public GithubUserInfo Get()
        {
            return new GithubUserInfo {
                PublicRepos = 46,
                Followers = 4,
                Name = "Saisyam",
                Company = "Mobigesture",
                Location = "Hyderabad",
                Bio = "I am a Software Architect working and living in Hyderabad, India."

            };
        }
    }
}
