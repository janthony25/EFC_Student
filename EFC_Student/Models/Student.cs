using System.ComponentModel.DataAnnotations;

namespace EFC_Student.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        ICollection<Course> Courses { get; set; }
    }
}
