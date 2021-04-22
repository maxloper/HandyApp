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
        public string Name { get; set; }

        public string Speciality { get; set; }



    }
}
