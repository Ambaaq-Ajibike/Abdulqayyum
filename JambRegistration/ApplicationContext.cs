using System;
using Microsoft.EntityFrameworkCore;
using JambRegistration.Entities;
namespace JambRegistration
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;user=root;database=JambRegistration;port=3306;password=ajibikeabdulqayyumambaaq");
        }
        public DbSet<Admin> Admins{get; set;}
        public DbSet<Center> Centers{get; set;}
        public DbSet<Schools> Schools{get; set;}
        public DbSet<Student> Students{get; set;}
        public DbSet<StudentSubject> StudentSubjects {get; set;}
        public DbSet<Subject> Subjects {get; set;}
        public DbSet<Course> Courses {get; set;}
        public DbSet<SchoolCourse> SchoolCourses {get; set;}
    }
}