using Entity.Entities.Categorias;
using System.Collections.Generic;

namespace Application.Interfaces.ICategoriasApp
{
    public interface IAppCategoria : IGenericaApp<Categoria>
    {
        IList<Categoria> ListarCategoriasUsuario(string emailUsuario);

        void AdicionarCategoria(Categoria categoria);
        void AtualizarCategoria(Categoria categoria);
    }
}
