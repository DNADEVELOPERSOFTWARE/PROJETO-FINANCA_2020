using Entity.Entities.Fluxos.Compras;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceItemCompraServico
    {
        void AdicionarItemCompra(ItemCompra ItemCompra);
        void AtualizarItemCompra(ItemCompra ItemCompra);
    }
}
