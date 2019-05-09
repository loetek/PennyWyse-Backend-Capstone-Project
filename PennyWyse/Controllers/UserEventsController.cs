using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PennyWyse.Data;
using PennyWyse.Models;

namespace PennyWyse.Controllers
{
    public class UserEventsController : Controller
    {
        private readonly UserManager<User> _userManager;

        private readonly ApplicationDbContext _context;

        public UserEventsController(ApplicationDbContext context,
            UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        private Task<User> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: UserEvents
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();

            var EventList = _context.UserEvents.Include(e => e.Event)
                .Include(e => e.User)
                .Where(ue => ue.UserId == user.Id)
                .ToList();

            if (EventList == null)
            {
                return NotFound();
            }

            return View(EventList);
        }

        // GET: UserEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEvent = await _context.UserEvents
                .Include(u => u.Event)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserEventId == id);
            if (userEvent == null)
            {
                return NotFound();
            }

            return View(userEvent);
        }

        // GET: UserEvents/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: UserEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserEventId,UserId,EventId")] UserEvent userEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "Name", userEvent.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userEvent.UserId);
            return View(userEvent);
        }

        // GET: UserEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEvent = await _context.UserEvents.FindAsync(id);
            if (userEvent == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "Name", userEvent.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userEvent.UserId);
            return View(userEvent);
        }

        // POST: UserEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserEventId,UserId,EventId")] UserEvent userEvent)
        {
            if (id != userEvent.UserEventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserEventExists(userEvent.UserEventId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "Name", userEvent.EventId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userEvent.UserId);
            return View(userEvent);
        }

        // GET: UserEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userEvent = await _context.UserEvents
                .Include(u => u.Event)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserEventId == id);
            if (userEvent == null)
            {
                return NotFound();
            }

            return View(userEvent);
        }

        // POST: UserEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userEvent = await _context.UserEvents.FindAsync(id);
            _context.UserEvents.Remove(userEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserEventExists(int id)
        {
            return _context.UserEvents.Any(e => e.UserEventId == id);
        }


        //This little piece o'magic will display current user's list/index.

        public async Task<IActionResult> UserEventsList()
        {

            var user = await GetCurrentUserAsync();

            var EventList = _context.UserEvents.Include(e => e.Event)
                .Include(e => e.User)
                .Where(ue => ue.UserId == user.Id)
                .ToList();

            if (EventList == null)
            {
                return NotFound();
            }

            return View(EventList);
        }





    }
}
