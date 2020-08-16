﻿using Domain.Interfaces.IGenerics;
using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Domain.Interfaces.ISistemaFinanceiro
{
    public interface InterfaceSistemaFinanceiro : InterfaceGenerica<SistemaFinanceiro>
    {
        IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario);
    }
}
