using System;
using System.Collections.Generic;
namespace JambRegistration.Entities
{
    public class Course
    {
        public int ID{get; set;}  
        public string Name{get; set;}
        public List<SchoolCourse> SchoolCourses{get; set;} = new List<SchoolCourse>();
    }
}