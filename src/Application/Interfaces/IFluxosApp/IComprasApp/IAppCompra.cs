using Entity.Entities.Fluxos.Compras;
using System.Collections.Generic;

namespace Application.Interfaces.IFluxosApp.IComprasApp
{
    public interface IAppCompra : IGenericaApp<Compra>
    {
        void AdicionarCompra(Compra compra);
        void AtualizarCompra(Compra compra);
        IList<Compra> ListarComprasUsuario(string emailUsuario);
    }
}
