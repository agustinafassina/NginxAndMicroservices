using System;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ApiTwo.Controllers
{
    [ApiController]
    [Route("api/v2/[controller]")]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            var sourceExternalService = "https://restcountries.com/v3.1/all?fields=name,flags";
            var request = new RestRequest(sourceExternalService);
            var client = new RestClient();
            var response = client.ExecuteAsync(request);

            return response.Result.Content;
        }
    }
}
