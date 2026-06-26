using Microsoft.EntityFrameworkCore;
using WebApplDay9.Data;
using WebApplDay9.Models;

namespace WebApplDay9.Services
{
    public class BookService : IBookService
    {
        private readonly Day9DbContext _context;
        

        public BookService(Day9DbContext context) {
            _context = context;
           
        }

        public Task AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public Task<Book> GetBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
