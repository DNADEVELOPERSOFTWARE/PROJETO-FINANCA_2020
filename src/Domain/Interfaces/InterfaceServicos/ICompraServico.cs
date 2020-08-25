using Entity.Entities.Fluxos.Compras;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface ICompraServico
    {
        void AdicionarCompra(Compra compra);
        void AtualizarCompra(Compra compra);
    }
}
