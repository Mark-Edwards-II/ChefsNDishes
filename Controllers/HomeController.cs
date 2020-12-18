using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using ChefsNDishes.Context;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext _context {get;set;}

        public HomeController(HomeContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = _context.Chefs
                .Include(d => d.ChefsDishes)
                .ToList();
            return View(AllChefs);
        }
        public IActionResult AddChef()
        {
            return View();
        }
        public IActionResult CreateChef(Chef NewChef)
        {

            if(ModelState.IsValid)
            {
                _context.Chefs.Add(NewChef);
                _context.SaveChanges();
                return View("Index");
            }
            return View("AddChef");
        }
        public IActionResult Dishes()
        {
            return View();
        }
        public IActionResult AddDish()
        {
            ViewBag.Chefs = _context.Chefs.ToList();
            return View();
        }
        public IActionResult CreateDish(Dish NewDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(NewDish);
                _context.SaveChanges();
                return View("Dishes");
            }
            return View("AddDish",NewDish);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
