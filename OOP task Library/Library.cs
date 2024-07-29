using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_Library
{
    public class Library
    {
        public string Name { get; set; }
        private List<Book> books; //= new List<Book>();

        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                book.Print();
            }
        }
        public Library(string libraryName)
        {
            Name = libraryName;
            books = new List<Book>();

        }
        public void AddBook(Book book)
        {
            if (books.Count >= 5)
            {
                Console.WriteLine("ERROR --> max value is 5");
            }
            else
            {
                books.Add(book);
                Console.WriteLine($"Congratulations! Your book with ID {book.Id} was succesfully added to library");
            }
        }
        public void RemoveBook(int id) //removing book by id
        {
            Book removedBook = null;
            foreach (Book book in books)
            {
                if (book.Id == id)
                {
                    removedBook = book;
                    break;
                }
            }
            if (removedBook != null)
            {
                books.Remove(removedBook);
                Console.WriteLine($"Success! Your book with ID {id} was removed");
            }
            else
            {
                Console.WriteLine($"Failure! Book with ID {id} does not exist");
            }
        }      

    }
}