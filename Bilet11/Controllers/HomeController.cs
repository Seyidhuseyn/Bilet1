using Bilet11.DAL;
using Bilet11.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Bilet11.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Posts = _context.Posts
            };
            return View(homeVM);
        }
    }
}