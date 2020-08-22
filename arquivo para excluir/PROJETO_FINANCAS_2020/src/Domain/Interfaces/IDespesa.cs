using Entity.Entities.Fluxos.Despesas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDespesa : IGenerica<Despesa>
    {
        IList<Despesa> ListarDespesasUsuario(string emailUsuario);

        IList<Despesa> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
