using System;

namespace Number22
{
    public class Teachers : Discipline
    {
        public int NumberOfDiscipline{get; set;}
         public Teachers(string disciplinename, string numberOflesson, string numberOfExercises, int numberOfDiscipline) : base(disciplinename, numberOflesson, numberOfExercises)
         {
             NumberOfDiscipline = numberOfDiscipline;
         }

    }
}