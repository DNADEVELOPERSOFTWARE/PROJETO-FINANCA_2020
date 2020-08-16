using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Notifications
{
    public class Notifica
    {
        public Notifica()
        {
            notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifica> notificacoes;

        public bool ValidaPropriedadeString(string valor,string nomePropriedade) 
        {
            //VALIDA CAMPOS VAZIOS
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValidaPropriedadeInt(int valor, string nomePropriedade)
        {
            //VALIDA CAMPOS VAZIOS
            if (valor < 1 ||string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValidaPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            //VALIDA CAMPOS VAZIOS
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }
    }
}
