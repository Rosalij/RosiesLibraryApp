/*
    This class represents a Book in the library system.
    It includes properties for the book's ID, title, author, ISBN, publication year, and number of copies available.
*/
namespace RosiesLibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string ISBN { get; set; } = "";
    public int Year { get; set; }
    public int Copies { get; set; } = 1;
}
