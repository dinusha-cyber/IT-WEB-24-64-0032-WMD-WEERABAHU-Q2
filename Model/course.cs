using System.ComponentModel.DataAnnotations;

namespace Q2.Model
{
    public class course
    {
        [Key]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string LectureName { get; set; }
    }
}
