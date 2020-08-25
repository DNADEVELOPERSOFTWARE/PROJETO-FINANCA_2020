using Application.Interfaces.ISistemaApp.ISistemasFinanceirosApp;
using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ISistemas.ISistemaFinanceiro;
using Entity.Entities.Sistemas;
using System.Collections.Generic;

namespace Application.App.SIstemasApps.SistemasFinanceirosApps
{
    public class AppSistemaFinanceiro : IAppSistemaFinanceiro
    {
        private readonly ISistemaFinanceiro _iSistemaFinanceiro;
        private readonly ISistemaFinanceiroServico _iSistemaFinanceiroServico;

        public AppSistemaFinanceiro(ISistemaFinanceiro iSistemaFinanceiro, ISistemaFinanceiroServico iSistemaFinanceiroServico)
        {
            _iSistemaFinanceiro = iSistemaFinanceiro;
            _iSistemaFinanceiroServico = iSistemaFinanceiroServico;
        }
        public void Add(SistemaFinanceiro Objeto)
        {
            _iSistemaFinanceiro.Add(Objeto);
        }
        public void Delete(SistemaFinanceiro Objeto)
        {
            _iSistemaFinanceiro.Delete(Objeto);
        }
        public SistemaFinanceiro GetEntityById(int Id)
        {
            return _iSistemaFinanceiro.GetEntityById(Id);
        }
        public List<SistemaFinanceiro> List()
        {
            return _iSistemaFinanceiro.List();
        }
        public void Update(SistemaFinanceiro Objeto)
        {
            _iSistemaFinanceiro.Update(Objeto);
        }

        #region MÉTODOS CUSTUMIZADOS
        public IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario)
        {
            return _iSistemaFinanceiro.ListaSistemasUsuario(emailUsuario);
        }

        //MÉTODOS DE SERVIÇO 
        public void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            _iSistemaFinanceiroServico.AdicionarSistemaFinanceiro(sistemaFinanceiro);
        }
        public void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            _iSistemaFinanceiroServico.AtualizarSistemaFinanceiro(sistemaFinanceiro);
        }
        #endregion
    }
}
