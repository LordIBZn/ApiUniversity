using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }

        //ADD Dbset (Tables of out Data base)
        public DbSet<User>? Users { get; set; }  
        public DbSet<Course>? Courses { get; set; }
    }
}
