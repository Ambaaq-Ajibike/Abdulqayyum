using System;
using System.Collections.Generic;
using System.Collections;
namespace JambRegistration.Entities
{
    public class Schools
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public string Address{get; set;}
        public List<SchoolCourse> SchoolCourses{get; set;} = new List<SchoolCourse>();
    }
}