using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entity.Entities.Fluxos.Despesas;
using System;

namespace Domain.Services.FluxoServco.DespesasServicos
{
    public class CompraService : ICompraService
    {
        private readonly ICompra _compra;
        public CompraService(ICompra compra)
        {
            _compra = compra;
        }

        public void AdicionarCompra(Compra compra)
        {
            var data = DateTime.Now;
            compra.DataCadastro = data;

            var valido = compra.ValidarPropriedadeString(compra.Nome, "Nome");

            if (valido)
                _compra.Add(compra);

        }

        public void AtualizarCompra(Compra compra)
        {
            var data = DateTime.Now;
            compra.DataAlteracao = data;

            var valido = compra.ValidarPropriedadeString(compra.Nome, "Nome");

            if (valido)
                _compra.Update(compra);
        }


    }
}
