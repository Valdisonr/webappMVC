using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webappMVC;

namespace webappMVC.Controllers
{
    public class ColaboradorsController : Controller
    {
        private readonly estoquelsContext _context;

        public ColaboradorsController(estoquelsContext context)
        {
            _context = context;
        }

        // GET: Colaboradors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Colaboradors.ToListAsync());
        }

        // GET: Colaboradors/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaboradors
                .FirstOrDefaultAsync(m => m.Idcolab == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return View(colaborador);
        }

        // GET: Colaboradors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Colaboradors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idcolab,Id,Nome,Identificador,Empresa,Aceite,Datacad")] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(colaborador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(colaborador);
        }

        // GET: Colaboradors/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaboradors.FindAsync(id);
            if (colaborador == null)
            {
                return NotFound();
            }
            return View(colaborador);
        }

        // POST: Colaboradors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Idcolab,Id,Nome,Identificador,Empresa,Aceite,Datacad")] Colaborador colaborador)
        {
            if (id != colaborador.Idcolab)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(colaborador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColaboradorExists(colaborador.Idcolab))
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
            return View(colaborador);
        }

        // GET: Colaboradors/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var colaborador = await _context.Colaboradors
                .FirstOrDefaultAsync(m => m.Idcolab == id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return View(colaborador);
        }

        // POST: Colaboradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var colaborador = await _context.Colaboradors.FindAsync(id);
            _context.Colaboradors.Remove(colaborador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColaboradorExists(long id)
        {
            return _context.Colaboradors.Any(e => e.Idcolab == id);
        }
    }
}
