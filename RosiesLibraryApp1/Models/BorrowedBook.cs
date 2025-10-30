/*
   This code defines a BorrowedBook class.
   The class includes properties to represent the details of a borrowed book, such as
   the user ID, book ID, title, author, ISBN, borrow date, and return date.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RosiesLibraryApp.Models
{
    public class BorrowedBook
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }
    }
}