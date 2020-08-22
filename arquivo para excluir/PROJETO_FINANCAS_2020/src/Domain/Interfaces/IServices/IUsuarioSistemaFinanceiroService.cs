using Entity.Entities.Sistemas;

namespace Domain.Interfaces.IServices
{
    public interface IUsuarioSistemaFinanceiroService
    {
        void CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro);
    }
}
