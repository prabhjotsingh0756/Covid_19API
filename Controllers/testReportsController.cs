using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Covid_19.Data;
using Covid_19.Models;

namespace Covid_19.Controllers
{
    public class testReportsController : Controller
    {
        private readonly Covid_19Context _context;

        public testReportsController(Covid_19Context context)
        {
            _context = context;
        }

        // GET: testReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.testReport.ToListAsync());
        }

        // GET: testReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testReport = await _context.testReport
                .FirstOrDefaultAsync(m => m.id == id);
            if (testReport == null)
            {
                return NotFound();
            }

            return View(testReport);
        }

        // GET: testReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: testReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name,Email,Contact,Report,TestDate")] testReport testReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testReport);
        }

        // GET: testReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testReport = await _context.testReport.FindAsync(id);
            if (testReport == null)
            {
                return NotFound();
            }
            return View(testReport);
        }

        // POST: testReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Email,Contact,Report,TestDate")] testReport testReport)
        {
            if (id != testReport.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!testReportExists(testReport.id))
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
            return View(testReport);
        }

        // GET: testReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testReport = await _context.testReport
                .FirstOrDefaultAsync(m => m.id == id);
            if (testReport == null)
            {
                return NotFound();
            }

            return View(testReport);
        }

        // POST: testReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testReport = await _context.testReport.FindAsync(id);
            _context.testReport.Remove(testReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool testReportExists(int id)
        {
            return _context.testReport.Any(e => e.id == id);
        }
    }
}
