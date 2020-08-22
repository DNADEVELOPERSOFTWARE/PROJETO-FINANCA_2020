using Entity.Entities.Fluxos.Despesas;

namespace Domain.Interfaces.IServices
{
    public interface IDespesaService
    {
        void AdicionarDespesa(Despesa despesa);
        void AtualizarDespesa(Despesa despesa);
    }
}
