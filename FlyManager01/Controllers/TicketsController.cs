using FlyManager01.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlyManager01.Controllers
{
    public class TicketsController : Controller
    {
        private readonly FlyManagerData _context;

        public TicketsController(FlyManagerData context)
        {
            _context = context;
        }
        public IActionResult InformationFlght()
        {
            return View();
        }
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
