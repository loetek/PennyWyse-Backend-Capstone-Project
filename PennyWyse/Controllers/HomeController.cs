using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PennyWyse.Data.Migrations;
using PennyWyse.Models;

namespace PennyWyse.Controllers
{
    public class HomeController : Controller
    {
        //Connection to DB
        private readonly PennyWyseDB _context;

        public HomeController(PennyWyseDB context)
        {
            _context = context;
        }

        //This is a sorting method that should sort based on price and startdate. 
        public async Task<IActionResult> Index(string sortOrder)
            {
                ViewData["PriceSortParm"] = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
                ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
                // Cannot load data from eventsDB?
                //var events = from e in _context.Events
                    select e;
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
