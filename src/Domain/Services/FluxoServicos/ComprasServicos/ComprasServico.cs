using Domain.Interfaces.ICompras;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Compras;
using System;

namespace Domain.Services.FluxoServicos.ComprasServicos
{
    public class ComprasServico : InterfaceCompraServico
    {
        private readonly InterfaceCompra _interfaceCompra;

        public ComprasServico(InterfaceCompra interfaceCompra)
        {
            _interfaceCompra = interfaceCompra;
        }

        public void AdicionarCompra(Compra compra)
        {
            var data = DateTime.Now;
            compra.DataCadastro = data;

            var valido = compra.ValidaPropriedadeString(compra.Nome, "Nome");
            if (valido)
            {
                _interfaceCompra.Add(compra);
            }
        }

        public void AtualizarCompra(Compra compra)
        {
            var data = DateTime.Now;
            compra.DataCadastro = data;

            var valido = compra.ValidaPropriedadeString(compra.Nome, "Nome");
            if (valido)
            {
                _interfaceCompra.Update(compra);
            }
        }
    }
}
