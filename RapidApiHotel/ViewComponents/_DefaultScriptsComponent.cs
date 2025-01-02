using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.ViewComponents
{
    public class _DefaultScriptsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
