using Entity.Entities.Sistemas;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface ISistemaFinanceiroServico
    {
        void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
        void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
    }
}
