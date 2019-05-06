using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PennyWyse.Data;
using PennyWyse.Data.Migrations;
using PennyWyse.Models;

namespace PennyWyse.Controllers
{
    public class HomeController : Controller
    {
        //setting private reference to the I.D.F usermanager
        private readonly UserManager<User> _userManager;

        private readonly ApplicationDbContext _context;

        //Getting the current user in the system (whoever is logged in)
        public Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public HomeController(ApplicationDbContext context,
            UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        //This is a sorting method that should sort based on price and startdate. 
        public async Task<IActionResult> Index(string sortOrder, string searchString)
            {
                ViewData["PriceSortParm"] = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
                ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
                ViewData["CurrentFilter"] = searchString;
            
            var events = from e in _context.Events
                    select e;

          if (!String.IsNullOrEmpty(searchString))
                {
                    events = events.Where(e => e.Price.ToString().Contains(searchString));
                }
            switch (sortOrder)
                {
                    case "price_desc":
                        events = events.OrderByDescending(e => e.Price);
                        break;
                    case "Date":
                        events = events.OrderBy(e => e.StartDate);
                        break;
                    case "date_desc":
                        events = events.OrderByDescending(e => e.StartDate);
                        break;
                    default:
                        events = events.OrderBy(e => e.Price);
                        break;
                }
                return View(await events.AsNoTracking().ToListAsync());
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
