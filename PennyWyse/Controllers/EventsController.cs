using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PennyWyse.Data;
using PennyWyse.Models;
using PennyWyse.Models.ViewModels;
using Remotion.Linq.Clauses;

namespace PennyWyse.Controllers
{
    public class EventsController : Controller
    {
        //setting private reference to the I.D.F usermanager
        private readonly UserManager<User> _userManager;

        private readonly ApplicationDbContext _context;

        //Getting the current user in the system (whoever is logged in)
        public Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public EventsController(ApplicationDbContext context,
            UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;

        }


        // GET: Events
        [Authorize]
        public async Task<IActionResult> Index(HomeIndexViewModel UserChoice, int? searchId)
        {   
            

            if (searchId == null)
            {
                searchId = 0;
                var PriceObject = _context.Events
                    .Where(e => e.Price <= searchId);


                return View(PriceObject);
            }
            else
            {
                var PriceObject = _context.Events
                    .Where(e => e.Price <= searchId);


                return View(PriceObject);
            }
        }

        // This method ties to the search bar on the landing page that will search via the price only. 
        //public async Task<IActionResult> IndexPrice(int? UserPrice)
        //{
        //    var PriceObject = _context.Events
        //        .Where(e => e.Price < UserPrice);

        //    return View(PriceObject);

        //}


        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,StartDate,LegalAge,FamilyEvent,Description,InfoURL,ImageURL,City,State,EventType,CreatorId")] Event CreateEvent, int? searchId)
        {

            ModelState.Remove("User");
            ModelState.Remove("UserId");

            User CurUser = await GetCurrentUserAsync();
            CreateEvent.User = CurUser;
            CreateEvent.UserId = CurUser.Id;
            CreateEvent.CreatorId = CurUser.Id;


            if (ModelState.IsValid)
            {
                
                _context.Add(CreateEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","UserEvents", new {searchId});
            }
            return View(CreateEvent);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventId,Name,Price,StartDate,LegalAge,FamilyEvent,Description,InfoURL,ImageURL,City,State,EventType,CreatorId")] Event @event, int searchId)
        {

            if (id != @event.EventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    User CurUser = await GetCurrentUserAsync();
                    @event.User = CurUser;
                    @event.UserId = CurUser.Id;
                    @event.CreatorId = CurUser.Id;
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.EventId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index","UserEvents", new {searchId});
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }

    }
}
