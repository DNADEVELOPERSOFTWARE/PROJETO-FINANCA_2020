using Entity.Entities.Sistemas;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceSistemaFinanceiroServico
    {
        void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
        void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
    }
}
