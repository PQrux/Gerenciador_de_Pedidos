using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDePedidos.Services;
using GerenciadorDePedidos.Models;


namespace GerenciadorDePedidos.Controllers
{
    public class PedidoesController : Controller
    {
        public readonly SolicitanteService _solicitanteService;
        public readonly gerenciador_de_pedidosContext _context;

        public PedidoesController(gerenciador_de_pedidosContext newContext, SolicitanteService solicitanteService)
        {
            _solicitanteService = solicitanteService;
            _context = newContext;
        }


        // GET: Pedidoes
        public ActionResult Copas()
        {
            
            var listaCopa = _solicitanteService.listCopa();
           

            return View(listaCopa);
        }

        // GET: Pedidoes/Details/5
        public ActionResult DetalheCopa(int id)
        {
            return View(_solicitanteService.listCopa());
        }
        public ActionResult DetalheCozinha(int id)
        {
            return View(_solicitanteService.listCozinha());
        }

        // GET: Pedidoes/Create
        public ActionResult Cozinhas()
        {
            
            var listaCozinha = _solicitanteService.listCozinha();
           
            return View(listaCozinha);
        }

        
        // GET: Pedidoes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pedidoes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Copas));
            }
            catch
            {
                return View();
            }
        }

    }
}