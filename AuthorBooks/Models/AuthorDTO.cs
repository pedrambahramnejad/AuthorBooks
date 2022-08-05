using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorBooks.Models
{
    public class CreateAuthorDTO
    {
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = " Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Nationality { get; set; }
    }
    public class AuthorDTO : CreateAuthorDTO
    {
        public int Id { get; set; }
        public IList<BookDTO> Books { get; set; }
    }
}
