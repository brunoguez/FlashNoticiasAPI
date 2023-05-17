using Microsoft.AspNetCore.Mvc;

namespace FlashNoticiasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "GetUser")]
        public IEnumerable<WeatherForecast> Get()
        {
        }
    }
}
