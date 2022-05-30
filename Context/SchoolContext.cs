using API_Example.Models;
using System.Data.Entity;

namespace API_Example.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes{ get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student_> Students{ get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
    }
}
