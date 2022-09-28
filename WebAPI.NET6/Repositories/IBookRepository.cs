using WebAPIProject.Models;

namespace WebAPIProject.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get(); //get all books
        Task<Book?> Get(int id); //get a book by id
        Task<Book> Create(Book book); 
        Task Update(Book book); 
        Task Delete(int id); 
    }
}
