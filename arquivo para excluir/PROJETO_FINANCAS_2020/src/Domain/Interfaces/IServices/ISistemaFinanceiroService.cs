using Entity.Entities.Sistemas;

namespace Domain.Interfaces.IServices
{
    public interface ISistemaFinanceiroService
    {
        void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
        void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
    }
}
