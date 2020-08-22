using Entity.Entities.Categorias;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ICategoria
    {
        IList<Categoria> ListarCategoriasUsuario(string emailUsuario);
    }
}
