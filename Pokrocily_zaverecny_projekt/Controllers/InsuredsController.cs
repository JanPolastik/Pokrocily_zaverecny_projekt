﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Pokrocily_zaverecny_projekt.Data;
using Pokrocily_zaverecny_projekt.Models;

namespace Pokrocily_zaverecny_projekt.Controllers
{
    [Authorize(Roles="admin")]
    public class InsuredsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InsuredsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Insureds
        public async Task<IActionResult> Index()
        {
           
              return _context.Insured != null ? 
                          View(await _context.Insured.Include(p => p.Insurances).ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Insured'  is null.");
        }

        // GET: Insureds/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Insured == null)
            {
                return NotFound();
            }

            var insured = await _context.Insured
                .Include(p => p.Insurances)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insured == null)
            {
                return NotFound();
            }

            return View(insured);
        }

        // GET: Insureds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insureds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Jmeno, Adresa, Prijmeni, CisloDomu, EmailInsured, Telefon, PSC, Mesto")] Insured insured)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insured);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insured);
        }

        // GET: Insureds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Insured == null)
            {
                return NotFound();
            }

            var insured = await _context.Insured.FindAsync(id);
            if (insured == null)
            {
                return NotFound();
            }
            return View(insured);
        }

        // POST: Insureds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Jmeno,Adresa,Prijmeni,CisloDomu,EmailInsured,Telefon,PSC,Mesto")] Insured insured)
        {
            if (id != insured.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insured);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsuredExists(insured.Id))
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
            return View(insured);
        }

        // GET: Insureds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Insured == null)
            {
                return NotFound();
            }

            var insured = await _context.Insured
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insured == null)
            {
                return NotFound();
            }

            return View(insured);
        }

        // POST: Insureds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Insured == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Insured'  is null.");
            }
            var insured = await _context.Insured.FindAsync(id);
            if (insured != null)
            {
                _context.Insured.Remove(insured);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsuredExists(int id)
        {
          return (_context.Insured?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        
    }
}
