namespace Forum.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Forum.Models;
    using Microsoft.EntityFrameworkCore;
    using Forum.Data;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly ForumDbContext context;

        public HomeController(ForumDbContext db)
        {
            this.context = db;
        }

        public IActionResult Index()
        {
            List<Category> categories = context
                .Categories
                .Include(c => c.Author)
                .Include(c => c.Topics)
                .ThenInclude(t => t.Author)
                .ToList();

            List<Topic> topics = context
                .Topics
                .Include(t => t.Comments)
                .ThenInclude(c => c.Author)
                .OrderByDescending(t => t.CreatedDate)
                .ThenByDescending(t => t.LastUpdatedDate)
                .ToList();

            ViewData["Categories"] = categories;

            return View(topics);
        }
    }
}
