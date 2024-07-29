﻿using OOP_task_Library;

Book book1 = new Book(1, "The World According to Clarkson", "Jeremy Clarkson", new DateTime (2007, 10, 24));
Book book2 = new Book(2, "Punk57", "Nicole Fraugh", new DateTime(2011, 9, 14));
Book book3 = new Book(3, "Dingo", "Jake Guerhter", new DateTime(1945, 4, 30));
Book book4 = new Book(4, "The Test", "Nathan Leamon", new DateTime(2024, 1, 12));
Book book5 = new Book(5, "Murder on the Orient Express", "Agatha Christie", new DateTime(2001, 9, 11));
Book book6 = new Book(6, "Surger", "Tess Garytson", new DateTime(2014, 7, 1));

Library library1 = new Library("library1");

library1.AddBook(book1);
library1.AddBook(book2);
library1.AddBook(book3);
library1.AddBook(book4);
library1.AddBook(book5);
library1.AddBook(book6);

library1.DisplayBooks();

library1.RemoveBook(4);
library1.DisplayBooks();