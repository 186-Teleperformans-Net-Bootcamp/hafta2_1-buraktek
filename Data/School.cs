using System.ComponentModel.DataAnnotations;

namespace API_Example.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; } 
        public string Name { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
