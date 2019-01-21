using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GerenciadorDePedidos.Models
{
    public partial class gerenciador_de_pedidosContext : DbContext
    {
        public gerenciador_de_pedidosContext()
        {
        }

        public gerenciador_de_pedidosContext(DbContextOptions<gerenciador_de_pedidosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mesa> Mesa { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Solicitante> Solicitante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;user=root;password=i4e7l4@1245;database=gerenciador_de_pedidos");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesa>(entity =>
            {
                entity.HasKey(e => e.IdMesa);

                entity.ToTable("mesa", "gerenciador_de_pedidos");

                entity.Property(e => e.IdMesa)
                    .HasColumnName("idMesa")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("pedido", "gerenciador_de_pedidos");

                entity.HasIndex(e => e.ProdutoIdProduto)
                    .HasName("Produto_idProduto");

                entity.HasIndex(e => e.SolicitanteIdSolicitante)
                    .HasName("Solicitante_idSolicitante");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("idPedido")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataPedido)
                    .HasColumnName("dataPedido")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EstadoPedido)
                    .IsRequired()
                    .HasColumnName("estadoPedido")
                    .HasColumnType("enum('ABERTO','DEFERIDO','FECHADO','CANCELADO')")
                    .HasDefaultValueSql("ABERTO");

                entity.Property(e => e.ProdutoIdProduto)
                    .HasColumnName("Produto_idProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("quantidade")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.SolicitanteIdSolicitante)
                    .HasColumnName("Solicitante_idSolicitante")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.ProdutoIdProdutoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.ProdutoIdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Produto_idProduto");

                entity.HasOne(d => d.SolicitanteIdSolicitanteNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.SolicitanteIdSolicitante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Solicitante_idSolicitante");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.IdProduto);

                entity.ToTable("produto", "gerenciador_de_pedidos");

                entity.Property(e => e.IdProduto)
                    .HasColumnName("idProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeProduto)
                    .IsRequired()
                    .HasColumnName("nomeProduto")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDeProduto)
                    .IsRequired()
                    .HasColumnName("tipoDeProduto")
                    .HasColumnType("enum('BEBIDA','PRATO')")
                    .HasDefaultValueSql("BEBIDA");

                entity.Property(e => e.ValorProduto).HasColumnName("valorProduto");
            });

            modelBuilder.Entity<Solicitante>(entity =>
            {
                entity.HasKey(e => e.IdSolicitante);

                entity.ToTable("solicitante", "gerenciador_de_pedidos");

                entity.HasIndex(e => e.MesaIdMesa)
                    .HasName("Mesa_idMesa");

                entity.Property(e => e.IdSolicitante)
                    .HasColumnName("idSolicitante")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EstadoAtendimento)
                    .IsRequired()
                    .HasColumnName("estadoAtendimento")
                    .HasColumnType("enum('ABERTO','CONCLUIDO')")
                    .HasDefaultValueSql("ABERTO");

                entity.Property(e => e.MesaIdMesa)
                    .HasColumnName("Mesa_idMesa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomeSolicitante)
                    .IsRequired()
                    .HasColumnName("nomeSolicitante")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasOne(d => d.MesaIdMesaNavigation)
                    .WithMany(p => p.Solicitante)
                    .HasForeignKey(d => d.MesaIdMesa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Mesa_idMesa");
            });
        }
    }
}
