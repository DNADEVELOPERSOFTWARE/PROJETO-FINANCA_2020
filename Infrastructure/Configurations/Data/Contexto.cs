using Entity.Entities;
using Entity.Entities.Categorias;
using Entity.Entities.Fluxos.Compras;
using Entity.Entities.Fluxos.Despesa;
using Entity.Entities.Sistemas;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configurations.Data
{
    public class Contexto : DbContext
    {


        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            //  Database.EnsureCreated();

        }

        public DbSet<Categoria> Categoria { set; get; }
        public DbSet<Despesa> Despesa { set; get; }
        public DbSet<SistemaFinanceiro> SistemaFinanceiro { set; get; }
        public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { set; get; }
        public DbSet<Sugestao> Sugestao { set; get; }
        public DbSet<Compra> Compra { set; get; }
        public DbSet<ItemCompra> ItemCompra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se não estiver configurado no projeto IU pega deginição de chame do json configurado
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConectionConfig()
        {
            // ambiene  de Produção
             string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FINANCEIRO_2020;Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";

            // ambiene  de desenvolvimento
            //string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FINANCEIRO;Integrated Security=False;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";


            return strCon;
        }

    }
}