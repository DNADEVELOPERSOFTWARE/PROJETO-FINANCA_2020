using Application.Interfaces.IFluxosApp.IComprasApp;
using Domain.Interfaces.IFluxos.ICompras;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Compras;
using System;
using System.Collections.Generic;

namespace Application.App.FluxosApps.ComprasApps
{
    public class AppCompra : IAppCompra
    {
        ICompra _iCompra;
        ICompraServico _iCompraServico;
        public AppCompra(ICompra iCompra, ICompraServico iCompraServico)
        {
            _iCompra = iCompra;
            _iCompraServico = iCompraServico;
        }
        public void Add(Compra Objeto)
        {
            _iCompra.Add(Objeto);
        }

        public void Delete(Compra Objeto)
        {
            _iCompra.Delete(Objeto);
        }

        public void Update(Compra Objeto)
        {
            _iCompra.Update(Objeto);
        }
        public Compra GetEntityById(int Id)
        {
            return _iCompra.GetEntityById(Id);
        }

        public List<Compra> List()
        {
            return _iCompra.List();
        }

        #region MÉTODOS CUSTUMIZADOS

        public IList<Compra> ListarComprasUsuario(string emailUsuario)
        {
            return _iCompra.ListarComprasUsuario(emailUsuario);
        }

         //MÉTODOS DE SERVIÇO
        public void AdicionarCompra(Compra compra)
        {
            _iCompraServico.AdicionarCompra(compra);
        }

        public void AtualizarCompra(Compra compra)
        {
            _iCompraServico.AtualizarCompra(compra);
        }

        #endregion
    }
}
