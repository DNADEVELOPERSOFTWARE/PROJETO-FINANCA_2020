using Domain.Interfaces;
using Infraestructure.Configurations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Infraestructure.Repositories.Generics
{
    public class RepositorioGenerico<T> : IGenerica<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Contexto> _optionsBuilder;

        public RepositorioGenerico()
        {
            _optionsBuilder = new DbContextOptions<Contexto>();
        }

        public async Task Add(T Objeto)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                await banco.Set<T>().AddAsync(Objeto);
                await banco.SaveChangesAsync();
            }
        }

        public async Task Delete(T Objeto)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                banco.Set<T>().Remove(Objeto);
                await banco.SaveChangesAsync();
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                return await banco.Set<T>().FindAsync(id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                return await banco.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task Update(T Objeto)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                banco.Set<T>().Update(Objeto);
                await banco.SaveChangesAsync();
            }
        }

        #region Dispose https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }

        ~RepositorioGenerico()
        {
            Dispose(false);
        }

        #endregion
    }
}
