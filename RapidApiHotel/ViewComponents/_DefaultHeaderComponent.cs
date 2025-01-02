using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.ViewComponents
{
    public class _DefaultHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
