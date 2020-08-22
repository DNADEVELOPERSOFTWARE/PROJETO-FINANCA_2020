using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entity.Entities.Fluxos.Despesas;
using System;

namespace Domain.Services.FluxoServco.DespesasServicos
{
    public class DespesaServico : IDespesaService
    {
        private readonly IDespesa _iDespesa;

        public DespesaServico(IDespesa iDespesa)
        {
            _iDespesa = iDespesa;
        }

        public void AdicionarDespesa(Despesa despesa)
        {
            var data = DateTime.Now;
            despesa.DataCadastro = data;
            despesa.Ano = data.Year;
            despesa.Mes = data.Month;

            var valido = despesa.ValidarPropriedadeString(despesa.Nome, "Nome");

            if (valido)
                _iDespesa.Add(despesa);
        }

        public void AtualizarDespesa(Despesa despesa)
        {
            var data = DateTime.Now;
            despesa.DataAlteracao = data;

            if (despesa.Pago)
            {
                despesa.DataPagamento = data;
            }

            var valido = despesa.ValidarPropriedadeString(despesa.Nome, "Nome");

            if (valido)
                _iDespesa.Update(despesa);
        }
    }
}
