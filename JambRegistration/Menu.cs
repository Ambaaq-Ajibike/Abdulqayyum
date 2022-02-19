using System;
using JambRegistration.Entities;
using System.Collections.Generic;
using System.Linq;
using JambRegistration;
using Microsoft.EntityFrameworkCore;
using JambRegistration.Repositories;
namespace JambRegistration
{
    public class Menu
    {
        private readonly ApplicationContext context;
        private readonly CenterRepository centerrepository;
        private readonly SchoolRepository schoolRepository;
        private readonly SubjectRepository subjectrepo;
        private readonly StudentRepository  studentrepo;
        private readonly CourseRepository  courserepo;
        private readonly AdminRepository  adminrepo;
       
       public Menu()
       {
           context = new ApplicationContext();
           centerrepository = new CenterRepository(context);
           courserepo = new CourseRepository(context);
           schoolRepository =  new SchoolRepository(context, courserepo);
           subjectrepo = new SubjectRepository(context);           
           adminrepo = new AdminRepository(context);     
           studentrepo = new StudentRepository(context, centerrepository, schoolRepository, subjectrepo, courserepo);

       }
        public void AdminMenu()
        {
               System.Console.WriteLine("Enter your password");
               var password = Console.ReadLine();
               System.Console.WriteLine("Enter your ID");
               var id = Console.ReadLine();
               var verifypassword = context.Admins.SingleOrDefault(a => a.PassWord == password && a.AdminId == id);
               if (verifypassword == null)
               {
                   System.Console.WriteLine("You are not recognise");
               }
               else
               {
                   System.Console.WriteLine("You have successfully logged in to this portal");
                   while (true)
                   {
                       System.Console.WriteLine("To perform operation on center press 1\n To perform operation on School press 2\n To perform operation on Subject press 3\n To perform operation on student press 4\nTo log out press 0");
                        System.Console.Write("Enter num:\t");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                       System.Console.WriteLine("Enter\n 1 to create center\n 2 to update center\n 3 to delete center\n4 to get a particular center\n5 to Get all available centers\n0To log out from center");
                       Console.Write($"Enter num:\t");                       
                        int centerchoice = int.Parse(Console.ReadLine());  
                        while (true)
                        {
                                switch (centerchoice)
                            {
                                case 1:
                                        courserepo.AddCourse();
                                    break;
                                case 2:
                                        centerrepository.UpdateCenter();
                                    break;
                                case 3:
                                        centerrepository.DeleteCenter();
                                    break;
                                case 4:
                                        centerrepository.GetCenter();
                                    break;
                                case 5:
                                        centerrepository.GetAllCenters();
                                    break;
                                default:
                                    break;
                            }
                            if (centerchoice == 0)
                            {
                                break;
                            }
                        }                         
                   }
                   else if (choice == 2)
                   {
                        System.Console.WriteLine("Enter\n 1 to create school\n 2 to update school\n 3 to delete school\n4 to Get all available schoolss \n5 to get a particular school\n0 To log out from subject");
                        Console.Write($"Enter num:\t");                    
                        int schoolchoice = int.Parse(Console.ReadLine()); 
                        while (true)
                        {
                            switch (schoolchoice)
                            {
                                case 1:
                                        schoolRepository.CreateSchool();
                                    break;
                                case 2:
                                        schoolRepository.UpdateSchool();
                                    break;
                                case 3:
                                        schoolRepository.DeleteSchool();
                                    break;
                                case 4:
                                        schoolRepository.GetAllSchools();
                                    break;
                                case 5:
                                        schoolRepository.GetSchool();
                                    break;
                                default:
                                    break;
                                
                            } 
                            if (schoolchoice == 0)
                            {
                                break;
                            }
                        }                          
                   }
                   else if(choice == 3)
                   {
                        System.Console.WriteLine("Enter\n 1 to create subject\n 2 to update subject\n 3 to delete subject\n4 to Get all available subjects \n5 to get a particular subject\n0 To log out from subject");
                        Console.Write($"Enter num:\t");                                             
                        int subjectchoice = int.Parse(Console.ReadLine());    
                        while (true)
                        {
                            switch (subjectchoice)
                            {
                                case 1:
                                        subjectrepo.CreateSubject();
                                    break;
                                case 2:
                                    subjectrepo.UpdateSubject();
                                break;
                                case 3:
                                subjectrepo.DeleteSubject();
                                break;
                                case 4:
                                    subjectrepo.GetAllSubject();
                                break;
                                case 5:
                                    subjectrepo.GetSubject();
                                break;
                                default:
                                break;
                            }
                            if (subjectchoice == 0)
                            {
                                break;
                            } 
                        }
                    }
                        else if (choice == 4)
                        {
                            System.Console.WriteLine("Enter\n1 to get all the students in  a particular center\n2 To Get all registered Student \n3 To get a particular subject\n4 To get the subject offered by a particular student\n5 to view all students offering a particular subject\n6 To Edit Student Profile \n0 To log out from student");
                            Console.Write($"Enter num:\t");                                              
                            int studentchoice = int.Parse(Console.ReadLine()); 
                            while (true)
                            {
                                switch (studentchoice)
                                {
                                    case 1:
                                            studentrepo.GetAllStudentByCenter();
                                        break;
                                    case 2:
                                            studentrepo.GetAllStudent();
                                        break;
                                    case 3:
                                            System.Console.WriteLine("Enter the student id");
                                    var stids = int.Parse(Console.ReadLine());                                    
                                            studentrepo.GetStudentAdmin(stids);
                                        break;
                                    case 4:
                                    System.Console.WriteLine("Enter student id");
                                    int stid = int.Parse(Console.ReadLine());                                    
                                            studentrepo.GetSubjectByStudent(stid);
                                        break;
                                    case 5:
                                            studentrepo.GetStudentBySubject();
                                        break; 
                                    case 6:
                                            studentrepo.EditProfile();
                                        break;
                                    default:
                                        break;
                                }
                                if (studentchoice == 0)
                                {
                                    break; 
                                }
                            }  
                        }
                        if(choice == 0)
                        {
                            break;
                        }
                   }
               }               
                      
        }
        public void StudentMenu()
        {
            System.Console.WriteLine("Enter 1 to Register\nEnter 2 to view your Profile");
            Console.Write($"Enter num:\t");                                
            var response = int.Parse(Console.ReadLine());
            if(response == 1)
            {
                studentrepo.StudentRegistration();
            }  
            else if(response == 2)     
            {
               System.Console.WriteLine("Enter your password");
                var stids = Console.ReadLine();                                    
                        studentrepo.GetStudent(stids);  
            }
        }    
    }
}