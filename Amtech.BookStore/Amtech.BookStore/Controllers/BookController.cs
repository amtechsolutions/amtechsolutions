using Amtech.BookStore.Models;
using Amtech.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amtech.BookStore.Controllers
{
    public class BookController:Controller
    {
        private readonly BookRepository _book = null;
        public BookController()
        {
            _book = new BookRepository();
        }
        public ViewResult GetBooks()
        {
            return View();
        }
        public Book GetBook(int id)
        {
            return _book.GetBookByid(id);
        }
        public List<Book> SearchBooks(string author, String bookName)
        {
            return _book.SearchBooks( author, bookName);
        }
    }
}
