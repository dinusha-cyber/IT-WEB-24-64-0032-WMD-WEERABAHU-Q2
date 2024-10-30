using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q2.Model
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        
        [ForeignKey(nameof(course))]
        
        public int CourseId { get; set; }
        public course? course { get; set; }
    }
}
