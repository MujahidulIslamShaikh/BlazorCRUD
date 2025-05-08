using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuitsController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
           "apple",
           "banana",
           "mango",
           "Cherry",
           "Graps"
        };

        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }
    }
}
