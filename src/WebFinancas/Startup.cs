using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure.Configurations.Data;
using Entity.Entities.Users;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Domain.Interfaces.ICategorias;
using Infrastructure.Repositories.RepositoriosCategorias;
using Domain.Interfaces.IFluxos.IDespesas;
using Infrastructure.Repositories.RepositoriosFluxos.RespositoriosDespesas;
using Domain.Interfaces.ISistemas.ISistemaFinanceiro;
using Domain.Interfaces.ISistemas.IUsuarioSistemaFinanceiro;
using Infrastructure.Repositories.RepositoriosSistemas;
using Domain.ISugestao;
using Infrastructure.Repositories.RepositorioSugestoes;
using Domain.Interfaces.IFluxos.ICompras;
using Infrastructure.Repositories.RepositoriosFluxos.RepositoriosCompras;
using Domain.Interfaces.InterfaceServicos;
using Domain.Services.FluxoServicos.DespesasServico;
using Domain.Services.SistemaService;
using Domain.Services.CategoriaServicos;
using Domain.Services.FluxoServicos.ComprasServicos;
using Application.Interfaces.ICategoriasApp;
using Application.App.CategriasApps;
using Application.Interfaces.IFluxosApp.IDespesasApp;
using Application.App.FluxosApps.DespesasApp;
using Application.Interfaces.ISistemaApp.ISistemasFinanceirosApp;
using Application.App.SIstemasApps.SistemasFinanceirosApps;
using Application.Interfaces.ISistemaApp.IUsuarioSistemasFinanceirosApp;
using Application.App.SIstemasApps.SistemasUsuarioFinanceiroApp;
using Application.Interfaces.ISugestoesApps;
using Application.App.SugestoesApps;
using Application.Interfaces.IFluxosApp.IComprasApp;
using Application.App.FluxosApps.ComprasApps;

namespace WebFinancas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Coeexão com o SQL Server
            services.AddDbContext<Contexto>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Contexto>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            //............PARA UTILIZAR O MYSQL DESCOMENTE O BLOCO ABAIXO..........//
            ////Conexao com o Mysql Server
            //services.AddDbContext<Contexto>(options =>
            //   options.UseMySql(
            //       Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<Contexto>();

            //---------------------CONFIGURAÇÕES DO IIS---------------------------//
            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });
            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });
            //-------------------FIM COFIGURAÇÃO DO ISS---------------------------//

            //--------------------DOMAIN - INFRASTRUCTURE-------------------------//
            // INTERFACE E REPOSITORIO
            services.AddSingleton(typeof(IGenerica<>), typeof(RepositorioGenerico<>));
            services.AddSingleton<ICategoria, RepositorioCategoria>();
            services.AddSingleton<IDespesa, RepositorioDespesa>();
            services.AddSingleton<ISistemaFinanceiro, RepositorioSistemaFinanceiro>();
            services.AddSingleton<IUsuarioSistemaFinanceiro, RepositorioUsuarioSistemaFinanceiro>();
            services.AddSingleton<ISugestao, RepositorioSugestao>();
            services.AddSingleton<ICompra, RepositorioCompra>();
            services.AddSingleton<IItemCompra, RepositorioItemCompra>();

            // SERVIÇO DOMINIO
            services.AddSingleton<IDespesaServico, DespesaServico>();
            services.AddSingleton<ISistemaFinanceiroServico, SistemaFinanceiroService>();
            services.AddSingleton<IUsuarioSistemaFinanceiroServico, UsuarioSistemaFinanceiroServico>();
            services.AddSingleton<ICategoriaServico, CategoriaServico>();
            services.AddSingleton<ICompraServico, ComprasServico>();
            services.AddSingleton<IItemCompraServico, ItemCompraServico>();

            //------------------APLLICATION---------------------------------------//
            //// INTERFACE APLICAÇÃO
            services.AddSingleton<IAppCategoria, AppCategoria>();
            services.AddSingleton<IAppDespesa, AppDestesa>();
            services.AddSingleton<IAppSistemaFinanceiro, AppSistemaFinanceiro>();
            services.AddSingleton<IAppUsuarioSistemaFinanceiro, AppUsuarioSistemaFinanceiro>();
            services.AddSingleton<IAppSugestao, AppSugestao>();
            services.AddSingleton<IAppCompra, AppCompra>();
            services.AddSingleton<IAppItemCompra, AppItemCompra>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
