using Application.Interfaces.IFluxosApp.IComprasApp;
using Domain.Interfaces.IFluxos.ICompras;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Compras;
using System;
using System.Collections.Generic;

namespace Application.App.FluxosApps.ComprasApps
{
    public class AppItemCompra : IAppItemCompra
    {
        IItemCompra _iItemCompra;
        IItemCompraServico _iItemCompraServico;

        public AppItemCompra(IItemCompra iItemCompra, IItemCompraServico iItemCompraServico)
        {
            _iItemCompra = iItemCompra;
            _iItemCompraServico = iItemCompraServico;
        }

        public void Add(ItemCompra Objeto)
        {
            _iItemCompra.Add(Objeto);
        }

        public void Delete(ItemCompra Objeto)
        {
            _iItemCompra.Delete(Objeto);
        }

        public ItemCompra GetEntityById(int Id)
        {
            return _iItemCompra.GetEntityById(Id);
        }

        public List<ItemCompra> List()
        {
            return _iItemCompra.List();
        }

        public void Update(ItemCompra Objeto)
        {
            _iItemCompra.Update(Objeto);
        }

        #region MÉTODOS CUSTUMIZADOS
        public void AtualizarItemCompra(ItemCompra ItemCompra)
        {
            _iItemCompra.AtualizarItemCompra(ItemCompra);
        }
        public void DeletarItemPorId(int Id)
        {
            throw new NotImplementedException();
        }
        public IList<ItemCompra> ListarItensDaCompra(int IdCompra)
        {
            throw new NotImplementedException();
        }
        //MÉTODOS DE SERVIÇOS
        public void AdicionarItemCompra(ItemCompra ItemCompra)
        {
            _iItemCompraServico.AdicionarItemCompra(ItemCompra);
        }
        public void AtualizarItemCompraServico(ItemCompra ItemCompra)
        {
            _iItemCompraServico.AtualizarItemCompra(ItemCompra);
        }
        #endregion
    }
}
