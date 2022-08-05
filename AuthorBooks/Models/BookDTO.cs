using System.ComponentModel.DataAnnotations;

namespace AuthorBooks.Models
{

    public class CreateBookDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Book Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Genre Name Is Too Long")]
        public string Genre { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int AuthorId { get; set; }
    }

    public class BookDTO : CreateBookDTO
    {
        public int Id { get; set; }
        public AuthorDTO Author { get; set; }
    }
}