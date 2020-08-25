using Entity.Entities.Fluxos.Compras;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface IItemCompraServico
    {
        void AdicionarItemCompra(ItemCompra itemCompra);
        void AtualizarItemCompra(ItemCompra itemCompra);
    }
}
