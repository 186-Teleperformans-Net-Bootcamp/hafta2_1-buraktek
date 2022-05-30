using System.ComponentModel.DataAnnotations;

namespace API_Example.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
