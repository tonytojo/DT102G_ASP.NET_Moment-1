using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DT102G_Moment_1.Model;

namespace DT102G_Moment_1.Pages
{
    public class RazorModel : PageModel
    {
        public List<Course> Courses = Cources.AllCourses;

        public void OnGet()
        {
        }
    }
}
