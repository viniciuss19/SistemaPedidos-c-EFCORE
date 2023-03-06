using Microsoft.EntityFrameworkCore;
using Sistema_de_Pedidos;
using Sistema_de_Pedidos.Domain;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pedidos.DB
{
    class ApplicationContext : DbContext
    {
        DbSet<Pedido> pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=EFCore; Integrated Security=true*");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(p =>
            {
                p.ToTable("Cliente");
                p.HasKey(p => p.Id);
                p.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
                p.Property(p => p.Telefone).HasColumnType("CHAR(11)").IsRequired();
                p.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();
                p.Property(p => p.Estado).HasColumnType("CHAR(18)").IsRequired();
                p.Property(p => p.Cidade).HasMaxLength(60).IsRequired();
                


            });
            modelBuilder.Entity<Produto>(p =>
            {
                p.ToTable("Produto");
                p.HasKey(p => p.Id);
                p.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(70)").IsRequired();
                p.Property(p => p.Descricao).HasColumnType("VARCHAR(70)").IsRequired(); 
                p.Property(p => p.Valor).IsRequired();


                p.HasMany(p => p.Itens).WithOne(p => p.Pedido).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Pedido>(p =>
            {
                p.ToTable("Pedido");
                p.HasKey(p => p.id);
                p.Property(p => p.Status).HasConversion<string>();
                p.Property(p => p.TipoFrete).HasConversion<string>();
                p.Property(p => p.Observacao).HasColumnType("CHAR(30)");
            });

            modelBuilder.Entity<PedidoItem>(p =>
            {
                p.ToTable("PedidoItem");
                p.HasKey(p => p.Id);
                p.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
                p.Property(p => p.Valor).IsRequired();
                p.Property(p => p.Desconto).IsRequired();
            });
        }
    }
}
