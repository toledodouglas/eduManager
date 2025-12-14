using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EduManager.Domain.Entities;

namespace EduManager.Domain.Interfaces
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        Task<Teacher?> GetByEmailAsync(string email);
    }
}