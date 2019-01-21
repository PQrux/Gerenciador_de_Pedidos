using System;
using System.Collections.Generic;

namespace GerenciadorDePedidos.Models
{
    public partial class Produto
    {
        public Produto()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public float ValorProduto { get; set; }
        public string TipoDeProduto { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
    }
}
