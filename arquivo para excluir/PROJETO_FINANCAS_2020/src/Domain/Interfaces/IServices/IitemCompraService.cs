using Entity.Entities.Fluxos.Despesas;

namespace Domain.Interfaces.IServices
{
    public interface IitemCompraService
    {
        void AdicionarItemCompra(ItemCompra itemCompra);
        void AtualizarItemCompra(ItemCompra itemCompra);
    }
}
