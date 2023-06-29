using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Mark
    {
        [Key]
        public int Key { get; set; }
        public StudentSubject StudentSubject { get; set; }
        [Required]
        public int StudentSubjectId { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
