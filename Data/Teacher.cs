using System.ComponentModel.DataAnnotations;

namespace API_Example.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int LessonId { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
