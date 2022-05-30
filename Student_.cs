namespace API_Example
{
    [Table]
    public class Student_
    {
        public Student_()
        {

        }

        [Reqiredd]
        public int id { get; set; }
        [Reqiredd]
        public string name{ get; set; }
        public string surname { get; set; }
        public int age { get; set; }

    }
}
