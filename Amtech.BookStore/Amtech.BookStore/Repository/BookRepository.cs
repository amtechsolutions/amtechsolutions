using Amtech.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amtech.BookStore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return GetBooksData();
        }
        public Book GetBookByid(int id)
        {
            return GetBooksData().Where(a => a.Id == id).FirstOrDefault();
        }
        public List<Book> SearchBooks(string author,string name )
        {
            return GetBooksData().Where(a => a.Name.Contains(name) || a.author.Contains(author)).ToList();
        }
        private List<Book> GetBooksData()
        {
            return new List<Book>
            {
                new Book{Id=100,Name="Mvc",author="Raymond C"},
                new Book{Id=101,Name="Dot Net Core Mvc",author="Raymond C"},
                new Book{Id=102,Name="Java",author="Patric"},
                new Book{Id=103,Name="PHP",author="Hammand"},
                new Book{Id=104,Name="JavaScript",author="Lui Chrown"}
            };
        }
    }
}
