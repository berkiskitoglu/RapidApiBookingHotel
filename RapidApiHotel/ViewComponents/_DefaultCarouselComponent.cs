using Microsoft.AspNetCore.Mvc;

namespace RapidApiHotel.ViewComponents
{
    public class _DefaultCarouselComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
