using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EduManager.Domain.Entities;


namespace EduManager.Domain.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student?> GetByRegistrationAsync(string registration);
    }
}