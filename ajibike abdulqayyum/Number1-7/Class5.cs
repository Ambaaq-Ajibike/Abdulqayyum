using System;

namespace Number1
{
    public class Pupil
    {
        private string Name;
        private string Course;
        private string Subject;
        private string University;
        private string Email;
        private string PhoneNum;
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetCourse(string course)
        {
            this.Course = course;
        }
        public string GetCourse()
        {
            return Course;
        }
        public void SetSubject(string subject)
        {
            this.Subject = subject;
        }
        public string GetSubject()
        {
            return Subject;
        }
        public void SetUniversity(string university)
        {
            this.University = university;
        }
        public string GetUniversity()
        {
            return University;
        }
        public void SetEmail(string email)
        {
            this.Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetPhoneNum(string phoneNum)
        {
            this.PhoneNum = phoneNum;
        }
        public string GetPhoneNum()
        {
            return PhoneNum;
        }
    }
}