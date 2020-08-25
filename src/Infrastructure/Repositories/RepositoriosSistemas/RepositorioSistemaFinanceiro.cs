using Domain.Interfaces.ISistemas.ISistemaFinanceiro;
using Entity.Entities.Sistemas;
using Infrastructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.RepositoriosSistemas
{
    public class RepositorioSistemaFinanceiro : RepositorioGenerico<SistemaFinanceiro>, ISistemaFinanceiro
    {
        private readonly DbContextOptions<Contexto> _OptionBuilder;

        public RepositorioSistemaFinanceiro()
        {
            _OptionBuilder = new DbContextOptions<Contexto>();
        }

        public IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario)
        {
            using (var banco = new Contexto(_OptionBuilder))
            {
                var sistemasusuario = (from S in banco.SistemaFinanceiro
                                       join US in banco.UsuarioSistemaFinanceiro on
                                        S.Id equals US.IdSistema
                                       where US.EmailUsuario.Equals(emailUsuario)
                                       select S).ToList();

                return sistemasusuario; 
            }
        }
    }
}
