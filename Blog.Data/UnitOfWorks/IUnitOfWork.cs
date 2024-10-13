using Blog.Core.Entities;
using Blog.Data.Repository.Abstract;
using Blog.Entity.Entities;

namespace Blog.Data.UnitOfWords
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
