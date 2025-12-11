using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduManager.Domain.interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student?> GetByIdAsync(int id);
    }
}