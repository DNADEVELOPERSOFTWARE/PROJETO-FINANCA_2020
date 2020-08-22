using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ISistemaFInanceiro : IGenerica<SistemaFinanceiro>
    {
        IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario);
    }
}
