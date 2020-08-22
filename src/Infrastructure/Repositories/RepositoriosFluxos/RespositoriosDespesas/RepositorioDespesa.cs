using Domain.Interfaces.IDespesas;
using Entity.Entities.Fluxos.Despesa;
using Infrastructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.RepositoriosFluxos.RespositoriosDespesas
{
    public class RepositorioDespesa : RepositorioGenerico<Despesa>, InterfaceDespesa
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositorioDespesa()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Despesa> ListarDespesasUsuario(string emailUsuario)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                return (from s in banco.SistemaFinanceiro
                        join c in banco.Categoria on s.Id equals c.IdSistema
                        join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                        join d in banco.Despesa on s.Id equals d.IdCategoria
                        where us.EmailUsuario.Equals(emailUsuario) && s.Mes == d.Mes && s.Ano == d.Ano select d).AsNoTracking().ToList();
             }
        }

        public IList<Despesa> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                return (from s in banco.SistemaFinanceiro
                        join c in banco.Categoria on s.Id equals c.IdSistema
                        join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                        join d in banco.Despesa on s.Id equals d.IdCategoria
                        where us.EmailUsuario.Equals(emailUsuario) && s.Mes == d.Mes && s.Ano == d.Ano
                        select d).AsNoTracking().ToList();
            }
        }
    }
}
