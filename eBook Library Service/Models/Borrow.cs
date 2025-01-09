using System.ComponentModel.DataAnnotations;

namespace eBook_Library_Service.Models
{
    public class Borrow
    {
        [Key]
        public int BorrowId { get; set; }
        public string UserId { get; set; } // Link to the user who borrowed the book
        public int BookId { get; set; } // Link to the borrowed book
        public DateTime BorrowDate { get; set; } // When the book was borrowed
        public DateTime DueDate { get; set; } // When the book is due for return
        public bool IsReturned { get; set; } // Indicates if the book has been returned
        public Book Book { get; set; }
    }
}
