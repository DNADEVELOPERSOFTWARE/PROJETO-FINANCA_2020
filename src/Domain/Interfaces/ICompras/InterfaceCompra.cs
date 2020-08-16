using Domain.Interfaces.IGenerics;
using Entity.Entities.Fluxos.Compras;
using System.Collections.Generic;

namespace Domain.Interfaces.ICompras
{
    public interface InterfaceCompra : InterfaceGenerica<Compra>
    {
        IList<Compra> ListarComprasUsuario(string emailUsuario);
    }
}
