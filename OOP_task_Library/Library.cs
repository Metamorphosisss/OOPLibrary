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
             Book bookToRemove = null;

                foreach (var book in books)
                {
                    if (book.Id == id)
                    {
                        bookToRemove = book;
                        break;
                    }
                }


                if (bookToRemove == null)
                {
                    throw new ArgumentException($"Your book with ID {id} cannot be found.");
                }

                books.Remove(bookToRemove);
                Console.WriteLine($"Your book with ID {id} was successfully removed from the library.");
            }
            
        


    }
}
