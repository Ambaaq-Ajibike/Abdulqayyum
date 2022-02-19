using System;
using System.Collections.Generic;
using System.Collections;
namespace JambRegistration.Entities
{
    public class Subject
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public List<StudentSubject> studentsubject{get; set;} = new List<StudentSubject>();
    }
}