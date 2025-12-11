using System;

namespace EduManager.Domain.Entities
{
    public class Director : Person
    {
        public string Department { get; set; } = string.Empty;
    }
}