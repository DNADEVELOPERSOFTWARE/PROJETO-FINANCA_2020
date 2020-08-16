using Entity.Entities.Categorias;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface InterfaceCategoriaServico
    {
        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
    }
}
