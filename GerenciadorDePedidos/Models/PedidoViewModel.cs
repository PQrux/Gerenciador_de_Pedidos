using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDePedidos.Models
{
    public class PedidoViewModel
    {
        public ICollection<Solicitante> Solicitantes { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
