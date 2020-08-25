using Domain.Interfaces.ICategorias;
using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ISistemas.IUsuarioSistemaFinanceiro;
using Entity.Entities.Categorias;

namespace Domain.Services.CategoriaServicos
{
    public class CategoriaServico : ICategoriaServico
    {
        private readonly IUsuarioSistemaFinanceiro _iUsuarioSistemaFinanceiro;
        private readonly ICategoria _iCategoria;

        public CategoriaServico(IUsuarioSistemaFinanceiro iUsuarioSistemaFinanceiro, ICategoria iCategoria)
        {
            _iUsuarioSistemaFinanceiro = iUsuarioSistemaFinanceiro;
            _iCategoria = iCategoria;
        }
        public void AdicionarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidaPropriedadeString(categoria.Nome, "Nome");
            if (valido)
            {
                _iCategoria.Add(categoria);
            }
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidaPropriedadeString(categoria.Nome, "Nome");
            if (valido)
            {
                _iCategoria.Update(categoria);
            }
        }
    }
}
