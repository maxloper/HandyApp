using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandyApp.Models
{
    public class Asign
    {

        // Asign model 

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MinLength(2, ErrorMessage = " please enter more than 2 letters")]
        public string Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = " please enter more than 2 letters")]
        public string Tasks { get; set; }
        [Required]
        [Phone]
        public string Telephone { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = " please enter a Street name  that has more than 4 letters")]
        public string Address { get; set; }
        
        public string Status { get; set; }
        [Url]
        public string ? ImageUrl { get; set; }




        public int EmployeeNameId { get; set; }
        [ForeignKey("EmployeeNameId")]
        public virtual Employee Employee { get; set; }
    }
}
