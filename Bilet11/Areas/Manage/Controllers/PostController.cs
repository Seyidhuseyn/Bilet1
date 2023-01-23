using Bilet11.DAL;
using Bilet11.Models;
using Bilet11.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Bilet11.Utilies.Extension;

namespace Bilet11.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PostController : Controller
    {
        readonly AppDbContext _context;
        readonly IWebHostEnvironment _env;

        public PostController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Posts.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePostVM postVM)
        {
            IFormFile file = postVM.Image;
            string result = file?.CheckValidate("Image/", 300);
            if (result.Length>0)
            {
                ModelState.AddModelError("ImageUrl", result);
            }
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            using (var stream = new FileStream(Path.Combine(_env.WebRootPath, "images", "post", fileName), FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Post newpost = new Post
            {
                PrimaryTitle = postVM.PrimaryTitle,
                Description = postVM.Description,
                Date = postVM.Date,
                ImageUrl = fileName
            };
            _context.Posts.Add(newpost);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
