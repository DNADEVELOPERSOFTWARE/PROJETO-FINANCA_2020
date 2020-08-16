using Domain.Interfaces.IGenerics;
using Entity.Entities.Fluxos.Despesa;
using System.Collections.Generic;

namespace Domain.Interfaces.IDespesas
{
    public interface InterfaceDespesa : InterfaceGenerica<Despesa>
    {
        IList<Despesa> ListarDespesasUsuario(string emailUsuario);

        IList<Despesa> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
