using System;
using System.Collections.Generic;
using System.Collections;
using JambRegistration.Entities;
namespace JambRegistration.Entities
{
    public class Student : Person
    {
        public string ExaminationDate{get; set;}
        public int CenterID{get; set;}
        public Center center{get; set;}
        public string CourseFirstChoice{get; set;}
        public string CourseSecondChoice{get; set;}
        public string SchoolFirstChoice{get; set;}
        public string SchoolSecondChoice{get; set;}
        public DateTime DateOfBirth{get; set;} 
        public List<StudentSubject> studentsubject{get; set;} = new List<StudentSubject>();
    }
}