using System;

namespace Number22
{
    public class Student
    {
        public string StudentsName{get; set;}
        public int StudentID{get;}
        public Student(string studentname, int studentid)
        {
            StudentsName = studentname;
            StudentID = GetStudentID();
        }
        public int GetStudentID()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 100);
            return x;
        }  
    }
}