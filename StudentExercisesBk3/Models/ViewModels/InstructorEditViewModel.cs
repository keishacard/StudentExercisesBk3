using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using StudentExercisesBk3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentExerciseMVC.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        private readonly IConfiguration _config;

        public List<SelectListItem> Cohorts { get; set; }
        public Instructor Instructor { get; set; }

        public InstructorEditViewModel() { }

        public InstructorEditViewModel(IConfiguration config)
        {

            /*
                Query the database to get all cohorts
            */


            /*
                Use the LINQ .Select() method to convert
                the list of Cohort into a list of SelectListItem
                objects
            */
        }
    }
}