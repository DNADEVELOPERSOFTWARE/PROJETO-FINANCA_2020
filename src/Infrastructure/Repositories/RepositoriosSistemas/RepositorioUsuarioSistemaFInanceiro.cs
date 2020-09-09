using Domain.Interfaces.ISistemas.IUsuarioSistemaFinanceiro;
using Entity.Entities.Sistemas;
using Infrastructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.RepositoriosSistemas
{
    public  class RepositorioUsuarioSistemaFinanceiro : RepositorioGenerico<UsuarioSistemaFinanceiro>, IUsuarioSistemaFinanceiro
    {
        private readonly DbContextOptions<Contexto> _OptionsBuilder;

        public RepositorioUsuarioSistemaFinanceiro()
        {
            _OptionsBuilder = new DbContextOptions<Contexto>();
        }

        public IList<UsuarioSistemaFinanceiro> ListarUsuariosSistema(int IdSistema)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {

                var sistemasusuario = banco.UsuarioSistemaFinanceiro
                    .Where(s => s.IdSistema == IdSistema)
                    .ToList();
                return sistemasusuario;
            }
        }

        public UsuarioSistemaFinanceiro ObterUsuarioPorEmail(string EmailUsuario)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {
                return banco.UsuarioSistemaFinanceiro.Where(u => u.EmailUsuario == EmailUsuario).FirstOrDefault();
            }
        }

        public void RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
        {
            using (var banco = new Contexto(_OptionsBuilder))
            {

                banco.UsuarioSistemaFinanceiro
                   .RemoveRange(usuarios);
                banco.SaveChanges();
            }
        }
    }
}
