using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entity.Entities.Fluxos.Compras;
using Infrastructure.Configurations.Data;

namespace WebFinancas.Controllers
{
    public class ItemComprasController : Controller
    {
        private readonly Contexto _context;

        public ItemComprasController(Contexto context)
        {
            _context = context;
        }

        // GET: ItemCompras
        public async Task<IActionResult> Index()
        {
            var contexto = _context.ItemCompra.Include(i => i.Compra);
            return View(await contexto.ToListAsync());
        }

        // GET: ItemCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemCompra = await _context.ItemCompra
                .Include(i => i.Compra)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemCompra == null)
            {
                return NotFound();
            }

            return View(itemCompra);
        }

        // GET: ItemCompras/Create
        public IActionResult Create()
        {
            ViewData["IdCompra"] = new SelectList(_context.Compra, "Id", "Id");
            return View();
        }

        // POST: ItemCompras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Valor,Comprado,DataCadastro,DataAlteracao,DataCompra,IdCompra,Id,Nome")] ItemCompra itemCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCompra"] = new SelectList(_context.Compra, "Id", "Id", itemCompra.IdCompra);
            return View(itemCompra);
        }

        // GET: ItemCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemCompra = await _context.ItemCompra.FindAsync(id);
            if (itemCompra == null)
            {
                return NotFound();
            }
            ViewData["IdCompra"] = new SelectList(_context.Compra, "Id", "Id", itemCompra.IdCompra);
            return View(itemCompra);
        }

        // POST: ItemCompras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Valor,Comprado,DataCadastro,DataAlteracao,DataCompra,IdCompra,Id,Nome")] ItemCompra itemCompra)
        {
            if (id != itemCompra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemCompraExists(itemCompra.Id))
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
            ViewData["IdCompra"] = new SelectList(_context.Compra, "Id", "Id", itemCompra.IdCompra);
            return View(itemCompra);
        }

        // GET: ItemCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemCompra = await _context.ItemCompra
                .Include(i => i.Compra)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemCompra == null)
            {
                return NotFound();
            }

            return View(itemCompra);
        }

        // POST: ItemCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemCompra = await _context.ItemCompra.FindAsync(id);
            _context.ItemCompra.Remove(itemCompra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemCompraExists(int id)
        {
            return _context.ItemCompra.Any(e => e.Id == id);
        }
    }
}
