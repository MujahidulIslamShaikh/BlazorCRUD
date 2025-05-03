using BlazorCRUD.Library;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.API.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor to pass options to the base class   
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for the tables (replace 'TableName' with your actual table name)
        public DbSet<Student> tbl_Student { get; set; } // Example table for tal_Student

        public DbSet<Demo> tbl_Demo { get; set; }




    }
}
