using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCMedicineShopProjectFinal.Data;
using MVCMedicineShopProjectFinal.Data.Model;

namespace MVCMedicineShopProjectFinal.Controllers
{
    public class Medical_EnterpriserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Medical_EnterpriserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Medical_Enterpriser
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medical_Enterpriser.ToListAsync());
        }

        // GET: Medical_Enterpriser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medical_Enterpriser medical_Enterpriser = await _context.Medical_Enterpriser
                .FirstOrDefaultAsync(m => m.ID == id);
            if (medical_Enterpriser == null)
            {
                return NotFound();
            }

            return View(medical_Enterpriser);
        }

        // GET: Medical_Enterpriser/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medical_Enterpriser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MedName,MedDescription,MedAddress,Time_at")] Medical_Enterpriser medical_Enterpriser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medical_Enterpriser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medical_Enterpriser);
        }

        // GET: Medical_Enterpriser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medical_Enterpriser medical_Enterpriser = await _context.Medical_Enterpriser.FindAsync(id);
            if (medical_Enterpriser == null)
            {
                return NotFound();
            }
            return View(medical_Enterpriser);
        }

        // POST: Medical_Enterpriser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MedName,MedDescription,MedAddress,Time_at")] Medical_Enterpriser medical_Enterpriser)
        {
            if (id != medical_Enterpriser.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medical_Enterpriser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Medical_EnterpriserExists(medical_Enterpriser.ID))
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
            return View(medical_Enterpriser);
        }

        // GET: Medical_Enterpriser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medical_Enterpriser medical_Enterpriser = await _context.Medical_Enterpriser
                .FirstOrDefaultAsync(m => m.ID == id);
            if (medical_Enterpriser == null)
            {
                return NotFound();
            }

            return View(medical_Enterpriser);
        }

        // POST: Medical_Enterpriser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Medical_Enterpriser medical_Enterpriser = await _context.Medical_Enterpriser.FindAsync(id);
            _context.Medical_Enterpriser.Remove(medical_Enterpriser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Medical_EnterpriserExists(int id)
        {
            return _context.Medical_Enterpriser.Any(e => e.ID == id);
        }
    }
}
