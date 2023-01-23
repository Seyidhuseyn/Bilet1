using Microsoft.AspNetCore.Mvc;

namespace Bilet11.Areas.Manage.Controllers
{
    public class DashbordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
