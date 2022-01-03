using Amtech.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amtech.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return GetBooksData();
        }
        public BookModel GetBookByid(int id)
        {
            return GetBooksData().Where(a => a.Id == id).FirstOrDefault();
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
