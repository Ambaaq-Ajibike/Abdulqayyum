using System;
using System.Collections.Generic;
namespace JambRegistration.Entities
{
    public class SchoolCourse
    {
        public int ID{get; set;}
        public int SchoolsID{get; set;}
        public Schools Schools{get; set;}
        public int CourseId{get; set;}
        public Course Course{get; set;}
    }
}