using System;
using System.Collections.Generic;

namespace EduManager.Domain.Entities
{
    public class Teacher : Person
    {
        public string Subject { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Teacher() {}
        public Teacher(string name, int age, string email, string password, string matter, decimal salary)
            : base(name, age, email, password)
        {
            Subject = subject;
            Salary = salary;
        }
    }
}