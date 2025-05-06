using Microsoft.AspNetCore.Mvc;

namespace BlazorCRUD.API.Controllers
{
    public class Std_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
