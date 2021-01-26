using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DT102G_Moment_1.Model
{
    public static class Cources
    {
        private static List<Course> Courses = new List<Course>() {
            new Course() { CourseCode= "DT057G", CourseName= "Webbutveckling I" },
            new Course() { CourseCode= "FT162G", CourseName= "JavaScript webbutveckling" },
            new Course() { CourseCode= "DT084G", CourseName= "Introduktion till programmering i JavaScript" },
            new Course() { CourseCode= "DT163G", CourseName= "Digital bildbehandling för webb" },
            new Course() { CourseCode= "GD008G", CourseName= "Typografi och form för webb" },
            new Course() { CourseCode= "IK060G", CourseName= "Projektledning" },
            new Course() { CourseCode= "DT071G", CourseName= "Programmering i C#.NET" },
            new Course() { CourseCode= "DT173G", CourseName= "Webbutveckling III" },
            new Course() { CourseCode= "DT102G", CourseName= "ASP.NET med C#" },
            new Course() { CourseCode= "DT003G", CourseName= "Databaser" },
            new Course() { CourseCode= "DT093G", CourseName= "Webbutveckling II" },
            new Course() { CourseCode= "DT152G", CourseName= "Webbdesign för CMS" },
            new Course() { CourseCode= "DT068G", CourseName= "Webbanvändbarhe" }
        };

        public static List<Course> AllCourses { get => Courses; }
    }
}
