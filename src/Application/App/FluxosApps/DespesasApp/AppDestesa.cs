using Application.Interfaces.IFluxosApp.IDespesasApp;
using Domain.Interfaces.IFluxos.IDespesas;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Despesa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.App.FluxosApps.DespesasApp
{
    public class AppDestesa : IAppDespesa
    {
        IDespesa _iDespesa;
        IDespesaServico _iDespesaServico;

        public AppDestesa(IDespesa iDespesa, IDespesaServico iDespesaServico)
        {
            _iDespesa = iDespesa;
            _iDespesaServico = iDespesaServico;
        }
        
        public void Add(Despesa Objeto)
        {
            _iDespesa.Add(Objeto);
        }

        public void Delete(Despesa Objeto)
        {
            _iDespesa.Delete(Objeto);
        }

        public Despesa GetEntityById(int Id)
        {
            return _iDespesa.GetEntityById(Id);
        }

        public List<Despesa> List()
        {
            return _iDespesa.List();
        }

        public void Update(Despesa Objeto)
        {
            _iDespesa.Update(Objeto);
        }

        #region MÉTODOS CUSTUMIZADOS

        public IList<Despesa> ListarDespesasUsuario(string emailUsuario)
        {
            return _iDespesa.ListarDespesasUsuario(emailUsuario);
        }

        public IList<Despesa> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            return _iDespesa.ListarDespesasUsuarioNaoPagasMesesAnterior(emailUsuario);
        }
        //MÉDOTOS DE SERVIÇO 

        public void AdicionarDespesa(Despesa despesa)
        {
            _iDespesaServico.AdicionarDespesa(despesa);
        }

        public void AtualizarDespesa(Despesa despesa)
        {
            _iDespesaServico.AtualizarDespesa(despesa);
        }
        #endregion
    }
}
