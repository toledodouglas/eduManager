using System;

namespace EduManager.Domain.Entities
{
    public class Teacher : Person
    {
        public string Matter { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}