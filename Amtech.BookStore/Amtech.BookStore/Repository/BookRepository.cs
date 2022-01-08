using Amtech.BookStore.Data;
using Amtech.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Amtech.BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;

        public BookRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }
        public async Task<int> AddNewBook(BookModel bookModel)
        {
            var newBook = new Book()
            {
                author = bookModel.author,
                description = bookModel.description,
                Name = bookModel.Name,
                TotalPages = bookModel.TotalPages ?? 0,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                Language = bookModel.Language == null ? "English" : bookModel.Language
            };

            await _bookStoreDbContext.Book.AddAsync(newBook);
            await _bookStoreDbContext.SaveChangesAsync();
            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
           var booksList= await _bookStoreDbContext.Book.ToListAsync();
           return booksList.Select(a => new BookModel
            {
                Id = a.Id,
                Name = a.Name,
                description = a.description,
                TotalPages = a.TotalPages,
                author = a.author,
                Category = a.Category,
            }).ToList();
            //return GetBooksData();
        }
        public async  Task<BookModel> GetBookByid(int id)
        {
            var book = await _bookStoreDbContext.Book.FindAsync(id);
            return new BookModel
            {
                Id = book.Id,
                Name = book.Name,
                description = book.description,
                TotalPages = book.TotalPages,
                author = book.author,
                Category = book.Category,
            };
            //return _bookStoreDbContext.Book.Where(a => a.Id == id).FirstOrDefaultAsync();
            //return GetBooksData().Where(a => a.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBooks(string author,string name )
        {
            return GetBooksData().Where(a => a.Name.Contains(name) || a.author.Contains(author)).ToList();
        }
        private List<BookModel> GetBooksData()
        {
            return new List<BookModel>
            {
                new BookModel{Id=100,Name="Mvc",author="Raymond C", description="This is MVC Book Description" ,Category="Programming",TotalPages=876,Language="English"},
                new BookModel{Id=101,Name="Dot Net Core Mvc",author="Raymond C" , description="This book will cover all details about ASP.Net Core MVC. This book is specially designed for freshers to pro knowledge. After reading this book you wil able to develop fully functional application using asp.net mvc framework.",Category="Programming",TotalPages=876,Language="English"},
                new BookModel{Id=102,Name="Java",author="Patric", description="This is JAVA Book Description",Category="Programming",TotalPages=4098,Language="English"},
                new BookModel{Id=103,Name="PHP",author="Hammand", description="This is PHP Book Description",Category="Programming",TotalPages=2348,Language="English"},
                new BookModel{Id=104,Name="JavaScript",author="Lui Chrown", description="This is JavaScript Book Description",Category="Backend",TotalPages=609,Language="English"},
                new BookModel{Id=105,Name="Azure DevOps",author="Mack Brown", description="This is Azure Devops Book Description",Category="Cloud",TotalPages=1107,Language="English"}
            };
        }
    }
}
