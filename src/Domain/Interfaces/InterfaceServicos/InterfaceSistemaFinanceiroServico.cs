using Entity.Entities.Sismtemas;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceSistemaFinanceiroServico
    {
        void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
        void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
    }
}
