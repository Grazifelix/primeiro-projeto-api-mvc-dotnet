using PrimeiroProjetoApiDotnet.Model;

namespace PrimeiroProjetoApiDotnet.Infrastructure

{
    public class Repository:IRepository
    {
        private readonly List<Books> Books;
        public Repository() {
            Books = new List<Books>
            {
                new Books
                {
                    title = "Clean Code",
                    description = "Um guia de boas práticas para escrever código limpo e legível.",
                    author = "Robert C. Martin"
                },
                new Books
                {
                    title = "O Programador Pragmático",
                    description = "Conselhos práticos para se tornar um desenvolvedor melhor.",
                    author = "Andrew Hunt e David Thomas"
                },
                new Books
                {
                    title = "Domain-Driven Design",
                    description = "Abordagem para desenvolvimento de software focada no domínio.",
                    author = "Eric Evans"
                }

            };

        }

        public List<Books> getAllBooks()
        {
            return Books;
        }

        public void save(Books book) { 

            Books.Add(book);
        
        }
        public void delete(Books book) {
            Books.Remove(book);

        }
        public void update(Books book) {
            var bookToUpdate = Books.FirstOrDefault(oldBook => oldBook.title == book.title);

            if (bookToUpdate != null)
            {
                bookToUpdate.description = book.description;
                bookToUpdate.author = book.author;
            }

        }
        public Books searchBook(string title) {

            return Books.FirstOrDefault(book => book.title.Equals(title, StringComparison.OrdinalIgnoreCase));

        }

        public Books searchAuthor(string author) {
            return Books.FirstOrDefault(book => book.author.Equals(author, StringComparison.OrdinalIgnoreCase));
        }

    }
}
