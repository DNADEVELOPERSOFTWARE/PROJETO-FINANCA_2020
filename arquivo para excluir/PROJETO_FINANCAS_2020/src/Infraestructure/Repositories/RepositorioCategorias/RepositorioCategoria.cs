using Domain.Interfaces;
using Entity.Entities.Categorias;
using Infraestructure.Configurations.Data;
using Infraestructure.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Infraestructure.Repositories.RepositorioCategorias
{
    public class RepositorioCategoria : RepositorioGenerico<Categoria>, ICategoria
    {
        private readonly DbContextOptions<Contexto> _options_Builder;
        public RepositorioCategoria()
        {
            _options_Builder = new DbContextOptions<Contexto>();
        }

        public IList<Categoria> ListarCategoriasUsuario(string emailUsuario)
        {
           using(var banco = new Contexto(_options_Builder))
            {
                return (from s in banco.SistemaFinanceiro
                        join c in banco.Categoria on s.  equals c.IdSistema
                        join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                        where us.EmailUsuario.Equals(emailUsuario) && us.SistemaAtual
                        select c).AsNoTracking().ToList();
            }
        }
    }
}
