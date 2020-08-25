using Application.Interfaces.ISistemaApp.IUsuarioSistemasFinanceirosApp;
using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ISistemas.IUsuarioSistemaFinanceiro;
using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Application.App.SIstemasApps.SistemasUsuarioFinanceiroApp
{
    public class AppUsuarioSistemaFinanceiro : IAppUsuarioSistemaFinanceiro
    {
        private readonly IUsuarioSistemaFinanceiro _iUsuarioSistemaFinanceiro;
        private readonly IUsuarioSistemaFinanceiroServico _iUsuarioSistemaFinanceiroServico;

        public AppUsuarioSistemaFinanceiro(IUsuarioSistemaFinanceiro iUsuarioSistemaFinanceiro, IUsuarioSistemaFinanceiroServico iUsuarioSistemaFinanceiroServico)
        {
            _iUsuarioSistemaFinanceiro = iUsuarioSistemaFinanceiro;
            _iUsuarioSistemaFinanceiroServico = iUsuarioSistemaFinanceiroServico;
        }
        public void Add(UsuarioSistemaFinanceiro Objeto)
        {
            _iUsuarioSistemaFinanceiro.Add(Objeto);
        }
        public void Delete(UsuarioSistemaFinanceiro Objeto)
        {
            _iUsuarioSistemaFinanceiro.Delete(Objeto);
        }
        public UsuarioSistemaFinanceiro GetEntityById(int Id)
        {
            return _iUsuarioSistemaFinanceiro.GetEntityById(Id);
        }
        public List<UsuarioSistemaFinanceiro> List()
        {
            return _iUsuarioSistemaFinanceiro.List();
        }
        public void Update(UsuarioSistemaFinanceiro Objeto)
        {
            _iUsuarioSistemaFinanceiro.Update(Objeto);
        }

        #region MÉTODOS CUSTUMIZADOS
        public UsuarioSistemaFinanceiro ObterUsuarioPorEmail(string EmailUsuario)
        {
            return _iUsuarioSistemaFinanceiro.ObterUsuarioPorEmail(EmailUsuario);
        }
        public IList<UsuarioSistemaFinanceiro> ListarUsuariosSistema(int idSistema)
        {
            return _iUsuarioSistemaFinanceiro.ListarUsuariosSistema(idSistema);
        }
        public void RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
        {
            _iUsuarioSistemaFinanceiro.RemoveUsuarios(usuarios);
        }

        //MÉTODO DE SERVIÇO
        public void CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            _iUsuarioSistemaFinanceiroServico.CadastrarUsuarioNoSistema(usuarioSistemaFinanceiro);
        }

        #endregion

    }
}
