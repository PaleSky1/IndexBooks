using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IndexExample.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            Book book = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 10.99);
            Assert.AreEqual("978-3-16-148410-0", book["isbn"]);
            Assert.AreEqual("The Great Gatsby", book["title"]);
            Assert.AreEqual("F. Scott Fitzgerald", book["author"]);
            Assert.AreEqual("Scribner", book["publisher"]);
            Assert.AreEqual(10.99, book["price"]);
        }

        [TestMethod]
        public void TestIndexerByIndex()
        {
            Book book = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 10.99);
            Assert.AreEqual("978-3-16-148410-0", book[0]);
            Assert.AreEqual("The Great Gatsby", book[1]);
            Assert.AreEqual("F. Scott Fitzgerald", book[2]);
            Assert.AreEqual("Scribner", book[3]);
            Assert.AreEqual(10.99, book[4]);
        }

        [TestMethod]
        public void TestSetIndexerByIndex()
        {
            Book book = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 10.99);
            book[0] = "978-0-123-45678-9";
            book[1] = "1984";
            book[2] = "George Orwell";
            book[3] = "Secker & Warburg";
            book[4] = 15.99;
            Assert.AreEqual("978-0-123-45678-9", book[0]);
            Assert.AreEqual("1984", book[1]);
            Assert.AreEqual("George Orwell", book[2]);
            Assert.AreEqual("Secker & Warburg", book[3]);
            Assert.AreEqual(15.99, book[4]);
        }

        [TestMethod]
        public void TestSetIndexerByString()
        {
            Book book = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 10.99);
            book["isbn"] = "978-0-123-45678-9";
            book["title"] = "1984";
            book["author"] = "George Orwell";
            book["publisher"] = "Secker & Warburg";
            book["price"] = 15.99;
            Assert.AreEqual("978-0-123-45678-9", book["isbn"]);
            Assert.AreEqual("1984", book["title"]);
            Assert.AreEqual("George Orwell", book["author"]);
            Assert.AreEqual("Secker & Warburg", book["publisher"]);
            Assert.AreEqual(15.99, book["price"]);
        }
        [TestMethod]
        public void TestInvalidIndex()
        {
            Book book = new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald", "Scribner", 10.99);
            Assert.IsNull(book[5]); // Invalid index
            Assert.IsNull(book[-1]); // Invalid index
            Assert.IsNull(book["invalid"]); // Invalid attribute name
        }
    }
}