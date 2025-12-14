using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EduManager.Domain.Entities;


namespace EduManager.Domain.Interfaces
{
    public interface IDirectorRepository : IRepository<Director>
    {
        Task<Director?> GetByDepartmentAsync(string department);
    }
}