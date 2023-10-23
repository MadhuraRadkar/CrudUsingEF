using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudUsingEF.Models
{
    // This class is also called as Entity Class or BO(Business object) / POCO(plain old CLR object) class
    [Table("Book")]  // Map class with table in DB
    public class Book
    {
        [Key]  // this is primary key col in DB
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
