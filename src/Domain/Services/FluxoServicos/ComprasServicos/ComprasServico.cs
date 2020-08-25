using Domain.Interfaces.IFluxos.ICompras;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Compras;
using System;

namespace Domain.Services.FluxoServicos.ComprasServicos
{
    public class ComprasServico : ICompraServico
    {
        private readonly ICompra _iCompra;

        public ComprasServico(ICompra iCompra)
        {
            _iCompra = iCompra;
        }

        public void AdicionarCompra(Compra compra)
        {
            var data = DateTime.Now;
            compra.DataCadastro = data;

            var valido = compra.ValidaPropriedadeString(compra.Nome, "Nome");
            if (valido)
            {
                _iCompra.Add(compra);
            }
        }

        public void AtualizarCompra(Compra compra)
        {
            var data = DateTime.Now;
            compra.DataCadastro = data;

            var valido = compra.ValidaPropriedadeString(compra.Nome, "Nome");
            if (valido)
            {
                _iCompra.Update(compra);
            }
        }
    }
}
