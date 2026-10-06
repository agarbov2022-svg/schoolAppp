using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string SubjectType { get; set; } = null!;

        [Range(2,6)]

        public double Grade { get; set; }

        [Required]
        public DateTime ReceivedOn { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; } = null!;

    }
}
