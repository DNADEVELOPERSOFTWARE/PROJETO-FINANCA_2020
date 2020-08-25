using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ISistemas.ISistemaFinanceiro;
using Entity.Entities.Sistemas;
using System;

namespace Domain.Services.SistemaService
{
    public class SistemaFinanceiroService : ISistemaFinanceiroServico
    {
        private readonly ISistemaFinanceiro _iSistemaFinanceiro;

        public SistemaFinanceiroService(ISistemaFinanceiro iSistemaFinanceiro)
        {
            _iSistemaFinanceiro = iSistemaFinanceiro;
        }

        public void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            var valido = sistemaFinanceiro.ValidaPropriedadeString(sistemaFinanceiro.Nome, "Nome");

            if (valido)
            {
                var data = DateTime.Now;

                sistemaFinanceiro.DiaFechamento = 1;
                sistemaFinanceiro.Ano = data.Year;
                sistemaFinanceiro.Mes = data.Month;
                sistemaFinanceiro.AnoCopia = data.Year;
                sistemaFinanceiro.MesCopia = data.Month;
                sistemaFinanceiro.GerarCopiaDespesa = true;

                _iSistemaFinanceiro.Add(sistemaFinanceiro);
            }
        }

        public void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            var valido = sistemaFinanceiro.ValidaPropriedadeString(sistemaFinanceiro.Nome, "Nome");

            if (valido)
            {
                sistemaFinanceiro.DiaFechamento = 1;
                _iSistemaFinanceiro.Update(sistemaFinanceiro);
            }
        }
    }
}
