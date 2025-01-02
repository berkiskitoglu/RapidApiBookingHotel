using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.ViewComponents
{
    public class _DefaultHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
