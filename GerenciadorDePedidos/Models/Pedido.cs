using System;
using System.Collections.Generic;

namespace GerenciadorDePedidos.Models
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }
        public int SolicitanteIdSolicitante { get; set; }
        public int ProdutoIdProduto { get; set; }
        public byte Quantidade { get; set; }
        public string EstadoPedido { get; set; }
        public DateTime DataPedido { get; set; }

        public Produto ProdutoIdProdutoNavigation { get; set; }
        public Solicitante SolicitanteIdSolicitanteNavigation { get; set; }
    }
}
