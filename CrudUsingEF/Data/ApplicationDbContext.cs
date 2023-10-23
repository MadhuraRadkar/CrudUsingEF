using CrudUsingEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudUsingEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op):base(op)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get;  set; }
    }

}
