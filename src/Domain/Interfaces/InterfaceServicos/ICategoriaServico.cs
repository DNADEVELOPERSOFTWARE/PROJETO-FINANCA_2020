using Entity.Entities.Categorias;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface ICategoriaServico
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
    }
}
