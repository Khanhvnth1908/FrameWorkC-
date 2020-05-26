using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class Book
    {
        string bookName;

        public Book()
        {

        }

        public Book(string bookName)
        {
            this.bookName = bookName;
        }
        void Input()
        {
            bookName = Console.ReadLine();
        }

        string getName()
        {
            return bookName;
        }

       /*static void Main(string[] args)
        {
            Book book = new Book("New Thing");
            Console.WriteLine("Name book is " + book.getName());

            Book book1 = new Book();
            Console.WriteLine("Enter Name book : " );
            book1.Input();
            Console.WriteLine("Name book is " + book1.getName());
        }
        */
    }
}
