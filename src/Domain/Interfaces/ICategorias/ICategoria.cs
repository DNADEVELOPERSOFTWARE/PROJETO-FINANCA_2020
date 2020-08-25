using Entity.Entities.Categorias;
using System.Collections.Generic;

namespace Domain.Interfaces.ICategorias
{
    public interface ICategoria : IGenerica<Categoria>
    {
        IList<Categoria> ListarCategoriasUsuario(string emailUsuario);
    }
}
