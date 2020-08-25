using Application.Interfaces.ICategoriasApp;
using Domain.Interfaces.ICategorias;
using Domain.Interfaces.InterfaceServicos;
using Entity.Entities.Categorias;
using System.Collections.Generic;

namespace Application.App.CategriasApps
{
    public class AppCategoria : IAppCategoria
    {
        ICategoria _iCategoria;
        ICategoriaServico _iCategoriaServico;

        public AppCategoria(ICategoria iCategoria, ICategoriaServico iCategoriaServico)
        {
            _iCategoria = iCategoria;
            _iCategoriaServico = iCategoriaServico;
        }

        public void Add(Categoria Objeto)
        {
            _iCategoria.Add(Objeto);
        }

        public void Delete(Categoria Objeto)
        {
            _iCategoria.Delete(Objeto);
        }

        public Categoria GetEntityById(int Id)
        {
            return _iCategoria.GetEntityById(Id);
        }

        public List<Categoria> List()
        {
            return _iCategoria.List();
        }

        public void Update(Categoria Objeto)
        {
            _iCategoria.Update(Objeto);
        }

        #region MÉTODOS CUSTUMIZADOS
        public IList<Categoria> ListarCategoriasUsuario(string emailUsuario)
        {
            return _iCategoria.ListarCategoriasUsuario(emailUsuario);
        }

        public void AdicionarCategoria(Categoria categoria)
        {
            _iCategoriaServico.AdicionarCategoria(categoria);
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            _iCategoriaServico.AtualizarCategoria(categoria);
        }
        #endregion
    }
}
