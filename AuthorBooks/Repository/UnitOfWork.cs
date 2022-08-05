using AuthorBooks.Data;
using AuthorBooks.IRepository;
using System;
using System.Threading.Tasks;

namespace AuthorBooks.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Author> _authors;
        private IGenericRepository<Book> _books;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Author> Authors => _authors ??= new GenericRepository<Author>(_context);
        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
