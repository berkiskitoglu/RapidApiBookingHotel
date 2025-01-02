using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.ViewComponents
{
    public class _DefaultServiceComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
