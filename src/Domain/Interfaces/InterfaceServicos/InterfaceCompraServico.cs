using Entity.Entities.Fluxos.Compras;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceCompraServico
    {
        void AdicionarCompra(Compra compra);
        void AtualizarCompra(Compra compra);
    }
}
