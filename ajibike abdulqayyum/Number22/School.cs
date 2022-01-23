using System;

namespace Number22
{
    public class School : StudentClasses
    {
        public int NumberOfClass{get; set;}
        List<School> school = new List<School>();
        public School(string disciplinename, string numberOflesson, string numberOfExercises, int numberOfDiscipline, int numberOfTeacchers, int numberOfClass) : base(disciplinename, numberOflesson, numberOfExercises, numberOfDiscipline, numberOfTeacchers)
        {
            NumberOfClass = numberOfClass;
            GetSchoolnfo();
        }
        public void GetSchoolnfo()
        {
            school.Add(this);
        }
        public string PrintSchoolInfo()
        {
            foreach (var item in school)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}