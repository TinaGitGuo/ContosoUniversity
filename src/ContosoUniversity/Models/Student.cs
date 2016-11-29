using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Required]
        [Column("FirstMidNa")]
        [Display(Name = "First Name")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        //[MaxLength(2)]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public DateTime EnrollmentDate { get; set; }

      

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
