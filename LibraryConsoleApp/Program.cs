using LibraryConsoleApp.Models;
using System.Threading.Tasks.Dataflow;

Library library = new();
library.Name = "Test";
library.Email = "test@test.com";
library.Address = "Test kucesi";
library.PhoneNumber = "1234567890";

string details = library.GetDetails();


Category category1 = new();
category1.Id = 1;
category1.Name = "Classics";

Author author1 = new();
author1.Id = 1;
author1.Name = "Çingiz";
author1.Surname = "Abdullayev";
author1.Age = 30;
author1.BirthDate = "16.05.1985";
author1.Email = "auhtor1@author.com";

Book book = new Book();
book.Id = 1;
book.Name = "Drongo";
book.PageCount = 265;
book.Price = 15.99M;
book.AuthorName = author1.Name;
book.CategoryName = category1.Name;


Console.WriteLine(book.AuthorName);