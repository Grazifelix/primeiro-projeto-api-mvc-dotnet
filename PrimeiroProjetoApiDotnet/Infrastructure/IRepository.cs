
using PrimeiroProjetoApiDotnet.Model;

namespace PrimeiroProjetoApiDotnet.Infrastructure
{
    public interface IRepository
    {
        public List<Books> getAllBooks();
        public void save(Books book);
        public void delete(Books book);
        public void update(Books book);
        public Books searchBook(string title);

        public Books searchAuthor(string author);

    }
}
