using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Application.Interfaces.ISistemaApp.ISistemasFinanceirosApp
{
    public interface IAppSistemaFinanceiro : IGenericaApp<SistemaFinanceiro>
    {
        IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario);

        void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
        void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro);
    }
}
