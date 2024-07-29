using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Year { get; set; }

        public Book(int id, string title, string author, DateTime year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
        }
        public void Print()
        {
            Console.WriteLine($"Book Id: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"The datetime of the book publication: {Year.Year}\n");
        }
    }
}
