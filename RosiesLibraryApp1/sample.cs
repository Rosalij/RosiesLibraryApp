using RosiesLibraryApp.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace RosiesLibraryApp.Data;

public static class DatabaseSeeder
{
    public static void Seed(Database db)
    {
        //Check if table has any books
        using var conn = new SqliteConnection(db.ConnectionString);
        conn.Open();

        using var checkCmd = new SqliteCommand("SELECT COUNT(*) FROM Books", conn);
        long count = (long)checkCmd.ExecuteScalar();

        if (count > 0)
        {
            //Table already has books. do nothing
            return;
        }

        //Table is empty, add sample books
        var bookRepo = new BookRepository(db);


        var books = new List<Book>
        {
            new Book { Title = "1984", Author = "George Orwell", ISBN = "9780451524935", Year = 1949, Copies = 3 },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", ISBN = "9780141199078", Year = 1813, Copies = 2 },
            new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", ISBN = "9780345339683", Year = 1937, Copies = 4 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", ISBN = "9780060935467", Year = 1960, Copies = 2 },
            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", ISBN = "9780316769488", Year = 1951, Copies = 1 },
       new Book { Title = "Brave New World", Author = "Aldous Huxley", ISBN = "9780060850524", Year = 1932, Copies = 3 },
new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "9780743273565", Year = 1925, Copies = 2 },
new Book { Title = "Moby Dick", Author = "Herman Melville", ISBN = "9780142437247", Year = 1851, Copies = 2 },
new Book { Title = "War and Peace", Author = "Leo Tolstoy", ISBN = "9780199232765", Year = 1869, Copies = 1 },
new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", ISBN = "9780143058144", Year = 1866, Copies = 2 },
new Book { Title = "The Odyssey", Author = "Homer", ISBN = "9780140268867", Year = -700, Copies = 3 },
new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", ISBN = "9780141441146", Year = 1847, Copies = 2 },
new Book { Title = "Wuthering Heights", Author = "Emily Brontë", ISBN = "9780141439556", Year = 1847, Copies = 2 },
new Book { Title = "Frankenstein", Author = "Mary Shelley", ISBN = "9780141439471", Year = 1818, Copies = 1 },
new Book { Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", ISBN = "9780618640157", Year = 1954, Copies = 3 },
new Book { Title = "Great Expectations", Author = "Charles Dickens", ISBN = "9780141439563", Year = 1861, Copies = 2 },
new Book { Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", ISBN = "9780374528379", Year = 1880, Copies = 1 },
new Book { Title = "Les Misérables", Author = "Victor Hugo", ISBN = "9780451419439", Year = 1862, Copies = 2 },
new Book { Title = "Anna Karenina", Author = "Leo Tolstoy", ISBN = "9780143035008", Year = 1877, Copies = 2 },
new Book { Title = "Dracula", Author = "Bram Stoker", ISBN = "9780141439846", Year = 1897, Copies = 1 },
new Book { Title = "The Iliad", Author = "Homer", ISBN = "9780140275360", Year = -750, Copies = 2 },
new Book { Title = "The Divine Comedy", Author = "Dante Alighieri", ISBN = "9780140448955", Year = 1320, Copies = 1 },
new Book { Title = "The Canterbury Tales", Author = "Geoffrey Chaucer", ISBN = "9780140424386", Year = 1400, Copies = 1 },
new Book { Title = "Meditations", Author = "Marcus Aurelius", ISBN = "9780812968255", Year = 180, Copies = 1 },
new Book { Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", ISBN = "9780141439570", Year = 1890, Copies = 2 },
new Book { Title = "Don Quixote", Author = "Miguel de Cervantes", ISBN = "9780060934347", Year = 1615, Copies = 2 },
new Book { Title = "The Count of Monte Cristo", Author = "Alexandre Dumas", ISBN = "9780140449266", Year = 1844, Copies = 2 },
new Book { Title = "The Sun Also Rises", Author = "Ernest Hemingway", ISBN = "9780743297332", Year = 1926, Copies = 2 },
new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", ISBN = "9780060883287", Year = 1967, Copies = 3 },
new Book { Title = "Catch-22", Author = "Joseph Heller", ISBN = "9781451626650", Year = 1961, Copies = 2 },
new Book { Title = "Slaughterhouse-Five", Author = "Kurt Vonnegut", ISBN = "9780440180296", Year = 1969, Copies = 2 },
new Book { Title = "The Grapes of Wrath", Author = "John Steinbeck", ISBN = "9780143039433", Year = 1939, Copies = 2 },
new Book { Title = "Beloved", Author = "Toni Morrison", ISBN = "9781400033416", Year = 1987, Copies = 2 },
new Book { Title = "The Stranger", Author = "Albert Camus", ISBN = "9780679720201", Year = 1942, Copies = 2 },
new Book { Title = "Lolita", Author = "Vladimir Nabokov", ISBN = "9780679723165", Year = 1955, Copies = 1 },
new Book { Title = "Heart of Darkness", Author = "Joseph Conrad", ISBN = "9780141441672", Year = 1899, Copies = 2 },
new Book { Title = "Ulysses", Author = "James Joyce", ISBN = "9780141182803", Year = 1922, Copies = 1 },
new Book { Title = "A Tale of Two Cities", Author = "Charles Dickens", ISBN = "9780141439600", Year = 1859, Copies = 2 },
new Book { Title = "Macbeth", Author = "William Shakespeare", ISBN = "9780743477109", Year = 1606, Copies = 2 },
new Book { Title = "Hamlet", Author = "William Shakespeare", ISBN = "9780743477123", Year = 1603, Copies = 2 },
new Book { Title = "Othello", Author = "William Shakespeare", ISBN = "9780743477550", Year = 1603, Copies = 1 },
new Book { Title = "King Lear", Author = "William Shakespeare", ISBN = "9780743477124", Year = 1606, Copies = 1 },
new Book { Title = "The Metamorphosis", Author = "Franz Kafka", ISBN = "9780553213690", Year = 1915, Copies = 2 },
new Book { Title = "The Trial", Author = "Franz Kafka", ISBN = "9780805209990", Year = 1925, Copies = 1 },
new Book { Title = "Invisible Man", Author = "Ralph Ellison", ISBN = "9780679732761", Year = 1952, Copies = 2 },
new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", ISBN = "9781451673319", Year = 1953, Copies = 3 }
        };

        foreach (var book in books)
        {
            bookRepo.AddBook(book);
        }
    }
}