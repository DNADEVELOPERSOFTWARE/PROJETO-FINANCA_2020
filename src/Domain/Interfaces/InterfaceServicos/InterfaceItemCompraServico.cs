using Entity.Entities.Fluxos.Compras;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceItemCompraServico
    {
        void AdicionarItemCompra(ItemCompra itemCompra);
        void AtualizarItemCompra(ItemCompra itemCompra);
    }
}
