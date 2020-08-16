using Domain.Interfaces.ICategorias;
using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.IUsuarioSistemaFInanceiro;
using Entity.Entities.Categorias;

namespace Domain.Services.CategoriaServicos
{
    public class CategoriaServico : InterfaceCategoriaServico
    {
        private readonly InterfaceUsuarioSistemaFInanceiro _interfaceUsuarioSistemaFinanceiro;
        private readonly InterfaceCategoria _interfaceCategoria;

        public CategoriaServico(InterfaceUsuarioSistemaFInanceiro interfaceUsuarioSistemaFinanceiro, InterfaceCategoria interfaceCategoria)
        {
            _interfaceUsuarioSistemaFinanceiro = interfaceUsuarioSistemaFinanceiro;
            _interfaceCategoria = interfaceCategoria;
        }
        public void AdicionarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidaPropriedadeString(categoria.Nome, "Nome");
            if (valido)
            {
                _interfaceCategoria.Add(categoria);
            }
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidaPropriedadeString(categoria.Nome, "Nome");
            if (valido)
            {
                _interfaceCategoria.Update(categoria);
            }
        }
    }
}
