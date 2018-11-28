using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }


        public string Description { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Teachers")]
        public string ApplicationUserId { get; set; }
    }
}