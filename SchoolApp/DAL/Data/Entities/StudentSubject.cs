using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class StudentSubject
    {

        public int Id { get; set; }
        [ForeignKey("Student")]
        [Required]
        public int StudentId { get; set; }

        public Student Student { get; set; } = null!;

        
        [ForeignKey("Subject")]
        [Required]

        public int SubjectId {  get; set; }

        public Subject Subject { get; set; } = null!;



    }
}
