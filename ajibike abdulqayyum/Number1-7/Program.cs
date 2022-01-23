using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StudentTest st = new StudentTest();
               st.PrintInfo();
            StudentTest.Name = "Eisten";
            StudentTest.Course = "Mathematics";
            StudentTest.Subject = "Physic";
            StudentTest.University = "FUNAAB";
            StudentTest.Email = "www.com";
            StudentTest.PhoneNum = "09087365";
            Console.WriteLine($"{StudentTest.Name}{StudentTest.Course}{StudentTest.Subject}{StudentTest.University}{StudentTest.Email}{StudentTest.PhoneNum}");
        }
        // StudentTest student1 = new StudentTest();
            // student1.Name = "Ade";
            // student1.Course = "Mathematics";
            // student1.Subject = "Physics";
            // student1.University = "UniLag";
            // student1.Email = "www.ade@gmail.com";
            // student1.PhoneNum = "0874658732";
            // Console.WriteLine($"{student1.Name} {student1.Course} {student1.Subject} {student1.University} {student1.Email} {student1.PhoneNum} ");            
            // StudentTest student2 = new StudentTest();
            // student2.Name = "Ade";
            // student2.Course = "Mathematics";
            // student2.Subject = "Physics";
            // student2.University = "UniLag";
            // student2.Email = "www.ade@gmail.com";
            // student2.PhoneNum = "0874658732";
            // Console.WriteLine($"{student2.Name} {student2.Course} {student2.Subject} {student2.University} {student2.Email} {student2.PhoneNum} ");            
    }
}
