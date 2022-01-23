using System;

namespace Number22
{
    public class StudentClasses : Teachers
    {
        public int NumberOfTeacchers{get; set;}
        public StudentClasses(string disciplinename, string numberOflesson, string numberOfExercises, int numberOfDiscipline, int numberOfTeacchers) : base(disciplinename, numberOflesson, numberOfExercises, numberOfDiscipline)
        {
            NumberOfTeacchers = numberOfTeacchers;
        }
    }
}