using System;
using System.Collections.Generic;

namespace EduManager.Domain.Entities
{
    public class Student : Person
    {
        public string Registration { get; set; } = string.Empty;
        public double Score1 { get; private set; }
        public double Score2 { get; private set; }
        public double Score3 { get; private set; }
        public double GeneralAverage
        {
            get 
            {
                return (Score1 + Score2 + Score3) / 3;
            }
        }
        public bool IsApproved 
        {
            get 
            {
                return GeneralAverage >= 7.0;
            }
        }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public Student() {}
        public Student(string name, int age, string email, string password, string registration) : base(name, age, email, password)
        {
            Registration = registration;
        }

        public void UpdateGrades(double n1, double n2, double n3)
        {
            Score1 = n1;
            Score2 = n2;
            Score3 = n3;
        }
    }
}
