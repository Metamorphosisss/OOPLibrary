using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_Library
{
    public class Library
    {
        public string Name { get; set; }
        private List<Book> books;

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
                throw new InvalidOperationException("ERROR --> max value is 5");
            }
            foreach (Book existingbook in books)
            {
                if (book.Id == existingbook.Id)
                {
                    throw new ArgumentException($"Book with {book.Id} already exists in this library");
                }
            }
            books.Add(book);
            Console.WriteLine($"Congratulations! Your book with ID {book.Id} was succesfully added to library");
        }

        public void RemoveBook(int id)
        {
            int removedCount = books.RemoveAll(book => book.Id == id);

            if (removedCount == 0)
            {
                throw new ArgumentException($"Book with ID {id} was not found");
            }
            else
            {
                Console.WriteLine($"Book with ID {id} was removed from library");
            }
        }

        public Book FindBookById(int id)
        {
            var book = books.FirstOrDefault(book => book.Id == id);

            if (book == null)
            {
                throw new ArgumentException($"Book with ID {id} was not found");
            }

            return book;
        }
        public List<Book> FindBookByAuthor(string author)
        {
            List<Book> booksByAuthor = books.Where(book => book.Author == author).ToList();
            if (booksByAuthor.Count == 0)
            {
                throw new ArgumentException($"Books by {author} were not found");
            }
            return booksByAuthor;
        }       
    }
}




