using System.ComponentModel.DataAnnotations;

namespace API_Example.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SchoolId { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        public int ClassId { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
