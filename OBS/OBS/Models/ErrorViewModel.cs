using System.Collections.Generic;

namespace OBSProject.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Teacher
    {
        public string TeacherId { get; set; }
        public string Name { get; set; }
    }

    public class Document
    {
        public string TeacherId { get; set; }
        public string DocumentName { get; set; }
    }
}
