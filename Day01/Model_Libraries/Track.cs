using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Libraries
{
    public class Track
    {
        [Key]
        public int Track_ID { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Track Name is Required")]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        public string Description { get; set; }

    }
}
