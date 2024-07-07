using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloProduto;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
namespace ControladeDeBar.Infra.Orm.Compartilhado
{
    public class ControleDeBarDbContext : DbContext
    {
        public DbSet<Garcom> Garcons { get; internal set; }
        public DbSet<Produto> Produtos { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
               "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ControleDeBarOrm;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garcom>(garcomBuilder =>
            {
                garcomBuilder.ToTable("TBGarcom");

                garcomBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                garcomBuilder.Property(d => d.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                produtoBuilder.Property(d => d.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                produtoBuilder.Property(d => d.Preco)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}