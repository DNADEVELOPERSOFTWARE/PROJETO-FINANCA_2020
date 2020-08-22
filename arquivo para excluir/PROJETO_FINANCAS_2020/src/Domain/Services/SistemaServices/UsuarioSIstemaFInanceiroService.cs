using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entity.Entities.Sistemas;

namespace Domain.Services.SistemaServices
{
    public class UsuarioSIstemaFInanceiroService : IUsuarioSistemaFinanceiroService
    {
        private readonly IUsuarioSistemaFinanceiro _iUsuarioSistemaFinanceiro;

        public UsuarioSIstemaFInanceiroService(IUsuarioSistemaFinanceiro iUsuarioSistemaFinanceiro)
        {
            _iUsuarioSistemaFinanceiro = iUsuarioSistemaFinanceiro;
        }

        public void CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            _iUsuarioSistemaFinanceiro.Add(usuarioSistemaFinanceiro);
        }
    }
}
