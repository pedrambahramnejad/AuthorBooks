using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorBooks.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
