using Domain.Interfaces.ICompras;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Compras;
using System;

namespace Domain.Services.FluxoServicos.ComprasServicos
{
    public class ItemCompraServico : InterfaceItemCompraServico
    {
        private readonly InterfaceItemCompra _interfaceItemCompra;
        public ItemCompraServico(InterfaceItemCompra interfaceItemCompra)
        {
            _interfaceItemCompra = interfaceItemCompra;
        }

        public void AdicionarItemCompra(ItemCompra itemCompra)
        {
            var data = DateTime.Now;
            itemCompra.DataCadastro = data;
            itemCompra.DataAlteracao = DateTime.MinValue;
            itemCompra.DataCompra = DateTime.MinValue;

            var valido = itemCompra.ValidaPropriedadeString(itemCompra.Nome, "Nome");

            if (valido)
                _interfaceItemCompra.Add(itemCompra);
        }

        public void AtualizarItemCompra(ItemCompra itemCompra)
        {
            var data = DateTime.Now;
            itemCompra.DataAlteracao = data;

            if (itemCompra.Comprado)
            {
                itemCompra.DataCompra = data;
            }

            var valido = itemCompra.ValidaPropriedadeString(itemCompra.Nome, "Nome");
            if (valido)
                _interfaceItemCompra.Update(itemCompra);
        }
    }
}
