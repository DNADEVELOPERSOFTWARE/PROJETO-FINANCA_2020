using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Application.Interfaces.ISistemaApp.IUsuarioSistemasFinanceirosApp
{
    public interface IAppUsuarioSistemaFinanceiro : IGenericaApp<UsuarioSistemaFinanceiro>
    {
        void CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro);

        IList<UsuarioSistemaFinanceiro> ListarUsuariosSistema(int idSistema);

        void RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);

        UsuarioSistemaFinanceiro ObterUsuarioPorEmail(string EmailUsuario);
    }
}
