using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IGenericaApp<T> where T : class
    {
        void Add(T Objeto);
        void Update(T Objeto);
        void Delete(T Objeto);
        T GetEntityById(int Id);
        List<T> List();
    }
}
