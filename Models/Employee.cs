using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandyApp.Models
{
    public class Employee
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        [MinLength(2,ErrorMessage ="must be more than 2 letters " )]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MinLength(4,ErrorMessage ="must be more than 4 letters ")]
        [MaxLength (30) ]
        public string Speciality { get; set; }



    }
}
