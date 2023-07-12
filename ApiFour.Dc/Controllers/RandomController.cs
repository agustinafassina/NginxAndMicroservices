using System;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ApiFour.Controllers
{
    [ApiController]
    [Route("api/v4/[controller]")]
    public class RandomController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            var sourceExternalService = "https://random-data-api.com/api/v2/users?size=2&is_xml=true";
            var request = new RestRequest(sourceExternalService);
            var client = new RestClient();
            var response = client.ExecuteAsync(request);

            return response.Result.Content;
        }
    }
}
