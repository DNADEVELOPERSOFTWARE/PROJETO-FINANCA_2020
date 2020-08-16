using Domain.Interfaces.IGenerics;
using Entity.Entities.Categorias;
using System.Collections.Generic;

namespace Domain.Interfaces.ICategorias
{
    public interface InterfaceCategoria : InterfaceGenerica<Categoria>
    {
        IList<Categoria> ListarCategoriasUsuario(string emailUsuario);
    }
}
