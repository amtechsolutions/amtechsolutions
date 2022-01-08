using Amtech.BookStore.Data;
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
      
    public BookController(BookRepository book)
        {
          
            _book = book;
        }
        public async Task<ViewResult> GetBooks()
        {
            var books = await _book.GetAllBooks();
            return View(books);
        }
        public async Task<ViewResult> GetBook(int id)
        {
            var bookModel= await _book.GetBookByid(id);
            return View(bookModel);
        }
        public List<BookModel> SearchBooks(string author, String bookName)
        {
            return _book.SearchBooks( author, bookName);
        }
        public ViewResult AddNewBook(int bookId, bool isSaved)
        {
            ViewBag.BookId = bookId;
            ViewBag.IsSaved = isSaved;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if(ModelState.IsValid)
            {
                var id = await _book.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { bookId = id, isSaved = true });
                }
            }
            ViewBag.IsSaved = false;
            ViewBag.BookId = 0;
             return View();
        }
    }
}
