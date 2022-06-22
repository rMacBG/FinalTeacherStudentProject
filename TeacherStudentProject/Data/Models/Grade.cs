using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Models
{
  public enum Grade 
    {
        [Display(Name = "1st Grade")]
        FirstGrade= 1,
        [Display(Name = "2nd Grade")]
        SecondGrade,
        [Display(Name = "3rd Grade")]
        ThirdGrade,
        [Display(Name = "4th Grade")]
        FourthGrade,
        [Display(Name = "5th Grade")]
        FifthGrade,
        [Display(Name = "6th Grade")]
        SixthGrade,
        [Display(Name = "7th Grade")]
        SeventhGrade,
        [Display(Name = "8th Grade")]
        EighthGrade,
        [Display(Name = "9th Grade")]
        NinthGrade,
        [Display(Name = "10th Grade")]
        TenthGrade,
        [Display(Name = "11th Grade")]
        EleventhGrade,
        [Display(Name = "12th Grade")]
        TwlelfthGrade


        

    }
}
