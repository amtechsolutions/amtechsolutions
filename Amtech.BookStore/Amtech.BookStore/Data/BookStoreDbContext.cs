using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amtech.BookStore.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) :base(options)
        {
           
        }
        public DbSet<Book> Book { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=BookStore;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
