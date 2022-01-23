using System;

namespace Number1
{
    public class StudentTest 
    {
        public void PrintInfo()
        {
            Student student = new Student("Yusroh");
            Student student1 = new Student("Software Engineering", "Mathematics","Unilag" );
            Student student2 = new Student("www.dege.com","087872653");
            Console.WriteLine($"{student.Name}{student1.Course}{student1.Subject}{student1.University}{student2.Email}{student2.PhoneNum}");

        }
        public static string Name;
        public static string Course;
        public static string Subject;
        public static string University;
        public static string Email;
        public static string PhoneNum;

         static StudentTest()
        {
           

        }
        
    }
}    