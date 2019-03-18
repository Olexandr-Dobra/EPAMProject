using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstWebApp.Models;

namespace FirstWebApp.Controllers
{
    public class MarkOfTeachersController : Controller
    {
        private readonly FirstWebAppContext _context;

        public MarkOfTeachersController(FirstWebAppContext context)
        {
            _context = context;
        }

        // GET: MarkOfTeachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.MarkOfTeacher.ToListAsync());
            
        }

        // GET: MarkOfTeachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var markOfTeacher = await _context.MarkOfTeacher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (markOfTeacher == null)
            {
                return NotFound();
            }

            return View(markOfTeacher);
        }

        // GET: MarkOfTeachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarkOfTeachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mark,TeacherId,TeacherName")] MarkOfTeacher markOfTeacher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(markOfTeacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(markOfTeacher);
        }

        // GET: MarkOfTeachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var markOfTeacher = await _context.MarkOfTeacher.FindAsync(id);
            if (markOfTeacher == null)
            {
                return NotFound();
            }
            return View(markOfTeacher);
        }

        // POST: MarkOfTeachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mark,TeacherId,TeacherName")] MarkOfTeacher markOfTeacher)
        {
            if (id != markOfTeacher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(markOfTeacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkOfTeacherExists(markOfTeacher.Id))
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
            return View(markOfTeacher);
        }

        // GET: MarkOfTeachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var markOfTeacher = await _context.MarkOfTeacher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (markOfTeacher == null)
            {
                return NotFound();
            }

            return View(markOfTeacher);
        }

        // POST: MarkOfTeachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var markOfTeacher = await _context.MarkOfTeacher.FindAsync(id);
            _context.MarkOfTeacher.Remove(markOfTeacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkOfTeacherExists(int id)
        {
            return _context.MarkOfTeacher.Any(e => e.Id == id);
        }


        public double AverageMarkOfTeacher(int TeacherId) {
            var x = _context.MarkOfTeacher.Average(b => b.Mark);



            return x;
        }
    }
}
