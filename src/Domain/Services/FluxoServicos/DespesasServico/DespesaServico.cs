using Domain.Interfaces.IDespesas;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Fluxos.Despesa;
using System;

namespace Domain.Services.FluxoServicos.DespesasServico
{
    public class DespesaServico : InterfaceDespesaServico
    {
        private readonly InterfaceDespesa _interfaceDespesa;
        public DespesaServico(InterfaceDespesa interfaceDespesa)
        {
            _interfaceDespesa = interfaceDespesa;
        }

        public void AdicionarDespesa(Despesa despesa)
        {
            var data = DateTime.Now;
            despesa.DataCadastro = data;
            despesa.Ano = data.Year;
            despesa.Mes = data.Month;

            var valido = despesa.ValidaPropriedadeString(despesa.Nome, "Nome");
            if (valido)
                _interfaceDespesa.Add(despesa);

        }

        public void AtualizarDespesa(Despesa despesa)
        {
            var data = DateTime.Now;
            despesa.DataAlteracao = data;
            if (despesa.Pago)
            {
                despesa.DataPagamento = data;
            }


            var valido = despesa.ValidaPropriedadeString(despesa.Nome, "Nome");
            if (valido)
                _interfaceDespesa.Add(despesa);

        }
    }
}
