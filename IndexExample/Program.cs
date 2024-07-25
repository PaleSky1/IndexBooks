namespace IndexExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 10.99);

            Console.WriteLine(book[0]);
            Console.WriteLine(book[1]);
            Console.WriteLine(book[2]);
            Console.WriteLine(book[3]);
            Console.WriteLine(book[4]);

            Console.WriteLine("ISBN: " + book["isbn"]);
            Console.WriteLine("Title: " + book["title"]);
            Console.WriteLine("Author: " + book["author"]);
            Console.WriteLine("Publisher: " + book["publisher"]);
            Console.WriteLine("Price: " + book["price"]);
        }
    }
}
