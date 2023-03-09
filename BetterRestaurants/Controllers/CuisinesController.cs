using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BetterRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BetterRestaurants.Controllers
{
    public class CuisinesController : Controller
    {
        private readonly BetterRestaurantContext _db;

        public CuisinesController(BetterRestaurantContext db)
        {
            _db = db;
        }
        
        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisines.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cuisine newCuisine)
        {
            _db.Cuisines.Add(newCuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}