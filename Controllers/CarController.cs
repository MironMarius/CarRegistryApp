using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRegistry.Models;

namespace CarRegistry.Controllers
{
    public class CarController : Controller
    {
        private readonly CarContext _context;

        public CarController(CarContext context)
        {
            _context = context;
        }

        // GET: Car
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }

        // GET: Car/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Car());
            else
                return View(_context.Cars.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CarId,CarBrand,CarModel,EngineCapacity,EnginePower,NumberOfCylinders")] Car car)
        {
            if (ModelState.IsValid)
            {
                if (car.CarId == 0)
                
                    _context.Add(car);
                else
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }


        // GET: Car/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var car = _context.Cars.FindAsync(id);
            _context.Cars.Remove(await car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.CarId == id);
        }
    }
}
