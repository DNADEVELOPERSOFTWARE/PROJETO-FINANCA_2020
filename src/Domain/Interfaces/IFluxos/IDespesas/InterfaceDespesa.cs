using Entity.Entities.Fluxos.Despesa;
using System.Collections.Generic;

namespace Domain.Interfaces.IFluxos.IDespesas
{
    public interface IDespesa : IGenerica<Despesa>
    {
        IList<Despesa> ListarDespesasUsuario(string emailUsuario);

        IList<Despesa> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
