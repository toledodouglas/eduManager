using System;

namespace EduManager.Domain.Entities
{
    public class Director : Person
    {
        public string Department { get; set; } = string.Empty;

        public Director() {}
        public Director(string name, int age, string email, string password, string department)
            : base(name, age, email, password)
        {
            Department = department;
        }
    }
}