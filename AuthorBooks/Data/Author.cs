using System.Collections.Generic;

namespace AuthorBooks.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}
