using Domain.Interfaces.IGenerics;
using Entity.Entities.Fluxos.Compras;
using System.Collections.Generic;

namespace Domain.Interfaces.ICompras
{
    public interface InterfaceItemCompra : InterfaceGenerica<ItemCompra>
    {
        void AtualizarItemCompra(ItemCompra ItemCompra);

        void DeletarItemPorId(int Id);

        IList<ItemCompra> ListarItensDaCompra(int IdCompra);
    }
}
