using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amtech.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Book name")]
        [StringLength(50,MinimumLength =10)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Enter Book Autor")]
        public string author { get; set; }
        public string description { get; set; }
        public string Category { get; set; }

        [Required(ErrorMessage ="Please Enter Book Pages")]
        [Display(Name ="Total Pages")]
        public short? TotalPages { get; set; }
        [Required]
        public string Language { get; set; }
    }
}
