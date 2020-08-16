using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.IUsuarioSistemaFInanceiro;
using Entity.Entities.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.SistemaService
{
    public class UsuarioSistemaFinanceiroServico : InterfaceUsuarioSistemaFinanceiroServico
    {
        private readonly InterfaceUsuarioSistemaFInanceiro _interfaceUsuarioSistemaFInanceiro;

        public UsuarioSistemaFinanceiroServico(InterfaceUsuarioSistemaFInanceiro interfaceUsuarioSistemaFInanceiro)
        {
            _interfaceUsuarioSistemaFInanceiro = interfaceUsuarioSistemaFInanceiro;
        }

        public void CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            _interfaceUsuarioSistemaFInanceiro.Add(usuarioSistemaFinanceiro);
        }
    }
}
