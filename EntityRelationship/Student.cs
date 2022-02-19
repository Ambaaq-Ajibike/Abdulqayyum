namespace EntityRelationship
{
    public class Student
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public int DepartmentID{get; set;}
        public Department Department{get; set;}
        public int StateID{get; set;}
        public State State{get; set;}        
        public virtual List<StudentCourse> StudentCourse{get; set;}
    }
}