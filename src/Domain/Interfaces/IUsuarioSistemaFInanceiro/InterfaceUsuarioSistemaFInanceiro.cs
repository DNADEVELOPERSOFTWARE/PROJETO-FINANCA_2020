using Domain.Interfaces.IGenerics;
using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Domain.Interfaces.IUsuarioSistemaFInanceiro
{
    public interface InterfaceUsuarioSistemaFInanceiro : InterfaceGenerica<UsuarioSistemaFinanceiro>
    {
        IList<UsuarioSistemaFinanceiro> ListarUsuariosSistema(int IdSistema);
        void RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);

        UsuarioSistemaFinanceiro ObterUsuarioPorEmail(string EmailUsuario);
    }
}
