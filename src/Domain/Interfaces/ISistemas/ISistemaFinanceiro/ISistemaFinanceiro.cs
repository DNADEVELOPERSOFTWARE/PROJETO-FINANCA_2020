using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Domain.Interfaces.ISistemas.ISistemaFinanceiro
{
    public interface ISistemaFinanceiro : IGenerica<SistemaFinanceiro>
    {
        IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario);
    }
}
