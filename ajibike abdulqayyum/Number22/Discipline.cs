using System;

namespace Number22
{
    public class Discipline
    {
          public string DisciplineName{get; set;}
          public string NumberOfLesson{get; set;}
          public string NumberOfExercises{get; set;}
          public Discipline(string disciplinename, string numberOflesson, string numberOfExercises)
          {
               DisciplineName =  disciplinename;
               NumberOfLesson = numberOflesson;
               NumberOfExercises = numberOfExercises;
          }
    }
}