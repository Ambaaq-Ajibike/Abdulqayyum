using System;
using System.Collections.Generic;
using System.Collections;
namespace JambRegistration.Entities
{
    public class Center
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public string Address  {get; set;}
        public int Capacity{get; set;}
        List<Student> students{get; set;} = new List<Student>();
    }
}