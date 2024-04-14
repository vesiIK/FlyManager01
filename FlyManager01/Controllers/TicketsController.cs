using FlyManager01.Data;
using FlyManager01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlyManager01.Controllers
{
    public class TicketsController : Controller
    {
        private readonly FlyManagerData _context;
        private readonly IConfiguration _congfigoration;

        public TicketsController(FlyManagerData context, IConfiguration congfigoration)
        {
            _context = context;
            _congfigoration = congfigoration;
        }
        public IActionResult BuyedTickets()
        {
            List<Person> person = _context.Person.ToList();
            return View();
        }
        //public IActionResult BuyedTickets()
        //{

        //}

        public async Task<IActionResult> InformationFlght(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }
    }
}
