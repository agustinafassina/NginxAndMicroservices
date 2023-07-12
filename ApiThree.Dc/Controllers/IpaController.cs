using System;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ApiThree.Controllers
{
    [ApiController]
    [Route("api/v3/[controller]")]
    public class IpaController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            var sourceExternalService = "https://ipapi.co/json";
            var request = new RestRequest(sourceExternalService);
            var client = new RestClient();
            var response = client.ExecuteAsync(request);

            return response.Result.Content;
        }
    }
}
