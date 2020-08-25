using Application.Interfaces.ISugestoesApps;
using Domain.ISugestao;
using Entity.Entities;
using System.Collections.Generic;

namespace Application.App.SugestoesApps
{
    public class AppSugestao : IAppSugestao
    {
        ISugestao _iSugestao;

        public AppSugestao(ISugestao iSugestao)
        {
            _iSugestao = iSugestao;
        }

        public void Add(Sugestao Objeto)
        {
            _iSugestao.Add(Objeto);
        }

        public void Delete(Sugestao Objeto)
        {
            _iSugestao.Delete(Objeto);
        }

        public Sugestao GetEntityById(int Id)
        {
          return  _iSugestao.GetEntityById(Id);
        }

        public List<Sugestao> List()
        {
          return  _iSugestao.List();
        }

        public void Update(Sugestao Objeto)
        {
            _iSugestao.Update(Objeto);
        }
    }
}
