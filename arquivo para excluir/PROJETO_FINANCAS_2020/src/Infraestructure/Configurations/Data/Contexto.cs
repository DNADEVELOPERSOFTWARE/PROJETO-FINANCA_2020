using Entity.Entities.Categorias;
using Entity.Entities.Fluxos.Despesas;
using Entity.Entities.Identitity;
using Entity.Entities.Sistemas;
using Entity.Entities.Sugestoes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Configurations.Data
{
    public class Contexto : IdentityDbContext<ApplicationUser>
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
            //  string strCon = "Data Source=VALDIR-PC\\BIASQLSERVER;Initial Catalog=FINANCEIRO;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";
            string strCon = "Data Source=DESKTOP-PAULO;Initial Catalog=FINANCEIRO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";



            // ambiene  de desenvolvimento
            // string strCon = "Data Source=DESKTOP-HVNTI80\\DESENVOLVIMENTO;Initial Catalog=FINANCEIRO;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;";


            return strCon;
        }

    }
}
