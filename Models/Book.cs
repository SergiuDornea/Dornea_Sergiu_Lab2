using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Dornea_Sergiu_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Title must be filled.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Title must have at least 3 characters, and a maximmum of 150 characters.")]
        public string Title { get; set; }

        public int? AuthorID { get; set; }
        public Author? Author { get; set; } // nav property for author

        [Column(TypeName = "decimal(6, 2)")] [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
