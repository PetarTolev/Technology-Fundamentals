using System.Linq;

namespace Forum.Controllers
{
    using Forum.Models;
    using Microsoft.AspNetCore.Authorization;
    using Forum.Data;
    using Microsoft.AspNetCore.Mvc;

    public class CategoryController : Controller
    {
        private readonly ForumDbContext context;

        public CategoryController(ForumDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Category category)
        {
            string authorId = context.Users
                .Where(u => u.UserName == this.User.Identity.Name)
                .First()
                .Id;
            category.AuthorId = authorId;

            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(category);
        }


    }
}