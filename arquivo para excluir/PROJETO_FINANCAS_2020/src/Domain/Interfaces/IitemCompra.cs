using Entity.Entities.Fluxos.Despesas;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IitemCompra : IGenerica<ItemCompra>
    {
        void AtualizarItemCompra(ItemCompra ItemCompra);

        void DeletarItemPorId(int Id);

        IList<ItemCompra> ListarItensDaCompra(int IdCompra);
    }
}
