using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCMedicineShopProjectFinal.Data;
using MVCMedicineShopProjectFinal.Data.Model;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMedicineShopProjectFinal.Controllers
{
    public class MedicinesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMedicineService _medicineService;
        private object medicineDetails;
        private object medicine;
        private IMedicineService medicineService;

        public object MedicineDetail { get; private set; }

        public MedicinesController(ApplicationDbContext context)
        {
            _context = context;
            _medicineService = medicineService;
        }

        // GET: Medicines
        public async Task<IActionResult> Index()
        {
            int medsize = _context.Medicine.Count();
            ViewBag.medcount = medsize;
            return View(await _context.Medicine.ToListAsync());
        }

        // GET: Medicines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //    var medicine = await _context.Medicine
            //        .FirstOrDefaultAsync(m => m.ID == id);
            //    if (medicine == null)
            //    {
            //        return NotFound();
            //    }

            //    return View(medicine);
            //}


             _= await _medicineService.GetMedicineById(id);
            _= await _medicineService.GetMedicineDetailsById(id);

            ViewData["MedicineId"] = id;   //Used ViewData to pass data from controller to view

            if (this.medicine == null || medicineDetails == null)
            {
                return base.NotFound();
            }

            MedicineDetailViewModel medicineDetailViewModel = new MedicineDetailViewModel();
            MedicineDetailViewModel.Medicine = this.medicine;
            MedicineDetailViewModel.MedicineDetail = medicineDetails;

            return View(medicineDetailViewModel);
        }


        // GET: Medicines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medicines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicineID,Name,Quantity,Description,MedicineCode,Img,Use_in_case,Contradication,Price")] Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicine);
        }

        // GET: Medicines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
              _ = await _medicineService.GetMedicineById(id);
               _ = await _medicineService.GetMedicineDetailsById(id);
            Medicine medicine = await _context.Medicine.FindAsync(id);
            if (MedicineDetail != null)
            {
                _ = await _medicineService.GetMedicineById(id);
                _ = await _medicineService.GetMedicineDetailsById(id);

                return View(model: MedicineDetail);
            }
            return NotFound();
        }



        // POST: Medicines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicineID,Name,Quantity,Description,MedicineCode,Use_in_case,Contradication,Price")] Medicine medicine)
        {
            if (id != medicine.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(medicine);
                    //await _context.SaveChangesAsync();
                    return MedicineDetailViewModel;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineExists(medicine.ID))
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

            MedicineDetailViewModel medicineDetailViewModel = new MedicineDetailViewModel();
            medicineDetailViewModel.Medicine = medicine;
            medicineDetailViewModel.MedicineDetails = medicineDetails;
            return View(medicineDetailViewModel);

        }

        // GET: Medicines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


             _= await _medicineService.GetMedicineById(id);

            if (medicine != null)
            {
                return View(medicine);
            }
            return NotFound();
        }

        // POST: Medicines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Medicine medicine = await _context.Medicine.FindAsync(id);
            _context.Medicine.Remove(medicine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineExists(int id)
        {
            // return _context.Medicine.Any(e => e.ID == id);
            return _medicineService.MedicineExist(id);
        }
    }

    internal class MedicineDetailViewModel
    {
        public static object Medicine { get; internal set; }
        public static object MedicineDetail { get; internal set; }
        public object MedicineDetails { get; internal set; }
    }

    internal interface IMedicineService
    {
        Task GetMedicineById(int? id);
        Task GetMedicineDetailsById(int? id);
        bool MedicineExist(int id);
    }
}
