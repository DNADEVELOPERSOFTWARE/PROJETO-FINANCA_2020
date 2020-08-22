using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entity.Entities.Fluxos.Despesas;
using System;

namespace Domain.Services.FluxoServco.DespesasServicos
{
    public class ItemCompraService : IitemCompraService
    {
        private readonly IitemCompra _iItemCompra;

        public ItemCompraService(IitemCompra iItemCompra)
        {
            _iItemCompra = iItemCompra;
        }

        public void AdicionarItemCompra(ItemCompra itemCompra)
        {
            var data = DateTime.Now;
            itemCompra.DataCadastro = data;
            itemCompra.DataAlteracao = DateTime.MinValue;
            itemCompra.DataCompra = DateTime.MinValue;

            var valido = itemCompra.ValidarPropriedadeString(itemCompra.Nome, "Nome");

            if (valido)
                _iItemCompra.Add(itemCompra);
        }

        public void AtualizarItemCompra(ItemCompra itemCompra)
        {

            var data = DateTime.Now;
            itemCompra.DataAlteracao = DateTime.MinValue;

            if (itemCompra.Comprado)
            {
                itemCompra.DataCompra = data;
            }

            var valido = itemCompra.ValidarPropriedadeString(itemCompra.Nome, "Nome");

            if (valido)
                _iItemCompra.Add(itemCompra);
        }
    }
}
