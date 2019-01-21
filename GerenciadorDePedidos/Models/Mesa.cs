using System;
using System.Collections.Generic;

namespace GerenciadorDePedidos.Models
{
    public partial class Mesa
    {
        public Mesa()
        {
            Solicitante = new HashSet<Solicitante>();
        }

        public int IdMesa { get; set; }

        public ICollection<Solicitante> Solicitante { get; set; }
    }
}
