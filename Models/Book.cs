using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_4.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }   
    }
}
