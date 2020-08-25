using Domain.Interfaces.IFluxos.ICompras;
using Entity.Entities.Fluxos.Compras;
using Infrastructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Infrastructure.Repositories.RepositoriosFluxos.RepositoriosCompras
{
    public class RepositorioCompra : RepositorioGenerico<Compra>, ICompra
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;
        public RepositorioCompra()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Compra> ListarComprasUsuario(string emailUsuario)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                return (from s in banco.SistemaFinanceiro
                        join c in banco.Categoria on s.Id equals c.IdSistema
                        join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                        join compra in banco.Compra on c.Id equals compra.IdCategoria
                        where us.EmailUsuario.Equals(emailUsuario)
                        select compra).AsNoTracking().ToList();
            }
        }
    }
}
