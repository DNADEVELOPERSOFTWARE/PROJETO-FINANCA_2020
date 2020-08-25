using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ISistemas.IUsuarioSistemaFinanceiro;
using Entity.Entities.Sistemas;

namespace Domain.Services.SistemaService
{
    public class UsuarioSistemaFinanceiroServico : IUsuarioSistemaFinanceiroServico
    {
        private readonly IUsuarioSistemaFinanceiro _iUsuarioSistemaFInanceiro;

        public UsuarioSistemaFinanceiroServico(IUsuarioSistemaFinanceiro iUsuarioSistemaFInanceiro)
        {
            _iUsuarioSistemaFInanceiro = iUsuarioSistemaFInanceiro;
        }

        public void CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            _iUsuarioSistemaFInanceiro.Add(usuarioSistemaFinanceiro);
        }
    }
}
