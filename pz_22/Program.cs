// See https://aka.ms/new-console-template for more information
using pz_22;

class Program
{
    static void Main(string[] args)
    {
        BookCard book1 = new BookCard(1, "Jane Austen", "Pride and Prejudice", 1813, Condition.Good);
        BookCard book2 = new BookCard(2, "Fyodor Dostoevsky", "Crime and Punishment", 1866, Condition.ToWriteOff);
        BookCard book3 = new BookCard(3, "Harper Lee", "To Kill a Mockingbird", 1960, Condition.New);

        book1.GetBookInfo();
        Console.WriteLine();
        book2.GetBookInfo();
        Console.WriteLine();
        book3.GetBookInfo();
        Console.WriteLine();

        BookCard.GetBookStats();
    }
}

