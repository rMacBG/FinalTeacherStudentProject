using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Models
{
   public enum Speciality 
    {
        Math,
        Bulgarian,
        English,
        Russian,
        Polish,
        Portugal,
        Spanish,
        Chinese,
        Japanese,
        French,
        German,
        Algebra,
        Geometry,
        Electronics,
        Physics,
        Chemistry,
        Biology,
        Pharmacy,
        Bombing,
        IT,
        PE,
        History,
        [Display(Name ="Computer Science")]
        ComputerScience,
        Programming,
        [Display(Name ="Web Design")]
        WebDesign,
    }
}
