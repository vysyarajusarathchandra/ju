using ju.entity;
using Microsoft.EntityFrameworkCore;

namespace ju.Database
{
    public class Mycontext:DbContext
    {
        public DbSet<User>Users { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MAv-SQLSERVER;Database=sarath123456789;Trusted_Connection=True;MultipleActiveREsultSets=True");
        }
    }
}
