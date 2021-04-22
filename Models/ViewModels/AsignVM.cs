using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandyApp.Models.ViewModels
{
    public class AsignVM
    {

        public Asign Asign { get; set; }

        public IEnumerable<SelectListItem> TypeDropDown { get; set; }

       


   
    }
}
