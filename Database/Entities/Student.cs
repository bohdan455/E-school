using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? FatherName { get; set; }
        public ICollection<StudentSubject> StudentSubjects  { get; set; }
    }
}
