﻿using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Domain.Interfaces.ISistemas.IUsuarioSistemaFinanceiro
{
    public interface IUsuarioSistemaFinanceiro : IGenerica<UsuarioSistemaFinanceiro>
    {
        IList<UsuarioSistemaFinanceiro> ListarUsuariosSistema(int IdSistema);
        void RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);

        UsuarioSistemaFinanceiro ObterUsuarioPorEmail(string EmailUsuario);
    }
}
