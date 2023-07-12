using System;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ApiOne.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PetsController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            var sourceExternalService = "https://api.publicapis.org/entries";
            var request = new RestRequest(sourceExternalService);
            var client = new RestClient();
            var response = client.ExecuteAsync(request);

            return response.Result.Content;
        }
    }
}
