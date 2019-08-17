namespace BandRegister.Controllers
{
    using BandRegister.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using BandRegister.Data;

    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContext())
            {
                var allBands = db.Bands.ToList();
                return View(allBands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string members, double honorarium, string genre)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(members) || honorarium < 1 || string.IsNullOrEmpty(genre))
            {
                return RedirectToAction("Index");
            }

            Band band = new Band
            {
                Name = name,
                Members = members,
                Honorarium = honorarium,
                Genre = genre
            };

            using (var db = new BandRegisterDbContext())
            {
                db.Bands.Add(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                var bandsToEdit = db.Bands.FirstOrDefault(t => t.Id == id);
                if (bandsToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(bandsToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new BandRegisterDbContext())
            {
                var bandToEdit = db.Bands.FirstOrDefault(t => t.Id == band.Id);

                bandToEdit.Honorarium = band.Honorarium;
                bandToEdit.Genre = band.Genre;
                bandToEdit.Members = band.Members;
                bandToEdit.Name = band.Name;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                Band bandToDelete = db.Bands.FirstOrDefault(t => t.Id == id);
                if (bandToDelete == null)
                {
                    RedirectToAction("Index");
                }
                return View(bandToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                var bandToDelete = band;
                if (bandToDelete == null)
                {
                    RedirectToAction("Index");
                }
                db.Bands.Remove(bandToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}