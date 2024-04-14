using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlyManager01.Data;
using FlyManager01.Models;

namespace FlyManager01.Controllers
{
    public class FlightsVController : Controller
    {
        private readonly FlyManagerData _context;

        public FlightsVController(FlyManagerData context)
        {
            _context = context;
        }

        // GET: FlightsV
        public async Task<IActionResult> Index()
        {
              return _context.Flights != null ? 
                          View(await _context.Flights.ToListAsync()) :
                          Problem("Entity set 'FlyManagerData.Flights'  is null.");
        }

        // GET: FlightsV/Details/5
        public async Task<IActionResult> InformationFlght(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flights == null)
            {
                return NotFound();
            }

            return View(flights);
        }

        // GET: FlightsV/Create
        public IActionResult AddFlight()
        {
            return View();
        }

        // POST: FlightsV/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFlight([Bind("Id,FromDate,FromTime,ToDate,ToTime," +
            "TypePlane,NumberPlane,FromCity,ToCity,FirstPilot,BuisnessClass,PriceBuisness," +
            "OrdinaryTicket,Ticket")] Flights flights)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flights);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(flights);
        }

        // POST: FlightsV/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    }
}
