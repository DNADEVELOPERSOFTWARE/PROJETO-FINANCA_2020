using Entity.Entities.Fluxos.Despesa;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface IDespesaServico
    {
        void AdicionarDespesa(Despesa despesa);
        void AtualizarDespesa(Despesa despesa);
    }
}
