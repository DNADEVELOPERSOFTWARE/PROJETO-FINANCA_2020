using Entity.Entities.Fluxos.Compras;
using System.Collections.Generic;

namespace Domain.Interfaces.IFluxos.ICompras
{
    public interface ICompra : IGenerica<Compra>
    {
        IList<Compra> ListarComprasUsuario(string emailUsuario);
    }
}
