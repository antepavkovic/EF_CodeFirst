using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]

        public int StudentId{ get; set; }
        public string StudentName { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy.}")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

    }
}
