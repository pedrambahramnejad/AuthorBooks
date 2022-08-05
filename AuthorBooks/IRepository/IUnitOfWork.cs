using AuthorBooks.Data;
using System;
using System.Threading.Tasks;

namespace AuthorBooks.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Author> Authors { get; }
        IGenericRepository<Book> Books { get; }
        Task Save();
    }
}
