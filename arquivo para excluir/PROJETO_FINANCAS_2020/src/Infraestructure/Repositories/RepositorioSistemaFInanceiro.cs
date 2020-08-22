using Domain.Interfaces;
using Entity.Entities.Sistemas;
using Infraestructure.Configurations.Data;
using Infraestructure.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repositories
{
    public class RepositorioSistemaFinanceiro : RepositorioGenerico<SistemaFinanceiro>, ISistemaFInanceiro
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositorioSistemaFinanceiro()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }


        public IList<SistemaFinanceiro> ListaSistemasUsuario(string emailUsuario)
        {
            using (var banco = new Contexto(_OptionsBuilder))
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
