using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexExample
{
    public class Book
    {
        string isbn, title, author, publisher;
        double price;

        public Book(string isbn, string title, string author, string publisher, double price)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.isbn;
                else if (index == 1)
                    return this.title;
                else if (index == 2)
                    return this.author;
                else if (index == 3)
                    return this.publisher;
                else if (index == 4)
                    return this.price;
                return null;
            }
            set
            {
                if (index == 0)
                    this.isbn = (string)value;
                else if (index == 1)
                    this.title = (string)value;
                else if (index == 2)
                    this.author = (string)value;
                else if (index == 3)
                    this.publisher = (string)value;
                else if (index == 4)
                    this.price = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("isbn"))
                    return this.isbn;
                if (attrName.ToLower().Equals("title"))
                    return this.title;
                if (attrName.ToLower().Equals("author"))
                    return this.author;
                if (attrName.ToLower().Equals("publisher"))
                    return this.publisher;
                if (attrName.ToLower().Equals("price"))
                    return this.price;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("isbn"))
                    this.isbn = (string)value;
                if (attrName.ToLower().Equals("title"))
                    this.title = (string)value;
                if (attrName.ToLower().Equals("author"))
                    this.author = (string)value;
                if (attrName.ToLower().Equals("publisher"))
                    this.publisher = (string)value;
                if (attrName.ToLower().Equals("price"))
                    this.price = (double)value;
            }
        }
    }
}
