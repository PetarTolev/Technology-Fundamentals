namespace Library.Controllers
{
    using Library.Models;
    using Library.Data;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var allBooks = db.Books.ToList();
                return View(allBooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string author, double price, Book book)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || price == 0)
            {
                return RedirectToAction("Index");
            }

            book.Title = title;
            book.Author = author;
            book.Price = price;

            using (var db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(t => t.Id == id);
                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(t => t.Id == book.Id);
                bookToEdit.Title = book.Title;
                bookToEdit.Author = book.Author;
                bookToEdit.Price = book.Price;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                Book bookToDelete = db.Books.FirstOrDefault(t => t.Id == id);
                if (bookToDelete == null)
                {
                    RedirectToAction("Index");
                }
                return View(bookToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToDelete = book;
                if (bookToDelete == null)
                {
                    RedirectToAction("Index");
                }
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}