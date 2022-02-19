using System;
namespace EntityRelationship
{
    public class State
    {
        public int ID {get; set;}
        public string Name{get; set;}
        public virtual List<Student> students{get; set;}
    }
}