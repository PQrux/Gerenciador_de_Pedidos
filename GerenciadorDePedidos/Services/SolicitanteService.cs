using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDePedidos.Models;

namespace GerenciadorDePedidos.Services
{
    public class SolicitanteService
    {
        public readonly gerenciador_de_pedidosContext _context;

        public SolicitanteService(gerenciador_de_pedidosContext newgerenciador_De_pedidosContext)
        {
            _context = newgerenciador_De_pedidosContext;
        }

        public List<Pedido> listCozinha()
        {
            return _context.Pedido.Where(x => x.ProdutoIdProdutoNavigation.TipoDeProduto == "PRATO").ToList();
        }
        public List<Pedido> listCopa()
        {
            return _context.Pedido.Where(x => x.ProdutoIdProdutoNavigation.TipoDeProduto == "BEBIDA").ToList();
        }
        public List<Produto> listPratos()
        {
            return _context.Produto.Where(x => x.TipoDeProduto == "PRATO").ToList();
        }
        public List<Produto> listBebidas()
        {
            return _context.Produto.Where(x => x.TipoDeProduto == "BEBIDA").ToList();
        }
        public List<Pedido> listPedidos(int id) 
        {
            return _context.Pedido.Where(x => x.SolicitanteIdSolicitante == id).ToList();
        }
        
       
    }
}
