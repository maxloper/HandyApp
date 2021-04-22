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

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Tasks { get; set; }

        public string Telephone { get; set; }

        public string Address { get; set; }

        public string Status { get; set; }

        public string ImageUrl { get; set; }




        public int EmployeeNameId { get; set; }
        [ForeignKey("EmployeeNameId")]
        public virtual Employee Employee { get; set; }
    }
}
