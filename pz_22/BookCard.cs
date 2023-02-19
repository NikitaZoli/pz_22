using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class BookCard
    {
        enum Condition
        {
            ToWriteOff,
            Good,
            New
        }

        class BookCard
        {
            private int ID;
            private string author;
            private string title;
            private int year;
            private Condition condition;

            private static int booksToWriteOffCount;
            private static int goodBooksCount;
            private static int newBooksCount;

            public BookCard(int ID, string author, string title, int year, Condition condition)
            {
                this.ID = ID;
                this.author = !string.IsNullOrEmpty(author) ? author : throw new ArgumentException("Author name cannot be null or empty.");
                this.title = !string.IsNullOrEmpty(title) ? title : throw new ArgumentException("Title cannot be null or empty.");
                this.year = year >= 1990 ? year : throw new ArgumentOutOfRangeException("Year of publication cannot be earlier than 1990.");
                this.condition = condition;

                switch (condition)
                {
                    case Condition.ToWriteOff:
                        booksToWriteOffCount++;
                        break;
                    case Condition.Good:
                        goodBooksCount++;
                        break;
                    case Condition.New:
                        newBooksCount++;
                        break;
                }
            }

            public void GetBookInfo()
            {
                Console.WriteLine("ID: {0}\nAuthor: {1}\nTitle: {2}\nYear: {3}\nCondition: {4}", ID, author, title, year, condition);
            }

            public static void GetBookStats()
            {
                Console.WriteLine("Books to write off: {0}\nGood books: {1}\nNew books: {2}", booksToWriteOffCount, goodBooksCount, newBooksCount);
            }
        }
    }
}
