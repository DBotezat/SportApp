#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportApp.Models;


namespace SportApp.Controllers
{
    public class UserRespondesController : Controller
    {
        private readonly MyContext _context;

        public UserRespondesController(MyContext context)
        {
            _context = context;
        }

        // GET: UserRespondes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserRespondes.ToListAsync());
        }

        // GET: UserRespondes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRespondes = await _context.UserRespondes
                .FirstOrDefaultAsync(m => m. Id == id);
            if (userRespondes == null)
            {
                return NotFound();
            }

            return View(userRespondes);
        }

        // GET: UserRespondes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserRespondes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserRespondes userRespondes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRespondes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userRespondes);
        }

        // GET: UserRespondes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRespondes = await _context.UserRespondes.FindAsync(id);
            if (userRespondes == null)
            {
                return NotFound();
            }
            return View(userRespondes);
        }

        // POST: UserRespondes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,UserRespondes userRespondes)
        {

            _context.Update(userRespondes);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    

        // GET: UserRespondes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRespondes = await _context.UserRespondes
                .FirstOrDefaultAsync(m => m. Id == id);
            if (userRespondes == null)
            {
                return NotFound();
            }

            return View(userRespondes);
        }

        // POST: UserRespondes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRespondes = await _context.UserRespondes.FindAsync(id);
            _context.UserRespondes.Remove(userRespondes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRespondesExists(int id)
        {
            return _context.UserRespondes.Any(e => e. Id == id);
        }
    }
}
