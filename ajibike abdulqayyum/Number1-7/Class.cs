using System;

namespace Number1
{
    public class Student
    {
        public string Name;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public string PhoneNum;
        public Student(){}
        public Student(string name)
        {
            Name = name;
            
        }
        public Student(string course, string subject, string university)
        {
            Course = course;
            Subject = subject;
            University = university;
        }
        public Student(string email, string phoneNum)
        {
            Email = email;
            PhoneNum = phoneNum;
        }
       
        
        
    }
}