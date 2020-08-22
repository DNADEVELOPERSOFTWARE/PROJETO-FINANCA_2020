using Entity.Entities.Fluxos.Despesas;

namespace Domain.Interfaces.IServices
{
    public interface ICompraService
    {
        void AdicionarCompra(Compra compra);
        void AtualizarCompra(Compra compra);
    }
}
