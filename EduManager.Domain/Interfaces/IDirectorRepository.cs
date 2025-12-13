using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduManager.Domain.interfaces
{
    public interface IDirectorRepository : IRepository<Director>
    {
        Task<Director?> GetByDepartmentAsync(string department);
    }
}