using WebApplDay9.Models;

namespace WebApplDay9.Services
{
    public interface IBookService
    {
        public Task<List<Book>> GetAll();
        public Task AddBook(Book book);
        public Task DeleteBook(Book book);
        public Task<Book> GetBook(int id);
    }
}
