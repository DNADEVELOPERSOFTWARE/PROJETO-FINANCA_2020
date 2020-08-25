using Entity.Entities.Fluxos.Compras;
using System.Collections.Generic;

namespace Application.Interfaces.IFluxosApp.IComprasApp
{
    public interface IAppItemCompra : IGenericaApp<ItemCompra>
    {
        void AdicionarItemCompra(ItemCompra ItemCompra);
        void AtualizarItemCompraServico(ItemCompra ItemCompra);
        void AtualizarItemCompra(ItemCompra ItemCompra);
        IList<ItemCompra> ListarItensDaCompra(int IdCompra);

        void DeletarItemPorId(int Id);
    }
}
