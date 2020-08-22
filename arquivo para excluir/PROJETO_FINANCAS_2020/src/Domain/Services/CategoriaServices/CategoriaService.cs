using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entity.Entities.Categorias;

namespace Domain.Services.CategoriaServices
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoria _iCategoria;
        private readonly IUsuarioSistemaFinanceiro _iUsusrioSistemaFinanceiro;

        public CategoriaService(ICategoria iCategoria, IUsuarioSistemaFinanceiro iUsusrioSistemaFinanceiro)
        {
            _iCategoria = iCategoria;
            _iUsusrioSistemaFinanceiro = iUsusrioSistemaFinanceiro;
        }
        public void AdicionarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            throw new System.NotImplementedException();
        }
    }
}
