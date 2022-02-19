using System;
namespace EntityRelationship
{
    public class Course
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public virtual List<StudentCourse> StudentCourses{get; set;}
    }
}