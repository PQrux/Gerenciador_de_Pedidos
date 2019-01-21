using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadorDePedidos.Models;
using GerenciadorDePedidos.Services;

namespace GerenciadorDePedidos.Controllers
{
    public class SolicitantesController : Controller
    {
        private readonly gerenciador_de_pedidosContext _context;
        public readonly SolicitanteService _solicitanteService;

        public SolicitantesController(gerenciador_de_pedidosContext context, SolicitanteService solicitanteService)
        {
            _solicitanteService = solicitanteService;
            _context = context;
        }

        // GET: Solicitantes
        public async Task<IActionResult> Index()
        {
            var gerenciador_de_pedidosContext = _context.Solicitante.Include(s => s.MesaIdMesaNavigation);
            return View(await gerenciador_de_pedidosContext.ToListAsync());
        }

        // GET: Solicitantes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitante = await _context.Solicitante
                .Include(s => s.MesaIdMesaNavigation)
                .FirstOrDefaultAsync(m => m.IdSolicitante == id);
            if (solicitante == null)
            {
                return NotFound();
            }
            var listaPedidos = _solicitanteService.listPedidos(id);
            foreach(var pedido in listaPedidos) {
                solicitante.Pedido.Add(pedido);
            }
            solicitante.Pedido = listaPedidos;
            return View(solicitante);
        }

        // GET: Solicitantes/Create
        public IActionResult Create()
        {
            ViewData["MesaIdMesa"] = new SelectList(_context.Mesa, "IdMesa", "IdMesa");
            return View();
        }

        // POST: Solicitantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSolicitante,NomeSolicitante,MesaIdMesa,EstadoAtendimento")] Solicitante solicitante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MesaIdMesa"] = new SelectList(_context.Mesa, "IdMesa", "IdMesa", solicitante.MesaIdMesa);
            return View(solicitante);
        }
        // GET: Solicitantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitante = await _context.Solicitante.FindAsync(id);
            if (solicitante == null)
            {
                return NotFound();
            }
            ViewData["MesaIdMesa"] = new SelectList(_context.Mesa, "IdMesa", "IdMesa", solicitante.MesaIdMesa);
            return View(solicitante);
        }

        // POST: Solicitantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSolicitante,NomeSolicitante,MesaIdMesa,EstadoAtendimento")] Solicitante solicitante)
        {
            if (id != solicitante.IdSolicitante)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitanteExists(solicitante.IdSolicitante))
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
            ViewData["MesaIdMesa"] = new SelectList(_context.Mesa, "IdMesa", "IdMesa", solicitante.MesaIdMesa);
            return View(solicitante);
        }

        // GET: Solicitantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitante = await _context.Solicitante
                .Include(s => s.MesaIdMesaNavigation)
                .FirstOrDefaultAsync(m => m.IdSolicitante == id);
            if (solicitante == null)
            {
                return NotFound();
            }

            return View(solicitante);
        }

        // POST: Solicitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitante = await _context.Solicitante.FindAsync(id);
            _context.Solicitante.Remove(solicitante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitanteExists(int id)
        {
            return _context.Solicitante.Any(e => e.IdSolicitante == id);
        }
    }
}
