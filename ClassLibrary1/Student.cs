using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Student
    {
        public string Group { get; set; }
        public string YearInjection { get; set; }
        public string FIO { get; set; }
        public List<Mark> Marks { get; set; } = new List<Mark>();
    }
}