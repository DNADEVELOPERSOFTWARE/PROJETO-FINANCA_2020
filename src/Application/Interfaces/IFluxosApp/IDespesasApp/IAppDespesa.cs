using Entity.Entities.Fluxos.Despesa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.IFluxosApp.IDespesasApp
{
    public  interface IAppDespesa : IGenericaApp<Despesa>
    {
        void AdicionarDespesa(Despesa despesa);
        void AtualizarDespesa(Despesa despesa);

        IList<Despesa> ListarDespesasUsuario(string emailUsuario);
        IList<Despesa> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
