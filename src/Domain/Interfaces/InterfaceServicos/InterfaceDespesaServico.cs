using Entity.Entities.Fluxos.Despesa;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceDespesaServico
    {
        void AdicionarDespesa(Despesa despesa);
        void AtualizarDespesa(Despesa despesa);
    }
}
