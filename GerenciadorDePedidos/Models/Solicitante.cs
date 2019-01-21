using System;
using System.Collections.Generic;

namespace GerenciadorDePedidos.Models
{
    public partial class Solicitante
    {
        public int IdSolicitante { get; set; }
        public string NomeSolicitante { get; set; }
        public int MesaIdMesa { get; set; }
        public string EstadoAtendimento { get; set; }

        public Mesa MesaIdMesaNavigation { get; set; }
        public List<Pedido> Pedido { get; set; }
    }
}
