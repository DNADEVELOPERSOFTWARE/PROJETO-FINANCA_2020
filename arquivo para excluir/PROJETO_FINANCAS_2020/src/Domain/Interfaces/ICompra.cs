using Entity.Entities.Fluxos.Despesas;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ICompra : IGenerica<Compra>
    {
        IList<Compra> ListarComprasUsuario(string emailUsuario);
    }
}
