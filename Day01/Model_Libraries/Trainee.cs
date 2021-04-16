using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Libraries
{
    public class Trainee
    {
        [Key]
        public int Trainee_ID { get; set; }
        [Required (ErrorMessage ="Trainee Name is Required")]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage ="Trainee Email is Required")]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
       
        public string MobileNumber { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public Graduated IsGraduated { get; set; }
        //Relationship is many  -------> one
       //                trainees ----> Track
       
       public virtual Track Track { get; set; }

    }
}
