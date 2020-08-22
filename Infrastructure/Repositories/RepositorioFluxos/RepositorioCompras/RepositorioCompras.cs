using Domain.Interfaces.ICompras;
using Entity.Entities.Fluxos.Compras;
using Infrastructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infrastructure.Repositories.RepositorioFluxos.RepositorioCompras
{
    public class RepositorioCompras : RepositorioGenerico<Compra>, InterfaceCompra
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositorioCompras()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<Compra> ListarComprasUsuario(string emailUsuario)
        {
            throw new System.NotImplementedException();
        }
    }
}
