using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } 
    }
}
