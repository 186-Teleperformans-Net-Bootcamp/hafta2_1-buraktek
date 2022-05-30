using System.ComponentModel.DataAnnotations;

namespace API_Example.Models
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students{ get; set; }
    }
}
