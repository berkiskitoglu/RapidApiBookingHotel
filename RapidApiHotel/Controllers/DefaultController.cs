using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.Controllers
{
    public class DefaultController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
