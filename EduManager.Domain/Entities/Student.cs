using System;

namespace EduManager.Domain.Entities
{
    public class Student : Person
    {
        public string Registration { get; set; } = string.Empty;
        public double Score1 { get; set; }
        public double Score2 { get; set; }
        public double Score3 { get; set; }
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
    }
}
