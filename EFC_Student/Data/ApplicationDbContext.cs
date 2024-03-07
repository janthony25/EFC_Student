using EFC_Student.Models;
using Microsoft.EntityFrameworkCore;

namespace EFC_Student.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOne<Student>(i => i.Student)
                .WithMany(c => Courses)
                .HasForeignKey(i => i.StudentId)
                .IsRequired();
        }
    }
}
