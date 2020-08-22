using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entity.Entities.Sistemas;
using System;

namespace Domain.Services.SistemaServices
{
    public class SistemaFinanceiroService : ISistemaFinanceiroService
    {
        private readonly ISistemaFInanceiro _sistemaFInanceiro;

        public SistemaFinanceiroService(ISistemaFInanceiro sistemaFInanceiro)
        {
            _sistemaFInanceiro = sistemaFInanceiro;
        }

        public void AdicionarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            var valido = sistemaFinanceiro.ValidarPropriedadeString(sistemaFinanceiro.Nome, "Nome");

            if (valido)
            {
                var data = DateTime.Now;

                sistemaFinanceiro.DiaFechamento = 1;
                sistemaFinanceiro.Ano = data.Year;
                sistemaFinanceiro.Mes = data.Month;
                sistemaFinanceiro.AnoCopia = data.Year;
                sistemaFinanceiro.MesCopia = data.Month;
                sistemaFinanceiro.GerarCopiaDespesa = true;

                _sistemaFInanceiro.Add(sistemaFinanceiro);
            }
        }

        public void AtualizarSistemaFinanceiro(SistemaFinanceiro sistemaFinanceiro)
        {
            var valido = sistemaFinanceiro.ValidarPropriedadeString(sistemaFinanceiro.Nome, "Nome");

            if (valido)
                _sistemaFInanceiro.Update(sistemaFinanceiro);
        }
    }
}
 