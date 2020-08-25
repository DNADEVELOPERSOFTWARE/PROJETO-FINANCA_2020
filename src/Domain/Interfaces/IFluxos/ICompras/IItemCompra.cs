using Entity.Entities.Fluxos.Compras;
using System.Collections.Generic;

namespace Domain.Interfaces.IFluxos.ICompras
{
    public interface IItemCompra : IGenerica<ItemCompra>
    {
        void AtualizarItemCompra(ItemCompra ItemCompra);

        void DeletarItemPorId(int Id);

        IList<ItemCompra> ListarItensDaCompra(int IdCompra);
    }
}
