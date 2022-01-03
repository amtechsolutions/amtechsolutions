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
            var books = _book.GetAllBooks();
            return View(books);
        }
        public ViewResult GetBook(int id)
        {
            var bookModel= _book.GetBookByid(id);
            return View(bookModel);
        }
        public List<BookModel> SearchBooks(string author, String bookName)
        {
            return _book.SearchBooks( author, bookName);
        }
        public ViewResult AddNewBook()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            return View();
        }
    }
}
