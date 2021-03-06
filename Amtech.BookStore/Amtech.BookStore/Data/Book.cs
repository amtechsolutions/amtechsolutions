using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amtech.BookStore.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string Category { get; set; }
        public short TotalPages { get; set; }
        public string Language { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
