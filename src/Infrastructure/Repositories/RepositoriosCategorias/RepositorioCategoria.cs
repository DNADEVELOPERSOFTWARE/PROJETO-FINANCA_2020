using Domain.Interfaces.ICategorias;
using Entity.Entities.Categorias;
using Infrastructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.RepositoriosCategorias
{
    public class RepositorioCategoria : RepositorioGenerico<Categoria>, ICategoria
    {

        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositorioCategoria()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Categoria> ListarCategoriasUsuario(string emailUsuario)
        {

            using (var banco = new Contexto(_OptionsBuilder))
            {
                return (from s in banco.SistemaFinanceiro
                        join c in banco.Categoria on s.Id equals c.IdSistema
                        join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                        where us.EmailUsuario.Equals(emailUsuario) && us.SistemaAtual
                        select c).AsNoTracking().ToList();
            }

        }
    }
}
