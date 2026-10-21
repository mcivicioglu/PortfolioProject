using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.Views.Shared.Components
{
    public class _DefaultHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
