using System;

namespace EduManager.Domain.Entities
{
    public abstract class Person
    {
        public int Id {get; set;}
        public int Age {get; set; }
        public string Name {get; set; } = string.Empty;
        public string Email {get; set; } = string.Empty;
        public string Password {get; set; } = string.Empty;

        public DateTime DateRegistration { get; set; } = DateTime.Now;

    }
}
