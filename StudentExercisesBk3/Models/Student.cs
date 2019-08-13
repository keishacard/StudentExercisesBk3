using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesBk3.Models
{
    public class Student
    {
        //[Required]
        //Get rid of required so that this value can be null
        [Display(Name = "Student Id")]
        //? after int or datetime makes it so it can be null
        //otherwise your student id will be 0, which you don't want
        public int? Id { get; set; }

        [Required]
        //MaxLengthAttribute, etc are atributes and have to do with your validation in browser
        [MaxLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }

        [Required]
        [Display(Name = "Cohort Id")]
        public int CohortId { get; set; }

        //'computed property'
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
