using Entity.Entities.Categorias;

namespace Domain.Interfaces.IServices
{
    public interface ICategoriaService
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
    }
}
