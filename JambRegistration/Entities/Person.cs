using System;
namespace JambRegistration.Entities
{
    public class Person
    {
        public int ID{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Address{get; set;}
        public string Email{get; set;}
        public string PassWord{get; set;}
        public Gender Gender{get; set;}
    }
}