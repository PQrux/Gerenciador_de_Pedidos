using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciadorDePedidos.Models;

namespace GerenciadorDePedidos.Models
{
    public class GerenciadorDePedidosContext : DbContext
    {
        public GerenciadorDePedidosContext (DbContextOptions<GerenciadorDePedidosContext> options)
            : base(options)
        {
        }
        public DbSet<GerenciadorDePedidos.Models.Solicitante> Solicitante { get; set; }
        //public DbSet<GerenciadorDePedidos.Models.Cadastro> Cadastro { get; set; }
    }
}
