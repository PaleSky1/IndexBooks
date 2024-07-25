namespace IndexExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("9435903458304583050", "A Game Of Thrones", "George R R Martain", "HarperCollins Publishers UK", 350);
            Book book2 = new Book("2005564838304183434", "The Last Olympian", "Rick Riordan", "Puffin Books", 280);
            Book book3 = new Book("3248342093248923489", "Peter Pan", "J. M. Barrie ", "Puffin BooksPan Macmillan", 150);
            List <Book> lstBook = new List<Book>();

            lstBook.Add(book1);

            lstBook.Add(book2);

            lstBook.Add(book3);

            foreach (Book book in lstBook)
            {
                Console.WriteLine("\nMethod 1:\n");

                Console.WriteLine(book[0]);
                Console.WriteLine(book[1]);
                Console.WriteLine(book[2]);
                Console.WriteLine(book[3]);
                Console.WriteLine(book[4]);

                Console.WriteLine("\nMethod 2:\n");

                Console.WriteLine("ISBN: " + book["isbn"]);
                Console.WriteLine("Title: " + book["title"]);
                Console.WriteLine("Author: " + book["author"]);
                Console.WriteLine("Publisher: " + book["publisher"]);
                Console.WriteLine("Price: " + book["price"]);

                Console.WriteLine("");
            }

        }
    }
}
